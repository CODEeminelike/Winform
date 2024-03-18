namespace Booking.UI
{
    partial class FBatDau
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
            button1 = new Button();
            ucLayThongTin11 = new ucLayThongTin1();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(890, 22);
            button1.Name = "button1";
            button1.Size = new Size(138, 34);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // ucLayThongTin11
            // 
            ucLayThongTin11.BackColor = Color.White;
            ucLayThongTin11.Location = new Point(223, 2);
            ucLayThongTin11.Name = "ucLayThongTin11";
            ucLayThongTin11.Size = new Size(610, 945);
            ucLayThongTin11.TabIndex = 2;
            // 
            // FBatDau
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(73, 147, 158);
            ClientSize = new Size(1056, 654);
            Controls.Add(ucLayThongTin11);
            Controls.Add(button1);
            Name = "FBatDau";
            Text = "FBatDau";
            Load += FBatDau_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ucLayThongTin1 ucLayThongTin11;
    }
}