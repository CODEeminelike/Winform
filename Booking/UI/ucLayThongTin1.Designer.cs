namespace Booking.UI
{
    partial class ucLayThongTin1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(181, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(393, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 78);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 1;
            label1.Text = "Thành phố/ Tỉnh";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 147);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 4;
            label2.Text = "Quận/ Huyện";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 213);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 5;
            label3.Text = "Phường/ Xã";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 277);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 6;
            label4.Text = "Ngày đến";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 334);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 7;
            label5.Text = "Ngày đi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(181, 277);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(181, 334);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(181, 399);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 10;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(181, 458);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(180, 31);
            numericUpDown2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 460);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 12;
            label6.Text = "Số phòng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 399);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 13;
            label7.Text = "Số người";
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(181, 144);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(393, 33);
            comboBox2.TabIndex = 14;
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(181, 213);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(393, 33);
            comboBox3.TabIndex = 15;
            // 
            // ucLayThongTin1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "ucLayThongTin1";
            Size = new Size(610, 630);
            Load += ucLayThongTin1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label6;
        private Label label7;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}
