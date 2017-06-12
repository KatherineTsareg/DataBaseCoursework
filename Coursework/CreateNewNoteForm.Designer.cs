namespace Coursework
{
    partial class CreateNewNoteForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CashboxNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.buttonChooseImage = new System.Windows.Forms.Button();
            this.dateBDField = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.errorLabe = new System.Windows.Forms.Label();
            this.sellerDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashboxNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coursework.Properties.Resources.no_avatar2;
            this.pictureBox1.Location = new System.Drawing.Point(29, 115);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(462, 133);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(360, 27);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(390, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14F);
            this.label2.Location = new System.Drawing.Point(295, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата рождения";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(284, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Новый продавец";
            // 
            // CashboxNumber
            // 
            this.CashboxNumber.Font = new System.Drawing.Font("Century", 12F);
            this.CashboxNumber.Location = new System.Drawing.Point(462, 279);
            this.CashboxNumber.Margin = new System.Windows.Forms.Padding(5);
            this.CashboxNumber.Name = "CashboxNumber";
            this.CashboxNumber.Size = new System.Drawing.Size(60, 27);
            this.CashboxNumber.TabIndex = 6;
            this.CashboxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14F);
            this.label4.Location = new System.Drawing.Point(321, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер кассы";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Century", 14F);
            this.saveButton.Location = new System.Drawing.Point(608, 419);
            this.saveButton.Margin = new System.Windows.Forms.Padding(5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(218, 55);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonChooseImage
            // 
            this.buttonChooseImage.Font = new System.Drawing.Font("Century", 12F);
            this.buttonChooseImage.Location = new System.Drawing.Point(29, 349);
            this.buttonChooseImage.Margin = new System.Windows.Forms.Padding(5);
            this.buttonChooseImage.Name = "buttonChooseImage";
            this.buttonChooseImage.Size = new System.Drawing.Size(226, 38);
            this.buttonChooseImage.TabIndex = 9;
            this.buttonChooseImage.Text = "Выбрать изображение";
            this.buttonChooseImage.UseVisualStyleBackColor = true;
            this.buttonChooseImage.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateBDField
            // 
            this.dateBDField.Font = new System.Drawing.Font("Century", 12F);
            this.dateBDField.Location = new System.Drawing.Point(462, 170);
            this.dateBDField.Margin = new System.Windows.Forms.Padding(5);
            this.dateBDField.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateBDField.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateBDField.Name = "dateBDField";
            this.dateBDField.Size = new System.Drawing.Size(185, 27);
            this.dateBDField.TabIndex = 10;
            this.dateBDField.Value = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14F);
            this.label5.Location = new System.Drawing.Point(400, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пол";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // genderBox
            // 
            this.genderBox.FormattingEnabled = true;
            this.genderBox.ItemHeight = 20;
            this.genderBox.Items.AddRange(new object[] {
            "мужской",
            "женский"});
            this.genderBox.Location = new System.Drawing.Point(462, 205);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(185, 24);
            this.genderBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 14F);
            this.label6.Location = new System.Drawing.Point(285, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Номер телефона";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // PhoneField
            // 
            this.PhoneField.Location = new System.Drawing.Point(462, 241);
            this.PhoneField.Margin = new System.Windows.Forms.Padding(5);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.Size = new System.Drawing.Size(185, 27);
            this.PhoneField.TabIndex = 14;
            this.PhoneField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // errorLabe
            // 
            this.errorLabe.AutoSize = true;
            this.errorLabe.ForeColor = System.Drawing.Color.Red;
            this.errorLabe.Location = new System.Drawing.Point(355, 358);
            this.errorLabe.Name = "errorLabe";
            this.errorLabe.Size = new System.Drawing.Size(192, 20);
            this.errorLabe.TabIndex = 15;
            this.errorLabe.Text = "Заполнены не все поля!";
            this.errorLabe.Visible = false;
            // 
            // sellerDataGridView
            // 
            this.sellerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellerDataGridView.Location = new System.Drawing.Point(29, 405);
            this.sellerDataGridView.Name = "sellerDataGridView";
            this.sellerDataGridView.Size = new System.Drawing.Size(470, 220);
            this.sellerDataGridView.TabIndex = 16;
            // 
            // CreateNewNoteForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(846, 673);
            this.Controls.Add(this.sellerDataGridView);
            this.Controls.Add(this.errorLabe);
            this.Controls.Add(this.PhoneField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateBDField);
            this.Controls.Add(this.buttonChooseImage);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CashboxNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateNewNoteForm";
            this.ShowInTaskbar = false;
            this.Text = "Создание нового продавца";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateNewNoteForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateNewNoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashboxNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown CashboxNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button buttonChooseImage;
        private System.Windows.Forms.DateTimePicker dateBDField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox genderBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.Label errorLabe;
        private System.Windows.Forms.DataGridView sellerDataGridView;
    }
}