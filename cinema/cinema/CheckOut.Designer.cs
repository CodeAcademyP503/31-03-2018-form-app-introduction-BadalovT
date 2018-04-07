namespace cinema
{
    partial class CheckOut
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.SelectedSeats = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Netice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(83, 59);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(83, 106);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameBox.TabIndex = 3;
            // 
            // SelectedSeats
            // 
            this.SelectedSeats.AutoSize = true;
            this.SelectedSeats.Location = new System.Drawing.Point(13, 13);
            this.SelectedSeats.Name = "SelectedSeats";
            this.SelectedSeats.Size = new System.Drawing.Size(0, 13);
            this.SelectedSeats.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Netice
            // 
            this.Netice.AutoSize = true;
            this.Netice.Location = new System.Drawing.Point(13, 192);
            this.Netice.Name = "Netice";
            this.Netice.Size = new System.Drawing.Size(0, 13);
            this.Netice.TabIndex = 6;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Netice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SelectedSeats);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label SelectedSeats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Netice;
    }
}