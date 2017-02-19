namespace CarRental.View.Forms
{
    partial class ManagerForm
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.ModelTb = new System.Windows.Forms.TextBox();
            this.ColorTb = new System.Windows.Forms.TextBox();
            this.BalanceTb = new System.Windows.Forms.TextBox();
            this.TotalCarsTb = new System.Windows.Forms.TextBox();
            this.PricePerHourTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(41, 45);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(738, 187);
            this.DataGridView.TabIndex = 1;
            this.DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellEndEdit);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(650, 238);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(129, 47);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // ModelTb
            // 
            this.ModelTb.Location = new System.Drawing.Point(117, 287);
            this.ModelTb.Name = "ModelTb";
            this.ModelTb.Size = new System.Drawing.Size(100, 22);
            this.ModelTb.TabIndex = 3;
            this.ModelTb.Validating += new System.ComponentModel.CancelEventHandler(this.ModelTb_Validating);
            // 
            // ColorTb
            // 
            this.ColorTb.Location = new System.Drawing.Point(117, 315);
            this.ColorTb.Name = "ColorTb";
            this.ColorTb.Size = new System.Drawing.Size(100, 22);
            this.ColorTb.TabIndex = 4;
            this.ColorTb.Validating += new System.ComponentModel.CancelEventHandler(this.ColorTb_Validating);
            // 
            // BalanceTb
            // 
            this.BalanceTb.Location = new System.Drawing.Point(117, 343);
            this.BalanceTb.Name = "BalanceTb";
            this.BalanceTb.Size = new System.Drawing.Size(100, 22);
            this.BalanceTb.TabIndex = 5;
            this.BalanceTb.Validating += new System.ComponentModel.CancelEventHandler(this.BalanceTb_Validating);
            // 
            // TotalCarsTb
            // 
            this.TotalCarsTb.Location = new System.Drawing.Point(117, 371);
            this.TotalCarsTb.Name = "TotalCarsTb";
            this.TotalCarsTb.Size = new System.Drawing.Size(100, 22);
            this.TotalCarsTb.TabIndex = 6;
            this.TotalCarsTb.Validating += new System.ComponentModel.CancelEventHandler(this.TotalCarsTb_Validating);
            // 
            // PricePerHourTb
            // 
            this.PricePerHourTb.Location = new System.Drawing.Point(117, 399);
            this.PricePerHourTb.Name = "PricePerHourTb";
            this.PricePerHourTb.Size = new System.Drawing.Size(100, 22);
            this.PricePerHourTb.TabIndex = 7;
            this.PricePerHourTb.Validating += new System.ComponentModel.CancelEventHandler(this.PricePerHourTb_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Cars";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price Per Hour";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(69, 427);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(148, 37);
            this.AddBtn.TabIndex = 13;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 476);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PricePerHourTb);
            this.Controls.Add(this.TotalCarsTb);
            this.Controls.Add(this.BalanceTb);
            this.Controls.Add(this.ColorTb);
            this.Controls.Add(this.ModelTb);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.DataGridView);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.TextBox ModelTb;
        private System.Windows.Forms.TextBox ColorTb;
        private System.Windows.Forms.TextBox BalanceTb;
        private System.Windows.Forms.TextBox TotalCarsTb;
        private System.Windows.Forms.TextBox PricePerHourTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}