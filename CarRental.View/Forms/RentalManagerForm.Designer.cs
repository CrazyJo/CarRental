namespace CarRental.View.Forms
{
    partial class RentalManagerForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.DaysTextBox = new System.Windows.Forms.TextBox();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.LeaseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create new order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(242, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(293, 129);
            this.dataGridView1.TabIndex = 1;
            // 
            // DaysLabel
            // 
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.Location = new System.Drawing.Point(380, 241);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(40, 16);
            this.DaysLabel.TabIndex = 3;
            this.DaysLabel.Text = "Days";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(491, 241);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(44, 16);
            this.HoursLabel.TabIndex = 4;
            this.HoursLabel.Text = "Hours";
            // 
            // DaysTextBox
            // 
            this.DaysTextBox.Location = new System.Drawing.Point(320, 260);
            this.DaysTextBox.Name = "DaysTextBox";
            this.DaysTextBox.Size = new System.Drawing.Size(100, 22);
            this.DaysTextBox.TabIndex = 5;
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Location = new System.Drawing.Point(435, 260);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(100, 22);
            this.HoursTextBox.TabIndex = 6;
            // 
            // LeaseLabel
            // 
            this.LeaseLabel.AutoSize = true;
            this.LeaseLabel.Location = new System.Drawing.Point(268, 260);
            this.LeaseLabel.Name = "LeaseLabel";
            this.LeaseLabel.Size = new System.Drawing.Size(46, 16);
            this.LeaseLabel.TabIndex = 7;
            this.LeaseLabel.Text = "Lease";
            // 
            // RentalManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 452);
            this.Controls.Add(this.LeaseLabel);
            this.Controls.Add(this.HoursTextBox);
            this.Controls.Add(this.DaysTextBox);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "RentalManagerForm";
            this.Text = "RentalManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label DaysLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.TextBox DaysTextBox;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.Label LeaseLabel;
    }
}