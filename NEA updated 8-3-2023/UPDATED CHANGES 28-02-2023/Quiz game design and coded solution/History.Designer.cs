namespace Quiz_game_design_and_coded_solution
{
    partial class History
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltimer = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz_game_design_and_coded_solution.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(790, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1103, 718);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(334, 115);
            this.button4.TabIndex = 10;
            this.button4.Tag = "4";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(238, 722);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(334, 112);
            this.button3.TabIndex = 9;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1103, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(334, 115);
            this.button2.TabIndex = 8;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(238, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 112);
            this.button1.TabIndex = 7;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(799, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Question";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold);
            this.exitBtn.Location = new System.Drawing.Point(1582, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(286, 98);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.label2.Location = new System.Drawing.Point(176, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "ScoreOutput";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.lbltimer.Location = new System.Drawing.Point(176, 124);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(84, 32);
            this.lbltimer.TabIndex = 15;
            this.lbltimer.Text = "label3";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.lblUserName.Location = new System.Drawing.Point(176, 30);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(68, 32);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(24, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(24, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(24, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Username:";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1880, 851);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "History";
            this.Tag = "1";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}