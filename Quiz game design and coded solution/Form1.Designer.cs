namespace Quiz_game_design_and_coded_solution
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlNewUser = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNewUserPanel = new System.Windows.Forms.Label();
            this.lblUserName_Register = new System.Windows.Forms.Label();
            this.Textbox_DOB = new System.Windows.Forms.TextBox();
            this.textbox_Form = new System.Windows.Forms.TextBox();
            this.textbox_Surname = new System.Windows.Forms.TextBox();
            this.textbox_Forname = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblDateOfBirth_label = new System.Windows.Forms.Label();
            this.lblform_label = new System.Windows.Forms.Label();
            this.lblSurname_label = new System.Windows.Forms.Label();
            this.lblForname_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNewUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brentwood Trivia Quiz";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 143);
            this.button1.TabIndex = 3;
            this.button1.Text = "General knowledge";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(231, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 143);
            this.button2.TabIndex = 4;
            this.button2.Text = "Entertainment";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MintCream;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(424, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 143);
            this.button3.TabIndex = 5;
            this.button3.Text = "History";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MintCream;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(610, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 143);
            this.button4.TabIndex = 6;
            this.button4.Text = "Food and Drink";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(410, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Please select a mode to play down below:";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(704, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(117, 40);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(778, 105);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 29);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(651, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username:";
            // 
            // pnlNewUser
            // 
            this.pnlNewUser.Controls.Add(this.label6);
            this.pnlNewUser.Controls.Add(this.lblNewUserPanel);
            this.pnlNewUser.Controls.Add(this.lblUserName_Register);
            this.pnlNewUser.Controls.Add(this.Textbox_DOB);
            this.pnlNewUser.Controls.Add(this.textbox_Form);
            this.pnlNewUser.Controls.Add(this.textbox_Surname);
            this.pnlNewUser.Controls.Add(this.textbox_Forname);
            this.pnlNewUser.Controls.Add(this.btnRegister);
            this.pnlNewUser.Controls.Add(this.lblDateOfBirth_label);
            this.pnlNewUser.Controls.Add(this.lblform_label);
            this.pnlNewUser.Controls.Add(this.lblSurname_label);
            this.pnlNewUser.Controls.Add(this.lblForname_label);
            this.pnlNewUser.Location = new System.Drawing.Point(953, 67);
            this.pnlNewUser.Name = "pnlNewUser";
            this.pnlNewUser.Size = new System.Drawing.Size(267, 366);
            this.pnlNewUser.TabIndex = 24;
            this.pnlNewUser.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Username:";
            // 
            // lblNewUserPanel
            // 
            this.lblNewUserPanel.AutoSize = true;
            this.lblNewUserPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUserPanel.Location = new System.Drawing.Point(30, 14);
            this.lblNewUserPanel.Name = "lblNewUserPanel";
            this.lblNewUserPanel.Size = new System.Drawing.Size(102, 24);
            this.lblNewUserPanel.TabIndex = 33;
            this.lblNewUserPanel.Text = "User Panel";
            // 
            // lblUserName_Register
            // 
            this.lblUserName_Register.AutoSize = true;
            this.lblUserName_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName_Register.Location = new System.Drawing.Point(138, 38);
            this.lblUserName_Register.Name = "lblUserName_Register";
            this.lblUserName_Register.Size = new System.Drawing.Size(79, 29);
            this.lblUserName_Register.TabIndex = 25;
            this.lblUserName_Register.Text = "label5";
            // 
            // Textbox_DOB
            // 
            this.Textbox_DOB.Location = new System.Drawing.Point(126, 191);
            this.Textbox_DOB.Multiline = true;
            this.Textbox_DOB.Name = "Textbox_DOB";
            this.Textbox_DOB.Size = new System.Drawing.Size(135, 20);
            this.Textbox_DOB.TabIndex = 32;
            // 
            // textbox_Form
            // 
            this.textbox_Form.Location = new System.Drawing.Point(126, 152);
            this.textbox_Form.Multiline = true;
            this.textbox_Form.Name = "textbox_Form";
            this.textbox_Form.Size = new System.Drawing.Size(135, 20);
            this.textbox_Form.TabIndex = 31;
            // 
            // textbox_Surname
            // 
            this.textbox_Surname.Location = new System.Drawing.Point(126, 115);
            this.textbox_Surname.Multiline = true;
            this.textbox_Surname.Name = "textbox_Surname";
            this.textbox_Surname.Size = new System.Drawing.Size(135, 20);
            this.textbox_Surname.TabIndex = 30;
            // 
            // textbox_Forname
            // 
            this.textbox_Forname.Location = new System.Drawing.Point(126, 78);
            this.textbox_Forname.Multiline = true;
            this.textbox_Forname.Name = "textbox_Forname";
            this.textbox_Forname.Size = new System.Drawing.Size(135, 20);
            this.textbox_Forname.TabIndex = 29;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(34, 284);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(209, 64);
            this.btnRegister.TabIndex = 28;
            this.btnRegister.Text = "Submit";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblDateOfBirth_label
            // 
            this.lblDateOfBirth_label.AutoSize = true;
            this.lblDateOfBirth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth_label.Location = new System.Drawing.Point(5, 191);
            this.lblDateOfBirth_label.Name = "lblDateOfBirth_label";
            this.lblDateOfBirth_label.Size = new System.Drawing.Size(121, 24);
            this.lblDateOfBirth_label.TabIndex = 27;
            this.lblDateOfBirth_label.Text = "DateOfBirth:";
            // 
            // lblform_label
            // 
            this.lblform_label.AutoSize = true;
            this.lblform_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblform_label.Location = new System.Drawing.Point(26, 148);
            this.lblform_label.Name = "lblform_label";
            this.lblform_label.Size = new System.Drawing.Size(65, 24);
            this.lblform_label.TabIndex = 26;
            this.lblform_label.Text = "Form:";
            // 
            // lblSurname_label
            // 
            this.lblSurname_label.AutoSize = true;
            this.lblSurname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname_label.Location = new System.Drawing.Point(26, 111);
            this.lblSurname_label.Name = "lblSurname_label";
            this.lblSurname_label.Size = new System.Drawing.Size(100, 24);
            this.lblSurname_label.TabIndex = 25;
            this.lblSurname_label.Text = "Surname:";
            // 
            // lblForname_label
            // 
            this.lblForname_label.AutoSize = true;
            this.lblForname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForname_label.Location = new System.Drawing.Point(26, 73);
            this.lblForname_label.Name = "lblForname_label";
            this.lblForname_label.Size = new System.Drawing.Size(100, 24);
            this.lblForname_label.TabIndex = 24;
            this.lblForname_label.Text = "Forname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(641, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Welcome to the game:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1326, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlNewUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Main Menu form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlNewUser.ResumeLayout(false);
            this.pnlNewUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlNewUser;
        private System.Windows.Forms.Label lblNewUserPanel;
        private System.Windows.Forms.TextBox Textbox_DOB;
        private System.Windows.Forms.TextBox textbox_Form;
        private System.Windows.Forms.TextBox textbox_Surname;
        private System.Windows.Forms.TextBox textbox_Forname;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblDateOfBirth_label;
        private System.Windows.Forms.Label lblform_label;
        private System.Windows.Forms.Label lblSurname_label;
        private System.Windows.Forms.Label lblForname_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUserName_Register;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

