namespace TrackWise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.signup_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_showpass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 450);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "ExpenSense";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.OliveDrab;
            this.signup_btn.FlatAppearance.BorderSize = 0;
            this.signup_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.signup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.Font = new System.Drawing.Font("Georgia", 10F);
            this.signup_btn.ForeColor = System.Drawing.Color.White;
            this.signup_btn.Location = new System.Drawing.Point(12, 397);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(325, 40);
            this.signup_btn.TabIndex = 8;
            this.signup_btn.Text = "SIGNUP";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(100, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "REGISTER HERE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(766, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 22);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "SIGN IN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(388, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // login_username
            // 
            this.login_username.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.Location = new System.Drawing.Point(391, 158);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(387, 34);
            this.login_username.TabIndex = 4;
            // 
            // login_password
            // 
            this.login_password.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(391, 240);
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(387, 34);
            this.login_password.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(388, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.OliveDrab;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(392, 328);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(100, 40);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            // 
            // login_showpass
            // 
            this.login_showpass.AutoSize = true;
            this.login_showpass.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showpass.Location = new System.Drawing.Point(611, 289);
            this.login_showpass.Name = "login_showpass";
            this.login_showpass.Size = new System.Drawing.Size(149, 24);
            this.login_showpass.TabIndex = 8;
            this.login_showpass.Text = "Show Password";
            this.login_showpass.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_showpass);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox login_username;

        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button login_btn;

        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.CheckBox login_showpass;
        private System.Windows.Forms.Label label2;
    }
}

