namespace CarRental.View.Forms
{
    partial class CustomerForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.LeaseLabel = new System.Windows.Forms.Label();
            this.CreateNewOrderBtn = new System.Windows.Forms.Button();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.NewOrderPanel = new System.Windows.Forms.Panel();
            this.ComErrors = new System.Windows.Forms.Label();
            this.HoursInputError = new System.Windows.Forms.Label();
            this.OrdersListPanel = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.NewOrderPanel.SuspendLayout();
            this.OrdersListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 33);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(775, 245);
            this.dataGridView.TabIndex = 16;
            this.dataGridView.Validating += new System.ComponentModel.CancelEventHandler(this.dataGridView_Validating);
            // 
            // LeaseLabel
            // 
            this.LeaseLabel.AutoSize = true;
            this.LeaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaseLabel.Location = new System.Drawing.Point(70, 42);
            this.LeaseLabel.Name = "LeaseLabel";
            this.LeaseLabel.Size = new System.Drawing.Size(58, 20);
            this.LeaseLabel.TabIndex = 21;
            this.LeaseLabel.Text = "Lease";
            // 
            // CreateNewOrderBtn
            // 
            this.CreateNewOrderBtn.Location = new System.Drawing.Point(70, 3);
            this.CreateNewOrderBtn.Name = "CreateNewOrderBtn";
            this.CreateNewOrderBtn.Size = new System.Drawing.Size(294, 48);
            this.CreateNewOrderBtn.TabIndex = 15;
            this.CreateNewOrderBtn.Text = "Create new order";
            this.CreateNewOrderBtn.UseVisualStyleBackColor = true;
            this.CreateNewOrderBtn.Click += new System.EventHandler(this.CreateNewOrderBtn_Click);
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Location = new System.Drawing.Point(74, 86);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(100, 22);
            this.HoursTextBox.TabIndex = 20;
            this.HoursTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.HoursTextBox_Validating);
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(24, 89);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(44, 16);
            this.HoursLabel.TabIndex = 18;
            this.HoursLabel.Text = "Hours";
            // 
            // OrderBtn
            // 
            this.OrderBtn.Location = new System.Drawing.Point(74, 114);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(100, 34);
            this.OrderBtn.TabIndex = 22;
            this.OrderBtn.Text = "Order";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // NewOrderPanel
            // 
            this.NewOrderPanel.Controls.Add(this.ComErrors);
            this.NewOrderPanel.Controls.Add(this.HoursInputError);
            this.NewOrderPanel.Controls.Add(this.OrderBtn);
            this.NewOrderPanel.Controls.Add(this.LeaseLabel);
            this.NewOrderPanel.Controls.Add(this.HoursTextBox);
            this.NewOrderPanel.Controls.Add(this.HoursLabel);
            this.NewOrderPanel.Location = new System.Drawing.Point(12, 284);
            this.NewOrderPanel.Name = "NewOrderPanel";
            this.NewOrderPanel.Size = new System.Drawing.Size(281, 231);
            this.NewOrderPanel.TabIndex = 23;
            // 
            // ComErrors
            // 
            this.ComErrors.AutoSize = true;
            this.ComErrors.ForeColor = System.Drawing.Color.Red;
            this.ComErrors.Location = new System.Drawing.Point(71, 10);
            this.ComErrors.Name = "ComErrors";
            this.ComErrors.Size = new System.Drawing.Size(45, 16);
            this.ComErrors.TabIndex = 25;
            this.ComErrors.Text = "label1";
            this.ComErrors.Visible = false;
            // 
            // HoursInputError
            // 
            this.HoursInputError.AutoSize = true;
            this.HoursInputError.ForeColor = System.Drawing.Color.Red;
            this.HoursInputError.Location = new System.Drawing.Point(71, 67);
            this.HoursInputError.Name = "HoursInputError";
            this.HoursInputError.Size = new System.Drawing.Size(45, 16);
            this.HoursInputError.TabIndex = 24;
            this.HoursInputError.Text = "label2";
            this.HoursInputError.Visible = false;
            // 
            // OrdersListPanel
            // 
            this.OrdersListPanel.Controls.Add(this.CreateNewOrderBtn);
            this.OrdersListPanel.Location = new System.Drawing.Point(420, 282);
            this.OrdersListPanel.Name = "OrdersListPanel";
            this.OrdersListPanel.Size = new System.Drawing.Size(367, 100);
            this.OrdersListPanel.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 527);
            this.Controls.Add(this.OrdersListPanel);
            this.Controls.Add(this.NewOrderPanel);
            this.Controls.Add(this.dataGridView);
            this.Name = "CustomerForm";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.NewOrderPanel.ResumeLayout(false);
            this.NewOrderPanel.PerformLayout();
            this.OrdersListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label LeaseLabel;
        private System.Windows.Forms.Button CreateNewOrderBtn;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Panel NewOrderPanel;
        private System.Windows.Forms.Panel OrdersListPanel;
        private System.Windows.Forms.Label HoursInputError;
        private System.Windows.Forms.Label ComErrors;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

