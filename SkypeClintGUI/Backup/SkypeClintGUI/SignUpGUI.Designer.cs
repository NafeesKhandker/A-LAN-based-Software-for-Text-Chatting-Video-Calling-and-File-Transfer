namespace SkypeClintGUI
{
    partial class SignUpGUI
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
            this.label_appName = new System.Windows.Forms.Label();
            this.label_SIGNUP = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_appID = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_appID = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.comboBox_birthDay = new System.Windows.Forms.ComboBox();
            this.comboBox_birthYear = new System.Windows.Forms.ComboBox();
            this.comboBox_birthMonth = new System.Windows.Forms.ComboBox();
            this.label_birthDay = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.button_signUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_appName
            // 
            this.label_appName.AutoSize = true;
            this.label_appName.Font = new System.Drawing.Font("Jokerman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_appName.ForeColor = System.Drawing.Color.Orange;
            this.label_appName.Location = new System.Drawing.Point(12, 9);
            this.label_appName.Name = "label_appName";
            this.label_appName.Size = new System.Drawing.Size(207, 93);
            this.label_appName.TabIndex = 0;
            this.label_appName.Text = "ChAt";
            this.label_appName.Click += new System.EventHandler(this.label_appName_Click);
            // 
            // label_SIGNUP
            // 
            this.label_SIGNUP.AutoSize = true;
            this.label_SIGNUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SIGNUP.ForeColor = System.Drawing.Color.White;
            this.label_SIGNUP.Location = new System.Drawing.Point(23, 96);
            this.label_SIGNUP.Name = "label_SIGNUP";
            this.label_SIGNUP.Size = new System.Drawing.Size(104, 25);
            this.label_SIGNUP.TabIndex = 1;
            this.label_SIGNUP.Text = "SIGN UP";
            this.label_SIGNUP.Click += new System.EventHandler(this.label_SIGNUP_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.DimGray;
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_name.Location = new System.Drawing.Point(95, 160);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(326, 31);
            this.textBox_name.TabIndex = 2;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_appID
            // 
            this.textBox_appID.BackColor = System.Drawing.Color.DimGray;
            this.textBox_appID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_appID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_appID.Location = new System.Drawing.Point(95, 341);
            this.textBox_appID.Name = "textBox_appID";
            this.textBox_appID.Size = new System.Drawing.Size(326, 31);
            this.textBox_appID.TabIndex = 3;
            this.textBox_appID.TextChanged += new System.EventHandler(this.textBox_appID_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.DimGray;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(95, 281);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(326, 31);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // textBox_Email
            // 
            this.textBox_Email.BackColor = System.Drawing.Color.DimGray;
            this.textBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(95, 218);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(326, 31);
            this.textBox_Email.TabIndex = 6;
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_Email_TextChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(25, 169);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(49, 16);
            this.label_name.TabIndex = 7;
            this.label_name.Text = "Name";
            this.label_name.Click += new System.EventHandler(this.label_name_Click);
            // 
            // label_appID
            // 
            this.label_appID.AutoSize = true;
            this.label_appID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_appID.ForeColor = System.Drawing.Color.White;
            this.label_appID.Location = new System.Drawing.Point(17, 348);
            this.label_appID.Name = "label_appID";
            this.label_appID.Size = new System.Drawing.Size(59, 16);
            this.label_appID.TabIndex = 8;
            this.label_appID.Text = "ChAt ID";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(17, 290);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(76, 16);
            this.label_password.TabIndex = 9;
            this.label_password.Text = "Password";
            this.label_password.Click += new System.EventHandler(this.label_password_Click);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.ForeColor = System.Drawing.Color.White;
            this.label_Email.Location = new System.Drawing.Point(25, 227);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(47, 16);
            this.label_Email.TabIndex = 10;
            this.label_Email.Text = "Email";
            // 
            // comboBox_birthDay
            // 
            this.comboBox_birthDay.AccessibleName = "";
            this.comboBox_birthDay.BackColor = System.Drawing.Color.DimGray;
            this.comboBox_birthDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_birthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_birthDay.ForeColor = System.Drawing.Color.White;
            this.comboBox_birthDay.FormattingEnabled = true;
            this.comboBox_birthDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox_birthDay.Location = new System.Drawing.Point(95, 403);
            this.comboBox_birthDay.Name = "comboBox_birthDay";
            this.comboBox_birthDay.Size = new System.Drawing.Size(73, 23);
            this.comboBox_birthDay.TabIndex = 13;
            this.comboBox_birthDay.SelectedIndexChanged += new System.EventHandler(this.comboBox_birthDay_SelectedIndexChanged);
            // 
            // comboBox_birthYear
            // 
            this.comboBox_birthYear.BackColor = System.Drawing.Color.DimGray;
            this.comboBox_birthYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_birthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_birthYear.ForeColor = System.Drawing.Color.White;
            this.comboBox_birthYear.FormattingEnabled = true;
            this.comboBox_birthYear.Items.AddRange(new object[] {
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916\t",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013"});
            this.comboBox_birthYear.Location = new System.Drawing.Point(325, 403);
            this.comboBox_birthYear.Name = "comboBox_birthYear";
            this.comboBox_birthYear.Size = new System.Drawing.Size(96, 23);
            this.comboBox_birthYear.TabIndex = 14;
            this.comboBox_birthYear.SelectedIndexChanged += new System.EventHandler(this.comboBox_birthYear_SelectedIndexChanged);
            // 
            // comboBox_birthMonth
            // 
            this.comboBox_birthMonth.BackColor = System.Drawing.Color.DimGray;
            this.comboBox_birthMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_birthMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_birthMonth.ForeColor = System.Drawing.Color.White;
            this.comboBox_birthMonth.FormattingEnabled = true;
            this.comboBox_birthMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBox_birthMonth.Location = new System.Drawing.Point(174, 403);
            this.comboBox_birthMonth.Name = "comboBox_birthMonth";
            this.comboBox_birthMonth.Size = new System.Drawing.Size(145, 23);
            this.comboBox_birthMonth.TabIndex = 15;
            this.comboBox_birthMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox_birthMonth_SelectedIndexChanged);
            // 
            // label_birthDay
            // 
            this.label_birthDay.AutoSize = true;
            this.label_birthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_birthDay.ForeColor = System.Drawing.Color.White;
            this.label_birthDay.Location = new System.Drawing.Point(17, 406);
            this.label_birthDay.Name = "label_birthDay";
            this.label_birthDay.Size = new System.Drawing.Size(65, 16);
            this.label_birthDay.TabIndex = 12;
            this.label_birthDay.Text = "Birthday";
          
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.ForeColor = System.Drawing.Color.White;
            this.label_gender.Location = new System.Drawing.Point(17, 458);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(59, 16);
            this.label_gender.TabIndex = 16;
            this.label_gender.Text = "Gender";
       
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.AccessibleName = "";
            this.comboBox_gender.BackColor = System.Drawing.Color.DimGray;
            this.comboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_gender.ForeColor = System.Drawing.Color.White;
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_gender.Location = new System.Drawing.Point(95, 454);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(108, 23);
            this.comboBox_gender.TabIndex = 17;
            this.comboBox_gender.SelectedIndexChanged += new System.EventHandler(this.comboBox_gender_SelectedIndexChanged);
            // 
            // button_signUp
            // 
            this.button_signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_signUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_signUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signUp.ForeColor = System.Drawing.Color.Orange;
            this.button_signUp.Location = new System.Drawing.Point(95, 518);
            this.button_signUp.Name = "button_signUp";
            this.button_signUp.Size = new System.Drawing.Size(276, 37);
            this.button_signUp.TabIndex = 18;
            this.button_signUp.Text = "Sign Up";
            this.button_signUp.UseVisualStyleBackColor = false;
            this.button_signUp.Click += new System.EventHandler(this.button_sighUp_Click);
            // 
            // SignUpGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(455, 602);
            this.Controls.Add(this.button_signUp);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.comboBox_birthMonth);
            this.Controls.Add(this.comboBox_birthYear);
            this.Controls.Add(this.comboBox_birthDay);
            this.Controls.Add(this.label_birthDay);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_appID);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_appID);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_SIGNUP);
            this.Controls.Add(this.label_appName);
            this.Name = "SignUpGUI";
            this.Text = "SignUpGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_appName;
        private System.Windows.Forms.Label label_SIGNUP;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_appID;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_appID;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.ComboBox comboBox_birthDay;
        private System.Windows.Forms.ComboBox comboBox_birthYear;
        private System.Windows.Forms.ComboBox comboBox_birthMonth;
        private System.Windows.Forms.Label label_birthDay;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Button button_signUp;
    }
}