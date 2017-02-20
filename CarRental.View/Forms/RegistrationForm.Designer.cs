namespace CarRental.View.Forms
{
    partial class RegistrationForm
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
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginTb = new System.Windows.Forms.TextBox();
            this.FirstNameTb = new System.Windows.Forms.TextBox();
            this.LastNameTb = new System.Windows.Forms.TextBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(39, 149);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SubmitBtn.Size = new System.Drawing.Size(255, 39);
            this.SubmitBtn.TabIndex = 0;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // LoginTb
            // 
            this.LoginTb.Location = new System.Drawing.Point(134, 26);
            this.LoginTb.Name = "LoginTb";
            this.LoginTb.Size = new System.Drawing.Size(160, 22);
            this.LoginTb.TabIndex = 5;
            this.LoginTb.Validating += new System.ComponentModel.CancelEventHandler(this.LoginTb_Validating);
            // 
            // FirstNameTb
            // 
            this.FirstNameTb.Location = new System.Drawing.Point(134, 54);
            this.FirstNameTb.Name = "FirstNameTb";
            this.FirstNameTb.Size = new System.Drawing.Size(160, 22);
            this.FirstNameTb.TabIndex = 6;
            this.FirstNameTb.Validating += new System.ComponentModel.CancelEventHandler(this.FirstNameTb_Validating);
            // 
            // LastNameTb
            // 
            this.LastNameTb.Location = new System.Drawing.Point(134, 82);
            this.LastNameTb.Name = "LastNameTb";
            this.LastNameTb.Size = new System.Drawing.Size(160, 22);
            this.LastNameTb.TabIndex = 7;
            this.LastNameTb.Validating += new System.ComponentModel.CancelEventHandler(this.LastNameTb_Validating);
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(134, 110);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(160, 22);
            this.PasswordTb.TabIndex = 8;
            this.PasswordTb.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTb_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 223);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.LastNameTb);
            this.Controls.Add(this.FirstNameTb);
            this.Controls.Add(this.LoginTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitBtn);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LoginTb;
        private System.Windows.Forms.TextBox FirstNameTb;
        private System.Windows.Forms.TextBox LastNameTb;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}