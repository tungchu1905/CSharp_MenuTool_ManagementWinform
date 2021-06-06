
namespace System_Toolbar_Menu
{
    partial class StudentInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInfor));
            this.dgvStudentInfor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbJapan = new System.Windows.Forms.CheckBox();
            this.cbVietnam = new System.Windows.Forms.CheckBox();
            this.cbEnglish = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txttest = new System.Windows.Forms.Label();
            this.lblfather = new System.Windows.Forms.Label();
            this.lblfaAddress = new System.Windows.Forms.Label();
            this.lblcareerFa = new System.Windows.Forms.Label();
            this.lblMom = new System.Windows.Forms.Label();
            this.lblMomaddress = new System.Windows.Forms.Label();
            this.lblcareerMom = new System.Windows.Forms.Label();
            this.txtfaname = new System.Windows.Forms.TextBox();
            this.txtfaaddress = new System.Windows.Forms.TextBox();
            this.txtfacareer = new System.Windows.Forms.TextBox();
            this.txtmomname = new System.Windows.Forms.TextBox();
            this.txtmomaddress = new System.Windows.Forms.TextBox();
            this.txtmomcareer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfor)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudentInfor
            // 
            this.dgvStudentInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentInfor.Location = new System.Drawing.Point(12, 50);
            this.dgvStudentInfor.Name = "dgvStudentInfor";
            this.dgvStudentInfor.Size = new System.Drawing.Size(222, 315);
            this.dgvStudentInfor.TabIndex = 0;
            this.dgvStudentInfor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentInfor_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Student Information";
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(281, 390);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(102, 48);
            this.btnDel.TabIndex = 27;
            this.btnDel.Text = "Delete";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(59, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 48);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(167, 390);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 48);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(497, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 48);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(389, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 48);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(240, 50);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(427, 315);
            this.tabControl2.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbJapan);
            this.tabPage1.Controls.Add(this.cbVietnam);
            this.tabPage1.Controls.Add(this.cbEnglish);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.rbFemale);
            this.tabPage1.Controls.Add(this.rbMale);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtNation);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtReligion);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Controls.Add(this.dateTime);
            this.tabPage1.Controls.Add(this.txtLN);
            this.tabPage1.Controls.Add(this.txtFN);
            this.tabPage1.Controls.Add(this.txtSid);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.picbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(419, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbJapan
            // 
            this.cbJapan.AutoSize = true;
            this.cbJapan.Location = new System.Drawing.Point(335, 252);
            this.cbJapan.Name = "cbJapan";
            this.cbJapan.Size = new System.Drawing.Size(72, 17);
            this.cbJapan.TabIndex = 27;
            this.cbJapan.Text = "Japanese";
            this.cbJapan.UseVisualStyleBackColor = true;
            // 
            // cbVietnam
            // 
            this.cbVietnam.AutoSize = true;
            this.cbVietnam.Location = new System.Drawing.Point(257, 252);
            this.cbVietnam.Name = "cbVietnam";
            this.cbVietnam.Size = new System.Drawing.Size(81, 17);
            this.cbVietnam.TabIndex = 26;
            this.cbVietnam.Text = "Vietnamese";
            this.cbVietnam.UseVisualStyleBackColor = true;
            // 
            // cbEnglish
            // 
            this.cbEnglish.AutoSize = true;
            this.cbEnglish.Location = new System.Drawing.Point(195, 252);
            this.cbEnglish.Name = "cbEnglish";
            this.cbEnglish.Size = new System.Drawing.Size(60, 17);
            this.cbEnglish.TabIndex = 25;
            this.cbEnglish.Text = "English";
            this.cbEnglish.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(217, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Study Language";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(77, 252);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 23;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(16, 252);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 22;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Gender";
            // 
            // txtNation
            // 
            this.txtNation.Location = new System.Drawing.Point(257, 181);
            this.txtNation.Name = "txtNation";
            this.txtNation.Size = new System.Drawing.Size(156, 20);
            this.txtNation.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Nation";
            // 
            // txtReligion
            // 
            this.txtReligion.Location = new System.Drawing.Point(94, 182);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(117, 20);
            this.txtReligion.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Religion";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(257, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(94, 155);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(117, 20);
            this.txtPhone.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Phone";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(94, 129);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(319, 20);
            this.txtAddress.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Address";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(217, 99);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(94, 102);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(117, 20);
            this.dateTime.TabIndex = 9;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(94, 75);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(213, 20);
            this.txtLN.TabIndex = 8;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(94, 49);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(213, 20);
            this.txtFN.TabIndex = 7;
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(94, 24);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(213, 20);
            this.txtSid.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date of birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FirstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "StudentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Infor";
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(313, 24);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(100, 98);
            this.picbox.TabIndex = 0;
            this.picbox.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtmomcareer);
            this.tabPage2.Controls.Add(this.txtmomaddress);
            this.tabPage2.Controls.Add(this.txtmomname);
            this.tabPage2.Controls.Add(this.txtfacareer);
            this.tabPage2.Controls.Add(this.txtfaaddress);
            this.tabPage2.Controls.Add(this.txtfaname);
            this.tabPage2.Controls.Add(this.lblcareerMom);
            this.tabPage2.Controls.Add(this.lblMomaddress);
            this.tabPage2.Controls.Add(this.lblMom);
            this.tabPage2.Controls.Add(this.lblcareerFa);
            this.tabPage2.Controls.Add(this.lblfaAddress);
            this.tabPage2.Controls.Add(this.lblfather);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Relationship";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txttest
            // 
            this.txttest.AutoSize = true;
            this.txttest.Location = new System.Drawing.Point(25, 9);
            this.txttest.Name = "txttest";
            this.txttest.Size = new System.Drawing.Size(41, 13);
            this.txttest.TabIndex = 29;
            this.txttest.Text = "label14";
            // 
            // lblfather
            // 
            this.lblfather.AutoSize = true;
            this.lblfather.Location = new System.Drawing.Point(34, 29);
            this.lblfather.Name = "lblfather";
            this.lblfather.Size = new System.Drawing.Size(66, 13);
            this.lblfather.TabIndex = 0;
            this.lblfather.Text = "Father name";
            // 
            // lblfaAddress
            // 
            this.lblfaAddress.AutoSize = true;
            this.lblfaAddress.Location = new System.Drawing.Point(34, 62);
            this.lblfaAddress.Name = "lblfaAddress";
            this.lblfaAddress.Size = new System.Drawing.Size(77, 13);
            this.lblfaAddress.TabIndex = 1;
            this.lblfaAddress.Text = "Father address";
            // 
            // lblcareerFa
            // 
            this.lblcareerFa.AutoSize = true;
            this.lblcareerFa.Location = new System.Drawing.Point(34, 98);
            this.lblcareerFa.Name = "lblcareerFa";
            this.lblcareerFa.Size = new System.Drawing.Size(38, 13);
            this.lblcareerFa.TabIndex = 2;
            this.lblcareerFa.Text = "Career";
            // 
            // lblMom
            // 
            this.lblMom.AutoSize = true;
            this.lblMom.Location = new System.Drawing.Point(34, 139);
            this.lblMom.Name = "lblMom";
            this.lblMom.Size = new System.Drawing.Size(69, 13);
            this.lblMom.TabIndex = 3;
            this.lblMom.Text = "Mother name";
            // 
            // lblMomaddress
            // 
            this.lblMomaddress.AutoSize = true;
            this.lblMomaddress.Location = new System.Drawing.Point(34, 180);
            this.lblMomaddress.Name = "lblMomaddress";
            this.lblMomaddress.Size = new System.Drawing.Size(80, 13);
            this.lblMomaddress.TabIndex = 4;
            this.lblMomaddress.Text = "Mother address";
            // 
            // lblcareerMom
            // 
            this.lblcareerMom.AutoSize = true;
            this.lblcareerMom.Location = new System.Drawing.Point(34, 216);
            this.lblcareerMom.Name = "lblcareerMom";
            this.lblcareerMom.Size = new System.Drawing.Size(38, 13);
            this.lblcareerMom.TabIndex = 5;
            this.lblcareerMom.Text = "Career";
            // 
            // txtfaname
            // 
            this.txtfaname.Location = new System.Drawing.Point(124, 29);
            this.txtfaname.Name = "txtfaname";
            this.txtfaname.Size = new System.Drawing.Size(243, 20);
            this.txtfaname.TabIndex = 6;
            // 
            // txtfaaddress
            // 
            this.txtfaaddress.Location = new System.Drawing.Point(124, 62);
            this.txtfaaddress.Name = "txtfaaddress";
            this.txtfaaddress.Size = new System.Drawing.Size(243, 20);
            this.txtfaaddress.TabIndex = 7;
            // 
            // txtfacareer
            // 
            this.txtfacareer.Location = new System.Drawing.Point(124, 98);
            this.txtfacareer.Name = "txtfacareer";
            this.txtfacareer.Size = new System.Drawing.Size(243, 20);
            this.txtfacareer.TabIndex = 8;
            // 
            // txtmomname
            // 
            this.txtmomname.Location = new System.Drawing.Point(124, 136);
            this.txtmomname.Name = "txtmomname";
            this.txtmomname.Size = new System.Drawing.Size(243, 20);
            this.txtmomname.TabIndex = 9;
            // 
            // txtmomaddress
            // 
            this.txtmomaddress.Location = new System.Drawing.Point(124, 173);
            this.txtmomaddress.Name = "txtmomaddress";
            this.txtmomaddress.Size = new System.Drawing.Size(243, 20);
            this.txtmomaddress.TabIndex = 10;
            // 
            // txtmomcareer
            // 
            this.txtmomcareer.Location = new System.Drawing.Point(124, 209);
            this.txtmomcareer.Name = "txtmomcareer";
            this.txtmomcareer.Size = new System.Drawing.Size(243, 20);
            this.txtmomcareer.TabIndex = 11;
            // 
            // StudentInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.txttest);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudentInfor);
            this.Name = "StudentInfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentInfor";
            this.Load += new System.EventHandler(this.StudentInfor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfor)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentInfor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbJapan;
        private System.Windows.Forms.CheckBox cbVietnam;
        private System.Windows.Forms.CheckBox cbEnglish;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txttest;
        private System.Windows.Forms.TextBox txtmomcareer;
        private System.Windows.Forms.TextBox txtmomaddress;
        private System.Windows.Forms.TextBox txtmomname;
        private System.Windows.Forms.TextBox txtfacareer;
        private System.Windows.Forms.TextBox txtfaaddress;
        private System.Windows.Forms.TextBox txtfaname;
        private System.Windows.Forms.Label lblcareerMom;
        private System.Windows.Forms.Label lblMomaddress;
        private System.Windows.Forms.Label lblMom;
        private System.Windows.Forms.Label lblcareerFa;
        private System.Windows.Forms.Label lblfaAddress;
        private System.Windows.Forms.Label lblfather;
    }
}