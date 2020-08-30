//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace SQLASSI
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse

        );

        private int customerIndex = 0, moviesIndex = 0, rentalIndex = 0, selectedCustomedID, selectedMovieID, selectedRentalID, selectedTab, selectedMovieCount, rentalPeriod;
        private int selectedRentedMovieID = 0, selectedRentedMovieCount;
        private string selectedMovie;
        
        //private string host = "DESKTOP-PANDEYIAM\\SQLEXPRESS01", database = "A2";
       // @"Data Source=PANDEYIAM\SQLEXPRESS01;Initial Catalog=A2;Integrated Security=True"

        public Form1()
        {
            InitializeComponent();
            // Get round border for launcher
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            GetCustomersList();
            GetMovies();
            GetRentedMovies();
            AddMovieGenre();

            // Set minimum date and time values to make sure user doesn't try to register in past date
            rentingDate.MinDate = DateTime.Now;
            returningDate.MinDate = rentingDate.MinDate.AddDays(1);

            // Updates the tab index when the app launches
            selectedTab = tabControl1.SelectedIndex;
            UpdateIndex();
        }
        //its for Delete the Custmer
        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            // This automatically closes the connection when needed
            using (SqlConnection conn = new SqlConnection(HostConfigurations()))
            {
                // Connection Established
                conn.Open();

                if (GetUserRentedMovies(selectedCustomedID) > 0)
                {
                    MessageBox.Show("User cannot be deleted as this user has rented movies.");
                }
                else
                {
                    // Update Data Query
                    SqlCommand _cmd = new SqlCommand("DELETE FROM Customers WHERE customerID=@cID", conn);
                    _cmd.Parameters.AddWithValue("cID", selectedCustomedID.ToString());
                    _cmd.ExecuteNonQuery();
                }

                // This function is used to update the table where customers are listed
                GetCustomersList();

                // Here we reset all the fields to empty
                ResetFields();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a2DataSet2.rentedmovies' table. You can move, or remove it, as needed.
            this.rentedmoviesTableAdapter.Fill(this.a2DataSet2.rentedmovies);
            // TODO: This line of code loads data into the 'a2DataSet1.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.a2DataSet1.Movies);
            // TODO: This line of code loads data into the 'a2DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.a2DataSet.Customers);

        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabControl1.SelectedIndex;
            UpdateIndex();
        }

        public string HostConfigurations()
        {
            // Host Configurations 
            return @"Data Source=PANDEYIAM\SQLEXPRESS01;Initial Catalog=A2;Integrated Security=True";

            //"Server=" + host + ";Database=" + database + ";Integrated Security=SSPI;";
        }
        //its for  Add movie  button
        private void AddMovie_Click(object sender, EventArgs e)
        {

            if (movieTitle.Text != "" || movieYear.Text != "")    // Makes sure that user doesn't try to submit with empty fields
            {
                // This automatically closes the connection when needed
                using (SqlConnection conn = new SqlConnection(HostConfigurations()))
                {
                    // Connection Established
                    conn.Open();
                    // Add Data Query
                    SqlCommand _cmd = new SqlCommand("INSERT INTO Movies (ratings, title, year, rentalCost, copies, genre) VALUES (@ratings, @title, @year, @rentalCost, @copies, @genre)", conn);
                    // Movie Fields
                    _cmd.Parameters.AddWithValue("ratings", Convert.ToInt32(movieRatings.Value));
                    _cmd.Parameters.AddWithValue("title", movieTitle.Text.ToString());
                    _cmd.Parameters.AddWithValue("year", movieYear.Text.ToString());
                    _cmd.Parameters.AddWithValue("rentalCost", movieRentingPrice.Value.ToString());
                    _cmd.Parameters.AddWithValue("copies", movieCopiesAvailable.Value.ToString());
                    _cmd.Parameters.AddWithValue("genre", movieGenre.SelectedItem.ToString());
                    _cmd.ExecuteNonQuery();

                    // This function is used to update the table where customers are listed
                    GetMovies();

                    // Here we reset all the fields to empty
                    ResetFields();

                }
            }
            else
                MessageBox.Show("One or more fields are empty!");
        }

        public int PriceCalculation(int days, int rentalPrice)
        {
            // A very basic price calculation based on rental time
            if (days < rentalPeriod)
            {
                int extraPeriod = days - rentalPeriod;
                int overtimePrice = 3;

                return (rentalPeriod * rentalPrice) + (extraPeriod * overtimePrice);
            }
            else
                return days * rentalPrice;
        }
        private void GetCustomersList()
        {
            // This automatically closes the connection when needed
            using (SqlConnection conn = new SqlConnection(HostConfigurations()))
            {
                // Connection Established
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Customers", conn);
                DataTable CustomersTable = new DataTable();
                sqlDa.Fill(CustomersTable);

                customersList.DataSource = CustomersTable;
                customersList.AllowUserToDeleteRows = false;
                customersList.AllowUserToAddRows = false;
                customersList.AutoGenerateColumns = false;
                customersList.AutoResizeColumns();
            }
        }

        private void AddMovieGenre()
        {
            movieGenre.Items.Clear();       // Make sure that there are no existing items in combo box

            movieGenre.Items.Add("Action");
            movieGenre.Items.Add("Adventure");
            movieGenre.Items.Add("Animated");
            movieGenre.Items.Add("Horror");
            movieGenre.Items.Add("Sci-Fi");

            // Set the first index as selected
            movieGenre.SelectedIndex = 0;
        }

        private void ResetFields()
        {
            // Sets empty text in the text fields when unselected and disables non-required buttons
            firstNameField.Text = "";
            lastNameField.Text = "";
            addressField.Text = "";
            PhoneNumberField.Text = "";
            AddCustomer.Enabled = true;
            UpdateCustomer.Enabled = false;
            DeleteCustomer.Enabled = false;

            movieRatings.Value = 0;
            movieTitle.Text = "";
            movieYear.Text = "";
            movieRentingPrice.Value = 0;
            movieCopiesAvailable.Value = 0;
            movieGenre.SelectedIndex = -1;
            DeleteMovie.Enabled = false;

            UpdateIndex();
        }

        private void GetMovies()
        {
            // This automatically closes the connection when needed
            using (SqlConnection conn = new SqlConnection(HostConfigurations()))
            {
                // Connection Established
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Movies", conn);
                DataTable MoviesTable = new DataTable();
                sqlDa.Fill(MoviesTable);

                moviesList.DataSource = MoviesTable;
                moviesList.AllowUserToDeleteRows = false;
                moviesList.AllowUserToAddRows = false;
                moviesList.AutoGenerateColumns = false;
                moviesList.AutoResizeColumns();

                // Here we are running second query to get the movies into ComboBox
                SqlCommand command = new SqlCommand("SELECT * FROM Movies", conn);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                rentingMovie.Items.Clear();
                while (reader.Read())
                {
                    string movieTitle = reader["title"].ToString();
                    selectedMovieCount = Convert.ToInt32(reader["copies"]);
                    rentingMovie.Items.Add(movieTitle);
                }

                // Before we select a default index we have to make sure that the ComboBox is not empty
                if (rentingMovie.Items.Count > 0)
                {
                    // Here we make sure the the first index is selected
                    rentingMovie.SelectedIndex = 0;
                }
            }
        }
        //Its for return  the movie button
        private void returnMovie_Click(object sender, EventArgs e)
        {
            // Remove the rental index
            if (selectedRentalID == 0) // Checks if correct index is selected from database
            {
                MessageBox.Show("Select a rental Index!");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(HostConfigurations()))
                {
                    // Connection Established
                    conn.Open();
                    // Get the movie ID that was rented
                    SqlCommand _cmd = new SqlCommand("SELECT * FROM Movies WHERE movieID=@movID", conn);
                    _cmd.Parameters.AddWithValue("movID", selectedRentedMovieID);
                    SqlDataReader reader;
                    reader = _cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        selectedRentedMovieCount = Convert.ToInt32(reader["copies"]);
                    }
                    reader.Close();

                    // Update the count of the movie
                    SqlCommand _cmd1 = new SqlCommand("UPDATE Movies SET copies=@copies WHERE movieID=@movieID", conn);
                    _cmd1.Parameters.AddWithValue("movieID", selectedRentedMovieID);
                    _cmd1.Parameters.AddWithValue("copies", selectedRentedMovieCount + 1);
                    _cmd1.ExecuteNonQuery();
                    // Update the list of Movies
                    GetMovies();

                    // Next delete it from the list
                    SqlCommand _cmd2 = new SqlCommand("DELETE FROM RentedMovies WHERE rentalID=@rentalID", conn);
                    _cmd2.Parameters.AddWithValue("rentalID", selectedRentalID);
                    _cmd2.ExecuteNonQuery();

                    // Update Rental List
                    GetRentedMovies();
                }
            }
        }

        private void rentalsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            rentalIndex = e.RowIndex;

            if (rentalIndex < 0)
            {
                Console.WriteLine("Index not available!");
            }
            else
            {
                DataGridViewRow selectedRow = rentalsList.Rows[rentalIndex];
                if (selectedRow.Selected)
                {
                    selectedRentalID = Convert.ToInt32(selectedRow.Cells[0].Value);
                    selectedRentedMovieID = Convert.ToInt32(selectedRow.Cells[1].Value);
                }
                else
                {
                    ResetFields();
                }
            }
        }

        private void moviesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            moviesIndex = e.RowIndex;

            if (moviesIndex < 0)
            {
                Console.WriteLine("Index not available!");
            }
            else
            {

                DataGridViewRow selectedRow = moviesList.Rows[moviesIndex];
                if (selectedRow.Selected)
                {
                    selectedMovieID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                    movieRatings.Value = Convert.ToInt32(selectedRow.Cells[1].Value.ToString());
                    movieTitle.Text = selectedRow.Cells[2].Value.ToString();
                    movieYear.Text = selectedRow.Cells[3].Value.ToString();
                    movieRentingPrice.Value = Convert.ToDecimal(selectedRow.Cells[4].Value.ToString());
                    movieCopiesAvailable.Value = Convert.ToInt32(selectedRow.Cells[5].Value.ToString());
                    movieGenre.SelectedItem = selectedRow.Cells[6].Value.ToString();
                }
                else
                {
                    ResetFields();
                }
            }
        }

        private void GetRentedMovies()
        {
            // This automatically closes the connection when needed
            using (SqlConnection conn = new SqlConnection(HostConfigurations()))
            {
                // Connection Established
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM RentedMovies", conn);
                DataTable RentalsTable = new DataTable();
                sqlDa.Fill(RentalsTable);

                rentalsList.DataSource = RentalsTable;
                rentalsList.AllowUserToDeleteRows = false;
                rentalsList.AllowUserToAddRows = false;
                rentalsList.AutoGenerateColumns = false;
                rentalsList.AutoResizeColumns();
            }
        }
        //This coding for  Add new customer
        private void AddCustomer_Click(object sender, EventArgs e)
        {
            if (firstNameField.Text != "" || lastNameField.Text != "" || addressField.Text != "" || PhoneNumberField.Text != "")    // Makes sure that user doesn't try to submit with empty fields
            {
                // This automatically closes the connection when needed
                using (SqlConnection conn = new SqlConnection(HostConfigurations()))
                {
                    // Connection Established
                    conn.Open();
                    // Add Data Query
                    SqlCommand _cmd = new SqlCommand("INSERT INTO Customers (firstName, lastName, Address, phone) VALUES (@firstName, @lastName, @address, @phone)", conn);
                    _cmd.Parameters.AddWithValue("firstName", firstNameField.Text);
                    _cmd.Parameters.AddWithValue("lastName", lastNameField.Text);
                    _cmd.Parameters.AddWithValue("address", addressField.Text);
                    _cmd.Parameters.AddWithValue("phone", PhoneNumberField.Text);
                    _cmd.ExecuteNonQuery();

                    // This function is used to update the table where customers are listed
                    GetCustomersList();

                    // Here we reset all the fields to empty
                    ResetFields();

                }
            }
            else
                MessageBox.Show("One or more fields are empty!");
        }
        //  this coding for Update the customer

        private void UpdateCustomer_Click(object sender, EventArgs e)
        {

            // This automatically closes the connection when needed
            using (SqlConnection conn = new SqlConnection(HostConfigurations()))
            {
                // Connection Established
                conn.Open();
                // Update Data Query
                SqlCommand _cmd = new SqlCommand("UPDATE Customers SET firstName=@firstName, lastName=@lastName, Address=@address, phone=@phone WHERE customerID=@cID", conn);
                _cmd.Parameters.AddWithValue("firstName", firstNameField.Text);
                _cmd.Parameters.AddWithValue("lastName", lastNameField.Text);
                _cmd.Parameters.AddWithValue("address", addressField.Text);
                _cmd.Parameters.AddWithValue("phone", PhoneNumberField.Text);
                _cmd.Parameters.AddWithValue("cID", selectedCustomedID.ToString());
                _cmd.ExecuteNonQuery();

                // This function is used to update the table where customers are listed
                GetCustomersList();

                // Here we reset all the fields to empty
                ResetFields();
            }
        }
        // This coding for Issue button
        private void rentMovie_Click(object sender, EventArgs e)
        {
            if (selectedCustomedID == 0)
            {
                MessageBox.Show("Please select a customer.");
            }
            else
            {
                // To avoid crash if there is no movie in database and you press rent movie
                if (Convert.ToInt32(rentingMovie.SelectedIndex.ToString()) > -1)
                {
                    // Checks if there are movies available in stock, if they are only then proceed
                    if (selectedMovieCount > 0)
                    {
                        using (SqlConnection conn = new SqlConnection(HostConfigurations()))
                        {
                            // Connection to Host Established
                            conn.Open();
                            Console.WriteLine(selectedMovieCount);
                            // Now the first thing, we have to Update the Available copies of renting movie
                            SqlCommand _cmd = new SqlCommand("UPDATE Movies SET copies=@movieCount", conn);
                            _cmd.Parameters.AddWithValue("movieCount", selectedMovieCount - 1);
                            _cmd.ExecuteNonQuery();

                            // Update Movies table to make sure the table stays in sync with database
                            GetMovies();

                            // Final task, Add the rented movie details to rentals table
                            SqlCommand _insertCmd = new SqlCommand("INSERT INTO RentedMovies (movieID, customerID, dateRented, dateReturned) VALUES(@movieID, @customerID, @dateRented, @dateReturned)", conn);
                            // We already retrieved movieID and customerID when we selected the customer and the movie
                            _insertCmd.Parameters.AddWithValue("movieID", selectedMovieID);
                            _insertCmd.Parameters.AddWithValue("customerID", selectedCustomedID);
                            _insertCmd.Parameters.AddWithValue("dateRented", rentingDate.Value);
                            _insertCmd.Parameters.AddWithValue("dateReturned", returningDate.Value);
                            _insertCmd.ExecuteNonQuery();

                            // Update rentals table to keep it in sync with database
                            GetRentedMovies();

                            /**
                             * NOTE: This code it not necessary and can be removed if you don't need it
                             * It is only for sending the confirmation message to the user that the movie has been added to renting page successfully
                             */
                            if (customerIndex < 0)
                            {
                                Console.WriteLine("Index not available!");
                            }
                            else
                            {
                                if (moviesIndex < 0)
                                {
                                    Console.WriteLine("Invalid Movie Index");
                                }
                                else
                                {
                                    DataGridViewRow selectedRow = customersList.Rows[customerIndex];
                                    string customerName = selectedRow.Cells[2].Value.ToString();
                                    DataGridViewRow selectedMovieRow = moviesList.Rows[moviesIndex];
                                    string movieName = selectedMovieRow.Cells[2].Value.ToString();

                                    TimeSpan rentingPeriod = returningDate.Value.Subtract(rentingDate.Value);
                                    rentalPeriod = Convert.ToInt32(rentingPeriod.TotalDays);
                                    MessageBox.Show(customerName + " has rented " + movieName + " for " + rentalPeriod + " days.");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("All copies of " + rentingMovie.SelectedItem.ToString() + " are rented!");
                    }
                }
                else
                {
                    MessageBox.Show("No Movie Selected");
                }
            }
        }

        public int GetUserRentedMovies(int customerID)
        {
            List<string> movList = new List<string>();
            using (SqlConnection conn = new SqlConnection(HostConfigurations()))
            {
                // Establish Connection
                conn.Open();
                SqlCommand _cmd = new SqlCommand("Select * From RentedMovies WHERE customerID=@customerID", conn);
                _cmd.Parameters.AddWithValue("customerID", customerID);
                SqlDataReader reader;
                reader = _cmd.ExecuteReader();
                while (reader.Read())
                {
                    movList.Add(reader["rentalID"].ToString());
                }
                reader.Close();
                return movList.Count;
            }
        }

        public int GetRentedMoviesCount(int movieID)
        {
            List<string> movList = new List<string>();
            using (SqlConnection conn = new SqlConnection(HostConfigurations()))
            {
                // Establish Connection
                conn.Open();
                SqlCommand _cmd = new SqlCommand("Select * From RentedMovies WHERE movieID=@movieID", conn);
                _cmd.Parameters.AddWithValue("movieID", movieID);
                SqlDataReader reader;
                reader = _cmd.ExecuteReader();
                while (reader.Read())
                {
                    movList.Add(reader["rentalID"].ToString());
                }
                reader.Close();
                return movList.Count;
            }
        }
        // Custom Drag Panel ----- Start
        public const int WM_NCLBUTTONDOWN = 0xA1;
        // This coding  for Delete the movie
        private void DeleteMovie_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(HostConfigurations()))
            {
                // Connection Established
                conn.Open();
                if (GetRentedMoviesCount(selectedMovieID) > 0)
                {
                    MessageBox.Show("This movie cannot be deleted as it has rented copies.");
                }
                else
                {
                    // Update Data Query
                    SqlCommand _cmd = new SqlCommand("DELETE FROM Movies WHERE movieID=@cID", conn);
                    _cmd.Parameters.AddWithValue("cID", selectedMovieID.ToString());
                    _cmd.ExecuteNonQuery();
                }

                // This function is used to update the table where movies are listed
                GetMovies();

                // Here we reset all the fields to empty
                ResetFields();
            }
        }

        private void customersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            customerIndex = e.RowIndex;

            if (customerIndex < 0)  // Makes sure the selected index is not negative
            {
                Console.WriteLine("Negative Index cannot be selected!");
            }
            else
            {
                // Gets the selected row
                DataGridViewRow selectedRow = customersList.Rows[customerIndex];
                if (selectedRow.Selected)
                {
                    // Assigns value from each column of row to the text field
                    selectedCustomedID = Convert.ToInt32(selectedRow.Cells[0].Value);
                    firstNameField.Text = selectedRow.Cells[2].Value.ToString();
                    lastNameField.Text = selectedRow.Cells[3].Value.ToString();
                    addressField.Text = selectedRow.Cells[4].Value.ToString();
                    PhoneNumberField.Text = selectedRow.Cells[5].Value.ToString();
                    //availableFunds.Text = "Available Funds: $" + Convert.ToInt32(selectedRow.Cells[6].Value);
                    AddCustomer.Enabled = false;        // Disables Add New Customer, to avoid duplicate entries
                    UpdateCustomer.Enabled = true;      // Enables Update Button, since it's disabled by default
                    DeleteCustomer.Enabled = true;      // Enables Delete Button, since it's disabled by default
                }
                else
                {
                    ResetFields();
                    // availableFunds.Text = "Movie Rentals";
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        // This coding for Issue button
        private void rentingMovie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // This automatically closes the connection when needed
            selectedMovie = rentingMovie.SelectedItem.ToString();
        }

        private void returningDate_ValueChanged_1(object sender, EventArgs e)
        {
            TimeSpan rentingPeriod = returningDate.Value.Subtract(rentingDate.Value);
            int totalTime = Convert.ToInt32(rentingPeriod.TotalDays);
            if (totalTime > 1 || totalTime < 1)
            {
                rentingDays.Text = totalTime.ToString() + " Days";
            }
            else
            {
                rentingDays.Text = totalTime.ToString() + " Day";
            }
        }

        private void rentingDate_ValueChanged_1(object sender, EventArgs e)
        {
            TimeSpan rentalTime = returningDate.Value.Subtract(rentingDate.Value);
            if (Convert.ToInt32(rentalTime.TotalDays) >= 1)
            {
                // Do Nothing... Since the difference is still greater
            }
            else
            {
                // If difference between Renting and Returning period is same then increase returning day by 1
                returningDate.Value = rentingDate.Value.AddDays(1);
            }
        }

        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void WizardMover_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void UpdateTabs(bool customers, bool movies, bool rentals)
        {
            // Applying changes for customers tab
            firstNameField.Enabled = customers;
            lastNameField.Enabled = customers;
            addressField.Enabled = customers;
            PhoneNumberField.Enabled = customers;
            AddCustomer.Enabled = customers;
            UpdateCustomer.Enabled = customers;
            DeleteCustomer.Enabled = customers;

            // Applying changes for Movies tab
            movieTitle.Enabled = movies;
            movieRatings.Enabled = movies;
            movieRentingPrice.Enabled = movies;
            movieYear.Enabled = movies;
            movieCopiesAvailable.Enabled = movies;
            movieGenre.Enabled = movies;
            AddMovie.Enabled = movies;
            DeleteMovie.Enabled = movies;

            // Applying changes for Rental tab
            rentingDate.Enabled = rentals;
            returningDate.Enabled = rentals;
            rentMovie.Enabled = rentals;
            returnMovie.Enabled = rentals;
            rentingMovie.Enabled = rentals;
        }

        private void UpdateIndex()
        {
            switch (selectedTab)
            {
                case 0:
                    UpdateTabs(true, false, false);
                    break;
                case 1:
                    UpdateTabs(false, true, false);
                    break;
                case 2:
                    UpdateTabs(false, false, true);
                    break;
                default:
                    break;
            }
        }
      
       

    }
}
