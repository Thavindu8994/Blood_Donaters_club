namespace Blood_Donaters_club
{
    partial class FormDonorData
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
            this.pnlDrag = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDonorData = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblLastDonate = new System.Windows.Forms.Label();
            this.dtpLastDonation = new System.Windows.Forms.DateTimePicker();
            this.lblIDCardNo = new System.Windows.Forms.Label();
            this.txtIdCardNo = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHight = new System.Windows.Forms.TextBox();
            this.lblHight = new System.Windows.Forms.Label();
            this.dtpFirstDonation = new System.Windows.Forms.DateTimePicker();
            this.lblFirstDonation = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExistingDonor = new System.Windows.Forms.Button();
            this.btnChangeUser = new System.Windows.Forms.Button();
            this.pnlDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrag
            // 
            this.pnlDrag.Controls.Add(this.btnChangeUser);
            this.pnlDrag.Controls.Add(this.btnClose);
            this.pnlDrag.Location = new System.Drawing.Point(0, 0);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Size = new System.Drawing.Size(779, 35);
            this.pnlDrag.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Blood_Donaters_club.Properties.Resources.btnclose;
            this.btnClose.Location = new System.Drawing.Point(747, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 29);
            this.btnClose.TabIndex = 14;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.pnlDrag;
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(96, 41);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(674, 23);
            this.txtFullName.TabIndex = 16;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFullName.Location = new System.Drawing.Point(11, 44);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(76, 19);
            this.lblFullName.TabIndex = 17;
            this.lblFullName.Text = "Full Name";
            // 
            // lblDonorData
            // 
            this.lblDonorData.AutoSize = true;
            this.lblDonorData.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDonorData.Location = new System.Drawing.Point(329, 6);
            this.lblDonorData.Name = "lblDonorData";
            this.lblDonorData.Size = new System.Drawing.Size(120, 26);
            this.lblDonorData.TabIndex = 18;
            this.lblDonorData.Text = "Donor Data";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAddress.Location = new System.Drawing.Point(11, 82);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 19);
            this.lblAddress.TabIndex = 20;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(96, 79);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(674, 23);
            this.txtAddress.TabIndex = 19;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblPhoneNo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPhoneNo.Location = new System.Drawing.Point(11, 121);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(77, 19);
            this.lblPhoneNo.TabIndex = 22;
            this.lblPhoneNo.Text = "Phone No.";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(96, 117);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(239, 23);
            this.txtPhoneNo.TabIndex = 21;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmail.Location = new System.Drawing.Point(354, 121);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 19);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(413, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(356, 23);
            this.txtEmail.TabIndex = 25;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDOB.Location = new System.Drawing.Point(11, 159);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(46, 19);
            this.lblDOB.TabIndex = 26;
            this.lblDOB.Text = "D.O.B";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDOB.Location = new System.Drawing.Point(97, 159);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(238, 20);
            this.dtpDOB.TabIndex = 27;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGender.Location = new System.Drawing.Point(587, 159);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(32, 19);
            this.lblGender.TabIndex = 28;
            this.lblGender.Text = "Sex";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnMale.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnMale.Location = new System.Drawing.Point(640, 159);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(55, 20);
            this.rbtnMale.TabIndex = 29;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnFemale.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnFemale.Location = new System.Drawing.Point(701, 159);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(67, 20);
            this.rbtnFemale.TabIndex = 30;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // lblLastDonate
            // 
            this.lblLastDonate.AutoSize = true;
            this.lblLastDonate.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblLastDonate.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastDonate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLastDonate.Location = new System.Drawing.Point(400, 272);
            this.lblLastDonate.Name = "lblLastDonate";
            this.lblLastDonate.Size = new System.Drawing.Size(101, 19);
            this.lblLastDonate.TabIndex = 33;
            this.lblLastDonate.Text = "Last Donation";
            // 
            // dtpLastDonation
            // 
            this.dtpLastDonation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpLastDonation.Location = new System.Drawing.Point(516, 270);
            this.dtpLastDonation.Name = "dtpLastDonation";
            this.dtpLastDonation.Size = new System.Drawing.Size(254, 20);
            this.dtpLastDonation.TabIndex = 34;
            // 
            // lblIDCardNo
            // 
            this.lblIDCardNo.AutoSize = true;
            this.lblIDCardNo.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblIDCardNo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCardNo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIDCardNo.Location = new System.Drawing.Point(11, 198);
            this.lblIDCardNo.Name = "lblIDCardNo";
            this.lblIDCardNo.Size = new System.Drawing.Size(86, 19);
            this.lblIDCardNo.TabIndex = 31;
            this.lblIDCardNo.Text = "ID Card No.";
            // 
            // txtIdCardNo
            // 
            this.txtIdCardNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCardNo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCardNo.Location = new System.Drawing.Point(97, 194);
            this.txtIdCardNo.Name = "txtIdCardNo";
            this.txtIdCardNo.Size = new System.Drawing.Size(311, 23);
            this.txtIdCardNo.TabIndex = 32;
            // 
            // txtWeight
            // 
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(97, 233);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(285, 23);
            this.txtWeight.TabIndex = 36;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWeight.Location = new System.Drawing.Point(11, 237);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(89, 19);
            this.lblWeight.TabIndex = 35;
            this.lblWeight.Text = "Weight (Kg)";
            // 
            // txtHight
            // 
            this.txtHight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHight.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHight.Location = new System.Drawing.Point(484, 233);
            this.txtHight.Name = "txtHight";
            this.txtHight.Size = new System.Drawing.Size(285, 23);
            this.txtHight.TabIndex = 38;
            // 
            // lblHight
            // 
            this.lblHight.AutoSize = true;
            this.lblHight.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblHight.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHight.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHight.Location = new System.Drawing.Point(400, 237);
            this.lblHight.Name = "lblHight";
            this.lblHight.Size = new System.Drawing.Size(73, 19);
            this.lblHight.TabIndex = 37;
            this.lblHight.Text = "Hight (M)";
            // 
            // dtpFirstDonation
            // 
            this.dtpFirstDonation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFirstDonation.Location = new System.Drawing.Point(127, 270);
            this.dtpFirstDonation.Name = "dtpFirstDonation";
            this.dtpFirstDonation.Size = new System.Drawing.Size(255, 20);
            this.dtpFirstDonation.TabIndex = 40;
            // 
            // lblFirstDonation
            // 
            this.lblFirstDonation.AutoSize = true;
            this.lblFirstDonation.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblFirstDonation.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstDonation.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFirstDonation.Location = new System.Drawing.Point(11, 272);
            this.lblFirstDonation.Name = "lblFirstDonation";
            this.lblFirstDonation.Size = new System.Drawing.Size(102, 19);
            this.lblFirstDonation.TabIndex = 39;
            this.lblFirstDonation.Text = "First Donation";
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblBloodGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroup.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBloodGroup.Location = new System.Drawing.Point(428, 198);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(94, 19);
            this.lblBloodGroup.TabIndex = 41;
            this.lblBloodGroup.Text = "Blood Group";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A+",
            "AB+",
            "A-",
            "AB-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.comboBox1.Location = new System.Drawing.Point(529, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 24);
            this.comboBox1.TabIndex = 42;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(86)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(86)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(17, 307);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(753, 30);
            this.btnSubmit.TabIndex = 43;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAge.Location = new System.Drawing.Point(354, 159);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 19);
            this.lblAge.TabIndex = 44;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(396, 155);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(169, 23);
            this.txtAge.TabIndex = 45;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(16, 351);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(753, 30);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnExistingDonor
            // 
            this.btnExistingDonor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExistingDonor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExistingDonor.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExistingDonor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExistingDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistingDonor.Location = new System.Drawing.Point(16, 395);
            this.btnExistingDonor.Name = "btnExistingDonor";
            this.btnExistingDonor.Size = new System.Drawing.Size(753, 30);
            this.btnExistingDonor.TabIndex = 47;
            this.btnExistingDonor.Text = "Existing Donor";
            this.btnExistingDonor.UseVisualStyleBackColor = false;
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnChangeUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnChangeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUser.Location = new System.Drawing.Point(3, 3);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(100, 30);
            this.btnChangeUser.TabIndex = 48;
            this.btnChangeUser.Text = "Change User";
            this.btnChangeUser.UseVisualStyleBackColor = false;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // FormDonorData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(780, 444);
            this.Controls.Add(this.btnExistingDonor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.dtpFirstDonation);
            this.Controls.Add(this.lblFirstDonation);
            this.Controls.Add(this.txtHight);
            this.Controls.Add(this.lblHight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.dtpLastDonation);
            this.Controls.Add(this.lblLastDonate);
            this.Controls.Add(this.txtIdCardNo);
            this.Controls.Add(this.lblIDCardNo);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblDonorData);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.pnlDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDonorData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donor Data";
            this.Load += new System.EventHandler(this.formDonatorData_Load);
            this.pnlDrag.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlDrag;
        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblDonorData;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.DateTimePicker dtpLastDonation;
        private System.Windows.Forms.Label lblLastDonate;
        private System.Windows.Forms.TextBox txtIdCardNo;
        private System.Windows.Forms.Label lblIDCardNo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.DateTimePicker dtpFirstDonation;
        private System.Windows.Forms.Label lblFirstDonation;
        private System.Windows.Forms.TextBox txtHight;
        private System.Windows.Forms.Label lblHight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExistingDonor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnChangeUser;
    }
}