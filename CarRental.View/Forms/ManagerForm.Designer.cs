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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OrdersPage = new System.Windows.Forms.TabPage();
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.CarsPage = new System.Windows.Forms.TabPage();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PricePerHourTb = new System.Windows.Forms.TextBox();
            this.TotalCarsTb = new System.Windows.Forms.TextBox();
            this.BalanceTb = new System.Windows.Forms.TextBox();
            this.ColorTb = new System.Windows.Forms.TextBox();
            this.ModelTb = new System.Windows.Forms.TextBox();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.UsersPage = new System.Windows.Forms.TabPage();
            this.UsersGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.OrdersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            this.CarsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.UsersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.OrdersPage);
            this.tabControl1.Controls.Add(this.CarsPage);
            this.tabControl1.Controls.Add(this.UsersPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 560);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // OrdersPage
            // 
            this.OrdersPage.Controls.Add(this.OrdersGrid);
            this.OrdersPage.Location = new System.Drawing.Point(4, 25);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersPage.Size = new System.Drawing.Size(928, 531);
            this.OrdersPage.TabIndex = 0;
            this.OrdersPage.Text = "Orders";
            this.OrdersPage.UseVisualStyleBackColor = true;
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.AllowUserToAddRows = false;
            this.OrdersGrid.AllowUserToDeleteRows = false;
            this.OrdersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Location = new System.Drawing.Point(8, 6);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.ReadOnly = true;
            this.OrdersGrid.RowTemplate.Height = 24;
            this.OrdersGrid.Size = new System.Drawing.Size(914, 341);
            this.OrdersGrid.TabIndex = 0;
            // 
            // CarsPage
            // 
            this.CarsPage.Controls.Add(this.label6);
            this.CarsPage.Controls.Add(this.SearchBtn);
            this.CarsPage.Controls.Add(this.SearchTb);
            this.CarsPage.Controls.Add(this.AddBtn);
            this.CarsPage.Controls.Add(this.label5);
            this.CarsPage.Controls.Add(this.label4);
            this.CarsPage.Controls.Add(this.label3);
            this.CarsPage.Controls.Add(this.label2);
            this.CarsPage.Controls.Add(this.label1);
            this.CarsPage.Controls.Add(this.PricePerHourTb);
            this.CarsPage.Controls.Add(this.TotalCarsTb);
            this.CarsPage.Controls.Add(this.BalanceTb);
            this.CarsPage.Controls.Add(this.ColorTb);
            this.CarsPage.Controls.Add(this.ModelTb);
            this.CarsPage.Controls.Add(this.RemoveBtn);
            this.CarsPage.Controls.Add(this.DataGridView);
            this.CarsPage.Location = new System.Drawing.Point(4, 25);
            this.CarsPage.Name = "CarsPage";
            this.CarsPage.Padding = new System.Windows.Forms.Padding(3);
            this.CarsPage.Size = new System.Drawing.Size(959, 531);
            this.CarsPage.TabIndex = 1;
            this.CarsPage.Text = "Cars";
            this.CarsPage.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(867, 40);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 24);
            this.SearchBtn.TabIndex = 45;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(769, 40);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(92, 22);
            this.SearchTb.TabIndex = 44;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(129, 473);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(148, 37);
            this.AddBtn.TabIndex = 43;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Price Per Hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Total Cars";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Model";
            // 
            // PricePerHourTb
            // 
            this.PricePerHourTb.Location = new System.Drawing.Point(177, 445);
            this.PricePerHourTb.Name = "PricePerHourTb";
            this.PricePerHourTb.Size = new System.Drawing.Size(100, 22);
            this.PricePerHourTb.TabIndex = 37;
            this.PricePerHourTb.Validating += new System.ComponentModel.CancelEventHandler(this.PricePerHourTb_Validating);
            // 
            // TotalCarsTb
            // 
            this.TotalCarsTb.Location = new System.Drawing.Point(177, 417);
            this.TotalCarsTb.Name = "TotalCarsTb";
            this.TotalCarsTb.Size = new System.Drawing.Size(100, 22);
            this.TotalCarsTb.TabIndex = 36;
            this.TotalCarsTb.Validating += new System.ComponentModel.CancelEventHandler(this.TotalCarsTb_Validating);
            // 
            // BalanceTb
            // 
            this.BalanceTb.Location = new System.Drawing.Point(177, 389);
            this.BalanceTb.Name = "BalanceTb";
            this.BalanceTb.Size = new System.Drawing.Size(100, 22);
            this.BalanceTb.TabIndex = 35;
            this.BalanceTb.Validating += new System.ComponentModel.CancelEventHandler(this.BalanceTb_Validating);
            // 
            // ColorTb
            // 
            this.ColorTb.Location = new System.Drawing.Point(177, 361);
            this.ColorTb.Name = "ColorTb";
            this.ColorTb.Size = new System.Drawing.Size(100, 22);
            this.ColorTb.TabIndex = 34;
            this.ColorTb.Validating += new System.ComponentModel.CancelEventHandler(this.ColorTb_Validating);
            // 
            // ModelTb
            // 
            this.ModelTb.Location = new System.Drawing.Point(177, 333);
            this.ModelTb.Name = "ModelTb";
            this.ModelTb.Size = new System.Drawing.Size(100, 22);
            this.ModelTb.TabIndex = 33;
            this.ModelTb.Validating += new System.ComponentModel.CancelEventHandler(this.ModelTb_Validating);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(813, 311);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(129, 47);
            this.RemoveBtn.TabIndex = 32;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(8, 70);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(945, 235);
            this.DataGridView.TabIndex = 31;
            this.DataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_CellBeginEdit);
            this.DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellEndEdit);
            // 
            // UsersPage
            // 
            this.UsersPage.Controls.Add(this.UsersGrid);
            this.UsersPage.Location = new System.Drawing.Point(4, 25);
            this.UsersPage.Name = "UsersPage";
            this.UsersPage.Padding = new System.Windows.Forms.Padding(3);
            this.UsersPage.Size = new System.Drawing.Size(928, 531);
            this.UsersPage.TabIndex = 2;
            this.UsersPage.Text = "Users";
            this.UsersPage.UseVisualStyleBackColor = true;
            // 
            // UsersGrid
            // 
            this.UsersGrid.AllowUserToAddRows = false;
            this.UsersGrid.AllowUserToDeleteRows = false;
            this.UsersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGrid.Location = new System.Drawing.Point(48, 44);
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.ReadOnly = true;
            this.UsersGrid.RowTemplate.Height = 24;
            this.UsersGrid.Size = new System.Drawing.Size(830, 287);
            this.UsersGrid.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(720, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "Car Id";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 607);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.OrdersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            this.CarsPage.ResumeLayout(false);
            this.CarsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.UsersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OrdersPage;
        private System.Windows.Forms.DataGridView OrdersGrid;
        private System.Windows.Forms.TabPage CarsPage;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PricePerHourTb;
        private System.Windows.Forms.TextBox TotalCarsTb;
        private System.Windows.Forms.TextBox BalanceTb;
        private System.Windows.Forms.TextBox ColorTb;
        private System.Windows.Forms.TextBox ModelTb;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TabPage UsersPage;
        private System.Windows.Forms.DataGridView UsersGrid;
        private System.Windows.Forms.Label label6;
    }
}