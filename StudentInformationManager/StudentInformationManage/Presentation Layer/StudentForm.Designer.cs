namespace StudentInformationManage.Presentation_Layer
{
    partial class StudentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.studentsDVG = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.studentSearchTBX = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.studentNumber = new System.Windows.Forms.Label();
            this.moduleLBX = new System.Windows.Forms.ListBox();
            this.femaleRBX = new System.Windows.Forms.RadioButton();
            this.maleRBX = new System.Windows.Forms.RadioButton();
            this.dobDTP = new System.Windows.Forms.DateTimePicker();
            this.surnameTBX = new System.Windows.Forms.TextBox();
            this.phoneTBX = new System.Windows.Forms.TextBox();
            this.addressTBX = new System.Windows.Forms.TextBox();
            this.nameTBX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.moduleBTN = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.exitBTN = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.loginBTN = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.updateBTN = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.readBTN = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.createBTN = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDVG)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.studentsDVG);
            this.panel4.Location = new System.Drawing.Point(297, 90);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(683, 364);
            this.panel4.TabIndex = 19;
            // 
            // studentsDVG
            // 
            this.studentsDVG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentsDVG.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.studentsDVG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.studentsDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentsDVG.DefaultCellStyle = dataGridViewCellStyle1;
            this.studentsDVG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsDVG.Location = new System.Drawing.Point(0, 0);
            this.studentsDVG.Margin = new System.Windows.Forms.Padding(2);
            this.studentsDVG.Name = "studentsDVG";
            this.studentsDVG.ReadOnly = true;
            this.studentsDVG.RowHeadersVisible = false;
            this.studentsDVG.RowHeadersWidth = 51;
            this.studentsDVG.RowTemplate.Height = 24;
            this.studentsDVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsDVG.Size = new System.Drawing.Size(683, 364);
            this.studentsDVG.TabIndex = 0;
            this.studentsDVG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDVG_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.search);
            this.panel3.Controls.Add(this.studentSearchTBX);
            this.panel3.Location = new System.Drawing.Point(0, -5);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(989, 91);
            this.panel3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Students";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(879, 38);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 19);
            this.search.TabIndex = 7;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // studentSearchTBX
            // 
            this.studentSearchTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentSearchTBX.Location = new System.Drawing.Point(762, 39);
            this.studentSearchTBX.Margin = new System.Windows.Forms.Padding(2);
            this.studentSearchTBX.Name = "studentSearchTBX";
            this.studentSearchTBX.Size = new System.Drawing.Size(113, 20);
            this.studentSearchTBX.TabIndex = 2;
            this.studentSearchTBX.TextChanged += new System.EventHandler(this.studentSearchTBX_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.studentNumber);
            this.panel2.Controls.Add(this.moduleLBX);
            this.panel2.Controls.Add(this.femaleRBX);
            this.panel2.Controls.Add(this.maleRBX);
            this.panel2.Controls.Add(this.dobDTP);
            this.panel2.Controls.Add(this.surnameTBX);
            this.panel2.Controls.Add(this.phoneTBX);
            this.panel2.Controls.Add(this.addressTBX);
            this.panel2.Controls.Add(this.nameTBX);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 364);
            this.panel2.TabIndex = 18;
            // 
            // studentNumber
            // 
            this.studentNumber.AutoSize = true;
            this.studentNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.studentNumber.Location = new System.Drawing.Point(106, 14);
            this.studentNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.Size = new System.Drawing.Size(41, 13);
            this.studentNumber.TabIndex = 25;
            this.studentNumber.Text = "label10";
            // 
            // moduleLBX
            // 
            this.moduleLBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moduleLBX.FormattingEnabled = true;
            this.moduleLBX.Items.AddRange(new object[] {
            "LPR281",
            "PRG281",
            "PRG282",
            "MAT281"});
            this.moduleLBX.Location = new System.Drawing.Point(93, 242);
            this.moduleLBX.Margin = new System.Windows.Forms.Padding(2);
            this.moduleLBX.Name = "moduleLBX";
            this.moduleLBX.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.moduleLBX.Size = new System.Drawing.Size(66, 15);
            this.moduleLBX.TabIndex = 22;
            // 
            // femaleRBX
            // 
            this.femaleRBX.AutoSize = true;
            this.femaleRBX.Location = new System.Drawing.Point(145, 193);
            this.femaleRBX.Margin = new System.Windows.Forms.Padding(2);
            this.femaleRBX.Name = "femaleRBX";
            this.femaleRBX.Size = new System.Drawing.Size(59, 17);
            this.femaleRBX.TabIndex = 20;
            this.femaleRBX.TabStop = true;
            this.femaleRBX.Text = "Female";
            this.femaleRBX.UseVisualStyleBackColor = true;
            // 
            // maleRBX
            // 
            this.maleRBX.AutoSize = true;
            this.maleRBX.Location = new System.Drawing.Point(93, 193);
            this.maleRBX.Margin = new System.Windows.Forms.Padding(2);
            this.maleRBX.Name = "maleRBX";
            this.maleRBX.Size = new System.Drawing.Size(48, 17);
            this.maleRBX.TabIndex = 19;
            this.maleRBX.TabStop = true;
            this.maleRBX.Text = "Male";
            this.maleRBX.UseVisualStyleBackColor = true;
            // 
            // dobDTP
            // 
            this.dobDTP.Checked = false;
            this.dobDTP.Location = new System.Drawing.Point(86, 288);
            this.dobDTP.Margin = new System.Windows.Forms.Padding(2);
            this.dobDTP.Name = "dobDTP";
            this.dobDTP.Size = new System.Drawing.Size(182, 20);
            this.dobDTP.TabIndex = 17;
            // 
            // surnameTBX
            // 
            this.surnameTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameTBX.Location = new System.Drawing.Point(93, 79);
            this.surnameTBX.Margin = new System.Windows.Forms.Padding(2);
            this.surnameTBX.Name = "surnameTBX";
            this.surnameTBX.Size = new System.Drawing.Size(115, 20);
            this.surnameTBX.TabIndex = 16;
            // 
            // phoneTBX
            // 
            this.phoneTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTBX.Location = new System.Drawing.Point(93, 119);
            this.phoneTBX.Margin = new System.Windows.Forms.Padding(2);
            this.phoneTBX.Name = "phoneTBX";
            this.phoneTBX.Size = new System.Drawing.Size(116, 20);
            this.phoneTBX.TabIndex = 15;
            // 
            // addressTBX
            // 
            this.addressTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTBX.Location = new System.Drawing.Point(93, 157);
            this.addressTBX.Margin = new System.Windows.Forms.Padding(2);
            this.addressTBX.Multiline = true;
            this.addressTBX.Name = "addressTBX";
            this.addressTBX.Size = new System.Drawing.Size(115, 22);
            this.addressTBX.TabIndex = 14;
            // 
            // nameTBX
            // 
            this.nameTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTBX.Location = new System.Drawing.Point(93, 41);
            this.nameTBX.Margin = new System.Windows.Forms.Padding(2);
            this.nameTBX.Name = "nameTBX";
            this.nameTBX.Size = new System.Drawing.Size(115, 20);
            this.nameTBX.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Surname:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 295);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Date of Birth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Module Codes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 453);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 101);
            this.panel1.TabIndex = 16;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(762, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(225, 105);
            this.panel10.TabIndex = 4;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.moduleBTN);
            this.panel12.Location = new System.Drawing.Point(0, 30);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(235, 41);
            this.panel12.TabIndex = 7;
            // 
            // moduleBTN
            // 
            this.moduleBTN.Location = new System.Drawing.Point(-12, -6);
            this.moduleBTN.Margin = new System.Windows.Forms.Padding(2);
            this.moduleBTN.Name = "moduleBTN";
            this.moduleBTN.Size = new System.Drawing.Size(247, 50);
            this.moduleBTN.TabIndex = 8;
            this.moduleBTN.Text = "Module";
            this.moduleBTN.UseVisualStyleBackColor = true;
            this.moduleBTN.Click += new System.EventHandler(this.moduleBTN_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.exitBTN);
            this.panel13.Location = new System.Drawing.Point(0, 69);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(232, 33);
            this.panel13.TabIndex = 8;
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(-4, -7);
            this.exitBTN.Margin = new System.Windows.Forms.Padding(2);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(235, 46);
            this.exitBTN.TabIndex = 6;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.loginBTN);
            this.panel11.Location = new System.Drawing.Point(0, -5);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(235, 37);
            this.panel11.TabIndex = 5;
            // 
            // loginBTN
            // 
            this.loginBTN.Location = new System.Drawing.Point(-12, 0);
            this.loginBTN.Margin = new System.Windows.Forms.Padding(2);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(247, 37);
            this.loginBTN.TabIndex = 6;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel15);
            this.panel9.Controls.Add(this.deleteBTN);
            this.panel9.Location = new System.Drawing.Point(585, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(182, 101);
            this.panel9.TabIndex = 3;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.button4);
            this.panel15.Location = new System.Drawing.Point(177, 37);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(223, 24);
            this.panel15.TabIndex = 8;
            // 
            // panel16
            // 
            this.panel16.Location = new System.Drawing.Point(0, 22);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(225, 28);
            this.panel16.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, -7);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "Log in";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // deleteBTN
            // 
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBTN.Location = new System.Drawing.Point(-22, -5);
            this.deleteBTN.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(218, 110);
            this.deleteBTN.TabIndex = 4;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.updateBTN);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(406, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(188, 101);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(178, -2);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(172, 103);
            this.panel8.TabIndex = 3;
            // 
            // updateBTN
            // 
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBTN.Location = new System.Drawing.Point(-42, -15);
            this.updateBTN.Margin = new System.Windows.Forms.Padding(2);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(251, 131);
            this.updateBTN.TabIndex = 5;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.readBTN);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(200, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(206, 101);
            this.panel6.TabIndex = 1;
            // 
            // readBTN
            // 
            this.readBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.readBTN.Location = new System.Drawing.Point(-27, -15);
            this.readBTN.Margin = new System.Windows.Forms.Padding(2);
            this.readBTN.Name = "readBTN";
            this.readBTN.Size = new System.Drawing.Size(251, 130);
            this.readBTN.TabIndex = 6;
            this.readBTN.Text = "Read";
            this.readBTN.UseVisualStyleBackColor = true;
            this.readBTN.Click += new System.EventHandler(this.readBTN_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.createBTN);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 101);
            this.panel5.TabIndex = 0;
            // 
            // createBTN
            // 
            this.createBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createBTN.Location = new System.Drawing.Point(-4, -12);
            this.createBTN.Margin = new System.Windows.Forms.Padding(2);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(236, 128);
            this.createBTN.TabIndex = 3;
            this.createBTN.Text = "Create";
            this.createBTN.UseVisualStyleBackColor = true;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 554);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDVG)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView studentsDVG;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox studentSearchTBX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label studentNumber;
        private System.Windows.Forms.ListBox moduleLBX;
        private System.Windows.Forms.RadioButton femaleRBX;
        private System.Windows.Forms.RadioButton maleRBX;
        private System.Windows.Forms.DateTimePicker dobDTP;
        private System.Windows.Forms.TextBox surnameTBX;
        private System.Windows.Forms.TextBox phoneTBX;
        private System.Windows.Forms.TextBox addressTBX;
        private System.Windows.Forms.TextBox nameTBX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button moduleBTN;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button readBTN;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button createBTN;
        private System.Windows.Forms.Label label1;
    }
}