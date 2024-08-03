namespace StudentInformationManage.Presentation_Layer
{
    partial class SignupForm
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
            this.registerBTN = new System.Windows.Forms.Button();
            this.registerPasswordTBX = new System.Windows.Forms.TextBox();
            this.registerUsernameTBX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerBTN
            // 
            this.registerBTN.Location = new System.Drawing.Point(358, 262);
            this.registerBTN.Margin = new System.Windows.Forms.Padding(2);
            this.registerBTN.Name = "registerBTN";
            this.registerBTN.Size = new System.Drawing.Size(91, 25);
            this.registerBTN.TabIndex = 16;
            this.registerBTN.Text = "Sign up";
            this.registerBTN.UseVisualStyleBackColor = true;
            this.registerBTN.Click += new System.EventHandler(this.registerBTN_Click);
            // 
            // registerPasswordTBX
            // 
            this.registerPasswordTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerPasswordTBX.Location = new System.Drawing.Point(349, 212);
            this.registerPasswordTBX.Margin = new System.Windows.Forms.Padding(2);
            this.registerPasswordTBX.Name = "registerPasswordTBX";
            this.registerPasswordTBX.Size = new System.Drawing.Size(136, 20);
            this.registerPasswordTBX.TabIndex = 15;
            // 
            // registerUsernameTBX
            // 
            this.registerUsernameTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerUsernameTBX.Location = new System.Drawing.Point(349, 174);
            this.registerUsernameTBX.Margin = new System.Windows.Forms.Padding(2);
            this.registerUsernameTBX.Name = "registerUsernameTBX";
            this.registerUsernameTBX.Size = new System.Drawing.Size(136, 20);
            this.registerUsernameTBX.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Create and account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(355, 323);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "go back to login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registerBTN);
            this.Controls.Add(this.registerPasswordTBX);
            this.Controls.Add(this.registerUsernameTBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignupForm";
            this.Text = "SignupForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignupForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerBTN;
        private System.Windows.Forms.TextBox registerPasswordTBX;
        private System.Windows.Forms.TextBox registerUsernameTBX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}