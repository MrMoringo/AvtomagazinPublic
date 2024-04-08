namespace kyrsOvsannikov
{
    partial class Form_user
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ЗаказатьItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ПрофильItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxIDAuto = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureRefresh = new System.Windows.Forms.PictureBox();
            this.pictureSteret2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOpisanie = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSteret2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(82, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в наш автомагазин \"Покатаимся\"!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ЗаказатьItem,
            this.ПрофильItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ЗаказатьItem
            // 
            this.ЗаказатьItem.Name = "ЗаказатьItem";
            this.ЗаказатьItem.Size = new System.Drawing.Size(66, 20);
            this.ЗаказатьItem.Text = "Заказать";
            this.ЗаказатьItem.Click += new System.EventHandler(this.ЗаказатьItem_Click);
            // 
            // ПрофильItem
            // 
            this.ПрофильItem.Name = "ПрофильItem";
            this.ПрофильItem.Size = new System.Drawing.Size(71, 20);
            this.ПрофильItem.Text = "Профиль";
            this.ПрофильItem.Click += new System.EventHandler(this.ПрофильItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 487);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.textBoxIDAuto);
            this.panel4.Controls.Add(this.textBoxSearch);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.pictureRefresh);
            this.panel4.Controls.Add(this.pictureSteret2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(3, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(645, 50);
            this.panel4.TabIndex = 24;
            // 
            // textBoxIDAuto
            // 
            this.textBoxIDAuto.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxIDAuto.Location = new System.Drawing.Point(645, 9);
            this.textBoxIDAuto.Name = "textBoxIDAuto";
            this.textBoxIDAuto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIDAuto.Size = new System.Drawing.Size(69, 29);
            this.textBoxIDAuto.TabIndex = 26;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxSearch.Location = new System.Drawing.Point(428, 9);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(205, 32);
            this.textBoxSearch.TabIndex = 20;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kyrsOvsannikov.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.pictureBox1.Location = new System.Drawing.Point(377, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureRefresh
            // 
            this.pictureRefresh.Image = global::kyrsOvsannikov.Properties.Resources.refresh_page_option_icon_icons_com_73441;
            this.pictureRefresh.Location = new System.Drawing.Point(327, 5);
            this.pictureRefresh.Name = "pictureRefresh";
            this.pictureRefresh.Size = new System.Drawing.Size(40, 40);
            this.pictureRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRefresh.TabIndex = 2;
            this.pictureRefresh.TabStop = false;
            this.pictureRefresh.Click += new System.EventHandler(this.pictureRefresh_Click);
            // 
            // pictureSteret2
            // 
            this.pictureSteret2.Image = global::kyrsOvsannikov.Properties.Resources.erase_icon_160907;
            this.pictureSteret2.Location = new System.Drawing.Point(268, 0);
            this.pictureSteret2.Name = "pictureSteret2";
            this.pictureSteret2.Size = new System.Drawing.Size(50, 50);
            this.pictureSteret2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSteret2.TabIndex = 1;
            this.pictureSteret2.TabStop = false;
            this.pictureSteret2.Click += new System.EventHandler(this.pictureSteret2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(9, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Список товаров";
            // 
            // textBoxOpisanie
            // 
            this.textBoxOpisanie.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxOpisanie.Location = new System.Drawing.Point(654, 123);
            this.textBoxOpisanie.Multiline = true;
            this.textBoxOpisanie.Name = "textBoxOpisanie";
            this.textBoxOpisanie.ReadOnly = true;
            this.textBoxOpisanie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOpisanie.Size = new System.Drawing.Size(409, 314);
            this.textBoxOpisanie.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(654, 443);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 130);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // Form_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kyrsOvsannikov.Properties.Resources.rx7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1067, 612);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxOpisanie);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_user";
            this.Text = "Автомагазин";
            this.Load += new System.EventHandler(this.Form_user_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSteret2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ЗаказатьItem;
        private System.Windows.Forms.ToolStripMenuItem ПрофильItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureRefresh;
        private System.Windows.Forms.PictureBox pictureSteret2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOpisanie;
        private System.Windows.Forms.TextBox textBoxIDAuto;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}