namespace SQLASSI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label14 = new System.Windows.Forms.Label();
            this.rentingDays = new System.Windows.Forms.Label();
            this.rentingMovie = new System.Windows.Forms.ComboBox();
            this.address = new System.Windows.Forms.Label();
            this.addressField = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.returningDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rentingDate = new System.Windows.Forms.DateTimePicker();
            this.returnMovie = new System.Windows.Forms.Button();
            this.rentMovie = new System.Windows.Forms.Button();
            this.DeleteMovie = new System.Windows.Forms.Button();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.AddMovie = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.movieGenre = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.movieCopiesAvailable = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.movieRentingPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.movieRatings = new System.Windows.Forms.NumericUpDown();
            this.movieYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.movieTitle = new System.Windows.Forms.TextBox();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneNumberField = new System.Windows.Forms.TextBox();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.a2DataSet = new SQLASSI.A2DataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new SQLASSI.A2DataSetTableAdapters.CustomersTableAdapter();
            this.a2DataSet1 = new SQLASSI.A2DataSet1();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new SQLASSI.A2DataSet1TableAdapters.MoviesTableAdapter();
            this.a2DataSet2 = new SQLASSI.A2DataSet2();
            this.rentedmoviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentedmoviesTableAdapter = new SQLASSI.A2DataSet2TableAdapters.rentedmoviesTableAdapter();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateReturnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRentedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalsList = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersList = new System.Windows.Forms.DataGridView();
            this.moviesList = new System.Windows.Forms.DataGridView();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieCopiesAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedmoviesBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalsList)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesList)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(257, 234);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1251, 289);
            this.tabControl1.TabIndex = 110;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(651, 171);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 25);
            this.label14.TabIndex = 144;
            this.label14.Text = "Movie to Issue";
            // 
            // rentingDays
            // 
            this.rentingDays.AutoSize = true;
            this.rentingDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentingDays.ForeColor = System.Drawing.Color.White;
            this.rentingDays.Location = new System.Drawing.Point(1306, 200);
            this.rentingDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rentingDays.Name = "rentingDays";
            this.rentingDays.Size = new System.Drawing.Size(73, 25);
            this.rentingDays.TabIndex = 145;
            this.rentingDays.Text = "0 Days";
            // 
            // rentingMovie
            // 
            this.rentingMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rentingMovie.FormattingEnabled = true;
            this.rentingMovie.Location = new System.Drawing.Point(807, 171);
            this.rentingMovie.Margin = new System.Windows.Forms.Padding(4);
            this.rentingMovie.Name = "rentingMovie";
            this.rentingMovie.Size = new System.Drawing.Size(211, 24);
            this.rentingMovie.TabIndex = 143;
            this.rentingMovie.SelectedIndexChanged += new System.EventHandler(this.rentingMovie_SelectedIndexChanged_1);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.White;
            this.address.Location = new System.Drawing.Point(673, 21);
            this.address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(85, 25);
            this.address.TabIndex = 142;
            this.address.Text = "Address";
            // 
            // addressField
            // 
            this.addressField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressField.Location = new System.Drawing.Point(678, 50);
            this.addressField.Margin = new System.Windows.Forms.Padding(4);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(313, 22);
            this.addressField.TabIndex = 141;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1027, 171);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 25);
            this.label13.TabIndex = 140;
            this.label13.Text = "Renting Period";
            // 
            // returningDate
            // 
            this.returningDate.Location = new System.Drawing.Point(1038, 201);
            this.returningDate.Margin = new System.Windows.Forms.Padding(4);
            this.returningDate.Name = "returningDate";
            this.returningDate.Size = new System.Drawing.Size(259, 22);
            this.returningDate.TabIndex = 139;
            this.returningDate.Value = new System.DateTime(2019, 8, 7, 0, 0, 0, 0);
            this.returningDate.ValueChanged += new System.EventHandler(this.returningDate_ValueChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(994, 201);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 25);
            this.label11.TabIndex = 138;
            this.label11.Text = "To";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(651, 200);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 25);
            this.label10.TabIndex = 137;
            this.label10.Text = "From";
            // 
            // rentingDate
            // 
            this.rentingDate.Location = new System.Drawing.Point(721, 205);
            this.rentingDate.Margin = new System.Windows.Forms.Padding(4);
            this.rentingDate.MinDate = new System.DateTime(2019, 8, 6, 0, 0, 0, 0);
            this.rentingDate.Name = "rentingDate";
            this.rentingDate.Size = new System.Drawing.Size(265, 22);
            this.rentingDate.TabIndex = 136;
            this.rentingDate.Value = new System.DateTime(2019, 8, 6, 0, 0, 0, 0);
            this.rentingDate.ValueChanged += new System.EventHandler(this.rentingDate_ValueChanged_1);
            // 
            // returnMovie
            // 
            this.returnMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.returnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnMovie.ForeColor = System.Drawing.Color.LimeGreen;
            this.returnMovie.Location = new System.Drawing.Point(1380, 152);
            this.returnMovie.Margin = new System.Windows.Forms.Padding(4);
            this.returnMovie.Name = "returnMovie";
            this.returnMovie.Size = new System.Drawing.Size(128, 86);
            this.returnMovie.TabIndex = 135;
            this.returnMovie.Text = "Return Movie";
            this.returnMovie.UseVisualStyleBackColor = false;
            this.returnMovie.Click += new System.EventHandler(this.returnMovie_Click);
            // 
            // rentMovie
            // 
            this.rentMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rentMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentMovie.ForeColor = System.Drawing.Color.IndianRed;
            this.rentMovie.Location = new System.Drawing.Point(257, 138);
            this.rentMovie.Margin = new System.Windows.Forms.Padding(4);
            this.rentMovie.Name = "rentMovie";
            this.rentMovie.Size = new System.Drawing.Size(320, 86);
            this.rentMovie.TabIndex = 134;
            this.rentMovie.Text = "Issue Movie";
            this.rentMovie.UseVisualStyleBackColor = false;
            this.rentMovie.Click += new System.EventHandler(this.rentMovie_Click);
            // 
            // DeleteMovie
            // 
            this.DeleteMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DeleteMovie.Enabled = false;
            this.DeleteMovie.Location = new System.Drawing.Point(1305, 81);
            this.DeleteMovie.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteMovie.Name = "DeleteMovie";
            this.DeleteMovie.Size = new System.Drawing.Size(99, 53);
            this.DeleteMovie.TabIndex = 133;
            this.DeleteMovie.Text = "Delete Movie";
            this.DeleteMovie.UseVisualStyleBackColor = false;
            this.DeleteMovie.Click += new System.EventHandler(this.DeleteMovie_Click);
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DeleteCustomer.Enabled = false;
            this.DeleteCustomer.Location = new System.Drawing.Point(1412, 48);
            this.DeleteCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(96, 55);
            this.DeleteCustomer.TabIndex = 132;
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.UseVisualStyleBackColor = false;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.UpdateCustomer.Enabled = false;
            this.UpdateCustomer.Location = new System.Drawing.Point(1305, 18);
            this.UpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(99, 55);
            this.UpdateCustomer.TabIndex = 131;
            this.UpdateCustomer.Text = "Update Customer";
            this.UpdateCustomer.UseVisualStyleBackColor = false;
            this.UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // AddMovie
            // 
            this.AddMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddMovie.Location = new System.Drawing.Point(1210, 79);
            this.AddMovie.Margin = new System.Windows.Forms.Padding(4);
            this.AddMovie.Name = "AddMovie";
            this.AddMovie.Size = new System.Drawing.Size(87, 50);
            this.AddMovie.TabIndex = 130;
            this.AddMovie.Text = "Add New Movie";
            this.AddMovie.UseVisualStyleBackColor = false;
            this.AddMovie.Click += new System.EventHandler(this.AddMovie_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(999, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 129;
            this.label9.Text = "Genre";
            // 
            // movieGenre
            // 
            this.movieGenre.FormattingEnabled = true;
            this.movieGenre.Location = new System.Drawing.Point(1005, 106);
            this.movieGenre.Margin = new System.Windows.Forms.Padding(4);
            this.movieGenre.Name = "movieGenre";
            this.movieGenre.Size = new System.Drawing.Size(147, 24);
            this.movieGenre.TabIndex = 128;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(829, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 25);
            this.label8.TabIndex = 127;
            this.label8.Text = "Available Copies";
            // 
            // movieCopiesAvailable
            // 
            this.movieCopiesAvailable.Location = new System.Drawing.Point(834, 106);
            this.movieCopiesAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.movieCopiesAvailable.Name = "movieCopiesAvailable";
            this.movieCopiesAvailable.Size = new System.Drawing.Size(157, 22);
            this.movieCopiesAvailable.TabIndex = 126;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(673, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 125;
            this.label7.Text = "Rental Cost";
            // 
            // movieRentingPrice
            // 
            this.movieRentingPrice.DecimalPlaces = 2;
            this.movieRentingPrice.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.movieRentingPrice.Location = new System.Drawing.Point(678, 106);
            this.movieRentingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.movieRentingPrice.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.movieRentingPrice.Name = "movieRentingPrice";
            this.movieRentingPrice.Size = new System.Drawing.Size(148, 22);
            this.movieRentingPrice.TabIndex = 124;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(581, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 123;
            this.label6.Text = "Ratings";
            // 
            // movieRatings
            // 
            this.movieRatings.Location = new System.Drawing.Point(586, 106);
            this.movieRatings.Margin = new System.Windows.Forms.Padding(4);
            this.movieRatings.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.movieRatings.Name = "movieRatings";
            this.movieRatings.Size = new System.Drawing.Size(83, 22);
            this.movieRatings.TabIndex = 122;
            // 
            // movieYear
            // 
            this.movieYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movieYear.Location = new System.Drawing.Point(467, 106);
            this.movieYear.Margin = new System.Windows.Forms.Padding(4);
            this.movieYear.Name = "movieYear";
            this.movieYear.Size = new System.Drawing.Size(109, 22);
            this.movieYear.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(462, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 120;
            this.label5.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(259, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 119;
            this.label4.Text = "Movie Title";
            // 
            // movieTitle
            // 
            this.movieTitle.Location = new System.Drawing.Point(257, 107);
            this.movieTitle.Margin = new System.Windows.Forms.Padding(4);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(200, 22);
            this.movieTitle.TabIndex = 118;
            // 
            // AddCustomer
            // 
            this.AddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddCustomer.Location = new System.Drawing.Point(1210, 18);
            this.AddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(87, 55);
            this.AddCustomer.TabIndex = 117;
            this.AddCustomer.Text = "Add New Customer";
            this.AddCustomer.UseVisualStyleBackColor = false;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(999, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 116;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(462, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 115;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(258, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 114;
            this.label1.Text = "First Name";
            // 
            // PhoneNumberField
            // 
            this.PhoneNumberField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumberField.Location = new System.Drawing.Point(999, 50);
            this.PhoneNumberField.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumberField.MaxLength = 10;
            this.PhoneNumberField.Name = "PhoneNumberField";
            this.PhoneNumberField.Size = new System.Drawing.Size(201, 22);
            this.PhoneNumberField.TabIndex = 113;
            // 
            // lastNameField
            // 
            this.lastNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameField.Location = new System.Drawing.Point(467, 50);
            this.lastNameField.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(201, 22);
            this.lastNameField.TabIndex = 112;
            // 
            // firstNameField
            // 
            this.firstNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameField.Location = new System.Drawing.Point(258, 50);
            this.firstNameField.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(201, 22);
            this.firstNameField.TabIndex = 111;
            // 
            // a2DataSet
            // 
            this.a2DataSet.DataSetName = "A2DataSet";
            this.a2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.a2DataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // a2DataSet1
            // 
            this.a2DataSet1.DataSetName = "A2DataSet1";
            this.a2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.a2DataSet1;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // a2DataSet2
            // 
            this.a2DataSet2.DataSetName = "A2DataSet2";
            this.a2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentedmoviesBindingSource
            // 
            this.rentedmoviesBindingSource.DataMember = "rentedmovies";
            this.rentedmoviesBindingSource.DataSource = this.a2DataSet2;
            // 
            // rentedmoviesTableAdapter
            // 
            this.rentedmoviesTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.rentalsList);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1384, 260);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "rentals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateReturnedDataGridViewTextBoxColumn
            // 
            this.dateReturnedDataGridViewTextBoxColumn.DataPropertyName = "dateReturned";
            this.dateReturnedDataGridViewTextBoxColumn.HeaderText = "dateReturned";
            this.dateReturnedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateReturnedDataGridViewTextBoxColumn.Name = "dateReturnedDataGridViewTextBoxColumn";
            this.dateReturnedDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateRentedDataGridViewTextBoxColumn
            // 
            this.dateRentedDataGridViewTextBoxColumn.DataPropertyName = "dateRented";
            this.dateRentedDataGridViewTextBoxColumn.HeaderText = "dateRented";
            this.dateRentedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateRentedDataGridViewTextBoxColumn.Name = "dateRentedDataGridViewTextBoxColumn";
            this.dateRentedDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIDDataGridViewTextBoxColumn1
            // 
            this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "customerID";
            this.customerIDDataGridViewTextBoxColumn1.HeaderText = "customerID";
            this.customerIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
            this.customerIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // movieIDDataGridViewTextBoxColumn1
            // 
            this.movieIDDataGridViewTextBoxColumn1.DataPropertyName = "movieID";
            this.movieIDDataGridViewTextBoxColumn1.HeaderText = "movieID";
            this.movieIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.movieIDDataGridViewTextBoxColumn1.Name = "movieIDDataGridViewTextBoxColumn1";
            this.movieIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // rentalIDDataGridViewTextBoxColumn
            // 
            this.rentalIDDataGridViewTextBoxColumn.DataPropertyName = "rentalID";
            this.rentalIDDataGridViewTextBoxColumn.HeaderText = "rentalID";
            this.rentalIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentalIDDataGridViewTextBoxColumn.Name = "rentalIDDataGridViewTextBoxColumn";
            this.rentalIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rentalIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentalsList
            // 
            this.rentalsList.AllowUserToOrderColumns = true;
            this.rentalsList.AutoGenerateColumns = false;
            this.rentalsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentalIDDataGridViewTextBoxColumn,
            this.movieIDDataGridViewTextBoxColumn1,
            this.customerIDDataGridViewTextBoxColumn1,
            this.dateRentedDataGridViewTextBoxColumn,
            this.dateReturnedDataGridViewTextBoxColumn});
            this.rentalsList.DataSource = this.rentedmoviesBindingSource;
            this.rentalsList.Location = new System.Drawing.Point(-4, 0);
            this.rentalsList.Name = "rentalsList";
            this.rentalsList.RowHeadersWidth = 51;
            this.rentalsList.RowTemplate.Height = 24;
            this.rentalsList.Size = new System.Drawing.Size(1247, 262);
            this.rentalsList.TabIndex = 0;
            this.rentalsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentalsList_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.customersList);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1243, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "cutomers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "customerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customersList
            // 
            this.customersList.AllowUserToOrderColumns = true;
            this.customersList.AutoGenerateColumns = false;
            this.customersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.customersList.DataSource = this.customersBindingSource;
            this.customersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersList.Location = new System.Drawing.Point(3, 3);
            this.customersList.Name = "customersList";
            this.customersList.RowHeadersWidth = 51;
            this.customersList.RowTemplate.Height = 24;
            this.customersList.Size = new System.Drawing.Size(1237, 254);
            this.customersList.TabIndex = 0;
            this.customersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersList_CellContentClick);
            // 
            // moviesList
            // 
            this.moviesList.AutoGenerateColumns = false;
            this.moviesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieIDDataGridViewTextBoxColumn,
            this.ratingsDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.rentalCostDataGridViewTextBoxColumn,
            this.copiesDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn});
            this.moviesList.DataSource = this.moviesBindingSource;
            this.moviesList.Location = new System.Drawing.Point(3, 0);
            this.moviesList.Name = "moviesList";
            this.moviesList.RowHeadersWidth = 51;
            this.moviesList.RowTemplate.Height = 24;
            this.moviesList.Size = new System.Drawing.Size(1240, 259);
            this.moviesList.TabIndex = 0;
            this.moviesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moviesList_CellContentClick);
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.Width = 125;
            // 
            // copiesDataGridViewTextBoxColumn
            // 
            this.copiesDataGridViewTextBoxColumn.DataPropertyName = "copies";
            this.copiesDataGridViewTextBoxColumn.HeaderText = "copies";
            this.copiesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.copiesDataGridViewTextBoxColumn.Name = "copiesDataGridViewTextBoxColumn";
            this.copiesDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentalCostDataGridViewTextBoxColumn
            // 
            this.rentalCostDataGridViewTextBoxColumn.DataPropertyName = "rentalCost";
            this.rentalCostDataGridViewTextBoxColumn.HeaderText = "rentalCost";
            this.rentalCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentalCostDataGridViewTextBoxColumn.Name = "rentalCostDataGridViewTextBoxColumn";
            this.rentalCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // ratingsDataGridViewTextBoxColumn
            // 
            this.ratingsDataGridViewTextBoxColumn.DataPropertyName = "ratings";
            this.ratingsDataGridViewTextBoxColumn.HeaderText = "ratings";
            this.ratingsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ratingsDataGridViewTextBoxColumn.Name = "ratingsDataGridViewTextBoxColumn";
            this.ratingsDataGridViewTextBoxColumn.Width = 125;
            // 
            // movieIDDataGridViewTextBoxColumn
            // 
            this.movieIDDataGridViewTextBoxColumn.DataPropertyName = "movieID";
            this.movieIDDataGridViewTextBoxColumn.HeaderText = "movieID";
            this.movieIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.movieIDDataGridViewTextBoxColumn.Name = "movieIDDataGridViewTextBoxColumn";
            this.movieIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.movieIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.moviesList);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1384, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1765, 540);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.rentingDays);
            this.Controls.Add(this.rentingMovie);
            this.Controls.Add(this.address);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.returningDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rentingDate);
            this.Controls.Add(this.returnMovie);
            this.Controls.Add(this.rentMovie);
            this.Controls.Add(this.DeleteMovie);
            this.Controls.Add(this.DeleteCustomer);
            this.Controls.Add(this.UpdateCustomer);
            this.Controls.Add(this.AddMovie);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.movieGenre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.movieCopiesAvailable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.movieRentingPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.movieRatings);
            this.Controls.Add(this.movieYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.movieTitle);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneNumberField);
            this.Controls.Add(this.lastNameField);
            this.Controls.Add(this.firstNameField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movieCopiesAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedmoviesBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentalsList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label rentingDays;
        private System.Windows.Forms.ComboBox rentingMovie;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker returningDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker rentingDate;
        private System.Windows.Forms.Button returnMovie;
        private System.Windows.Forms.Button rentMovie;
        private System.Windows.Forms.Button DeleteMovie;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.Button AddMovie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox movieGenre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown movieCopiesAvailable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown movieRentingPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown movieRatings;
        private System.Windows.Forms.TextBox movieYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox movieTitle;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PhoneNumberField;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.TextBox firstNameField;
        private A2DataSet a2DataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private A2DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private A2DataSet1 a2DataSet1;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private A2DataSet1TableAdapters.MoviesTableAdapter moviesTableAdapter;
        private A2DataSet2 a2DataSet2;
        private System.Windows.Forms.BindingSource rentedmoviesBindingSource;
        private A2DataSet2TableAdapters.rentedmoviesTableAdapter rentedmoviesTableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView customersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView moviesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView rentalsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRentedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReturnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

