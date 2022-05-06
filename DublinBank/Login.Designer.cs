namespace DublinBank
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LklSignup = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.LklForgotPasswod = new System.Windows.Forms.LinkLabel();
            this.BtnLogin = new DublinBank.DBButton();
            this.TxtPassowrd = new DublinBank.DBTextBox();
            this.TxtUserName = new DublinBank.DBTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(176, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "or";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label2.Location = new System.Drawing.Point(132, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Don\'t have an account? ";
            // 
            // LklSignup
            // 
            this.LklSignup.ActiveLinkColor = System.Drawing.Color.MediumSlateBlue;
            this.LklSignup.AutoSize = true;
            this.LklSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LklSignup.ForeColor = System.Drawing.Color.DarkSalmon;
            this.LklSignup.LinkColor = System.Drawing.Color.DarkSalmon;
            this.LklSignup.Location = new System.Drawing.Point(350, 296);
            this.LklSignup.Name = "LklSignup";
            this.LklSignup.Size = new System.Drawing.Size(63, 20);
            this.LklSignup.TabIndex = 7;
            this.LklSignup.TabStop = true;
            this.LklSignup.Text = "Sign up";
            this.LklSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LklSignup_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label3.Location = new System.Drawing.Point(42, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Log in to your Dublin Bank account";
            // 
            // LklForgotPasswod
            // 
            this.LklForgotPasswod.ActiveLinkColor = System.Drawing.Color.MediumSlateBlue;
            this.LklForgotPasswod.AutoSize = true;
            this.LklForgotPasswod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LklForgotPasswod.ForeColor = System.Drawing.Color.DarkSalmon;
            this.LklForgotPasswod.LinkColor = System.Drawing.Color.DarkSalmon;
            this.LklForgotPasswod.Location = new System.Drawing.Point(210, 262);
            this.LklForgotPasswod.Name = "LklForgotPasswod";
            this.LklForgotPasswod.Size = new System.Drawing.Size(128, 20);
            this.LklForgotPasswod.TabIndex = 5;
            this.LklForgotPasswod.TabStop = true;
            this.LklForgotPasswod.Text = "Forgot password";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.DarkSalmon;
            this.BtnLogin.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.BtnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnLogin.BorderRadius = 20;
            this.BtnLogin.BorderSize = 0;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.BtnLogin.Location = new System.Drawing.Point(134, 202);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(239, 33);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Log in";
            this.BtnLogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.dbButton1_Click);
            this.BtnLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dbButton1_KeyPress);
            // 
            // TxtPassowrd
            // 
            this.TxtPassowrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.TxtPassowrd.BorderColor = System.Drawing.Color.DarkSalmon;
            this.TxtPassowrd.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.TxtPassowrd.BorderRadius = 10;
            this.TxtPassowrd.BorderSize = 1;
            this.TxtPassowrd.ForeColor = System.Drawing.Color.Silver;
            this.TxtPassowrd.Location = new System.Drawing.Point(134, 147);
            this.TxtPassowrd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPassowrd.Multiline = false;
            this.TxtPassowrd.Name = "TxtPassowrd";
            this.TxtPassowrd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtPassowrd.PasswordChar = true;
            this.TxtPassowrd.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.TxtPassowrd.PlaceHolderText = "Password";
            this.TxtPassowrd.Size = new System.Drawing.Size(250, 33);
            this.TxtPassowrd.TabIndex = 2;
            this.TxtPassowrd.Texts = "";
            this.TxtPassowrd.UnderlinedStyle = false;
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.TxtUserName.BorderColor = System.Drawing.Color.DarkSalmon;
            this.TxtUserName.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.TxtUserName.BorderRadius = 10;
            this.TxtUserName.BorderSize = 1;
            this.TxtUserName.ForeColor = System.Drawing.Color.Silver;
            this.TxtUserName.Location = new System.Drawing.Point(134, 92);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUserName.Multiline = false;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtUserName.PasswordChar = false;
            this.TxtUserName.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.TxtUserName.PlaceHolderText = "Username";
            this.TxtUserName.Size = new System.Drawing.Size(372, 33);
            this.TxtUserName.TabIndex = 1;
            this.TxtUserName.Texts = "";
            this.TxtUserName.UnderlinedStyle = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassowrd);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LklForgotPasswod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LklSignup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Dublin Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LklSignup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LklForgotPasswod;
        private DBTextBox TxtUserName;
        private DBTextBox TxtPassowrd;
        private DBButton BtnLogin;
    }
}

