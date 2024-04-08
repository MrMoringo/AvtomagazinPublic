namespace kyrsOvsannikov
{
    partial class singup
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_password2 = new System.Windows.Forms.TextBox();
            this.textBox_login2 = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_registracia = new System.Windows.Forms.Label();
            this.HideBox2 = new System.Windows.Forms.PictureBox();
            this.ShowBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClearBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HideBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(168, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_password2
            // 
            this.textBox_password2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox_password2.Location = new System.Drawing.Point(153, 160);
            this.textBox_password2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBox_password2.Name = "textBox_password2";
            this.textBox_password2.Size = new System.Drawing.Size(256, 35);
            this.textBox_password2.TabIndex = 15;
            // 
            // textBox_login2
            // 
            this.textBox_login2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox_login2.Location = new System.Drawing.Point(153, 114);
            this.textBox_login2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBox_login2.Name = "textBox_login2";
            this.textBox_login2.Size = new System.Drawing.Size(256, 35);
            this.textBox_login2.TabIndex = 14;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_password.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_password.Location = new System.Drawing.Point(48, 162);
            this.label_password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(95, 32);
            this.label_password.TabIndex = 13;
            this.label_password.Text = "Пароль:";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_login.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(62, 117);
            this.label_login.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(81, 32);
            this.label_login.TabIndex = 12;
            this.label_login.Text = "Логин:";
            // 
            // label_registracia
            // 
            this.label_registracia.AutoSize = true;
            this.label_registracia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_registracia.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.label_registracia.Location = new System.Drawing.Point(184, 26);
            this.label_registracia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_registracia.Name = "label_registracia";
            this.label_registracia.Size = new System.Drawing.Size(187, 42);
            this.label_registracia.TabIndex = 11;
            this.label_registracia.Text = "Регистрация";
            // 
            // HideBox2
            // 
            this.HideBox2.Image = global::kyrsOvsannikov.Properties.Resources.hide;
            this.HideBox2.Location = new System.Drawing.Point(414, 163);
            this.HideBox2.Name = "HideBox2";
            this.HideBox2.Size = new System.Drawing.Size(30, 30);
            this.HideBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HideBox2.TabIndex = 18;
            this.HideBox2.TabStop = false;
            this.HideBox2.Click += new System.EventHandler(this.HideBox2_Click);
            // 
            // ShowBox2
            // 
            this.ShowBox2.Image = global::kyrsOvsannikov.Properties.Resources.view;
            this.ShowBox2.Location = new System.Drawing.Point(414, 163);
            this.ShowBox2.Name = "ShowBox2";
            this.ShowBox2.Size = new System.Drawing.Size(30, 30);
            this.ShowBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowBox2.TabIndex = 17;
            this.ShowBox2.TabStop = false;
            this.ShowBox2.Click += new System.EventHandler(this.ShowBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::kyrsOvsannikov.Properties.Resources.password;
            this.pictureBox1.Location = new System.Drawing.Point(15, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ClearBox2
            // 
            this.ClearBox2.BackColor = System.Drawing.Color.Transparent;
            this.ClearBox2.Image = global::kyrsOvsannikov.Properties.Resources.free_icon_delete_button_3635120;
            this.ClearBox2.Location = new System.Drawing.Point(438, 16);
            this.ClearBox2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ClearBox2.Name = "ClearBox2";
            this.ClearBox2.Size = new System.Drawing.Size(50, 50);
            this.ClearBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClearBox2.TabIndex = 33;
            this.ClearBox2.TabStop = false;
            this.ClearBox2.Click += new System.EventHandler(this.ClearBox2_Click);
            // 
            // singup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kyrsOvsannikov.Properties.Resources.фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 291);
            this.Controls.Add(this.ClearBox2);
            this.Controls.Add(this.HideBox2);
            this.Controls.Add(this.ShowBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_password2);
            this.Controls.Add(this.textBox_login2);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_registracia);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "singup";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.singup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HideBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HideBox2;
        private System.Windows.Forms.PictureBox ShowBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_password2;
        private System.Windows.Forms.TextBox textBox_login2;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_registracia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ClearBox2;
    }
}