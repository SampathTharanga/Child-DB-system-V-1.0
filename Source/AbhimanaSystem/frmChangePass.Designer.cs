namespace AbhimanaSystem
{
    partial class frmChangePass
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
            this.txtNewPass = new MetroFramework.Controls.MetroTextBox();
            this.txtReEnterPass = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtNewPass
            // 
            // 
            // 
            // 
            this.txtNewPass.CustomButton.Image = null;
            this.txtNewPass.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.txtNewPass.CustomButton.Name = "";
            this.txtNewPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPass.CustomButton.TabIndex = 1;
            this.txtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPass.CustomButton.UseSelectable = true;
            this.txtNewPass.CustomButton.Visible = false;
            this.txtNewPass.Lines = new string[0];
            this.txtNewPass.Location = new System.Drawing.Point(43, 64);
            this.txtNewPass.MaxLength = 12;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.PromptText = "Enter the new password";
            this.txtNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.SelectionLength = 0;
            this.txtNewPass.SelectionStart = 0;
            this.txtNewPass.ShortcutsEnabled = true;
            this.txtNewPass.Size = new System.Drawing.Size(276, 23);
            this.txtNewPass.TabIndex = 0;
            this.txtNewPass.UseSelectable = true;
            this.txtNewPass.WaterMark = "Enter the new password";
            this.txtNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtReEnterPass
            // 
            // 
            // 
            // 
            this.txtReEnterPass.CustomButton.Image = null;
            this.txtReEnterPass.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.txtReEnterPass.CustomButton.Name = "";
            this.txtReEnterPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReEnterPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReEnterPass.CustomButton.TabIndex = 1;
            this.txtReEnterPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReEnterPass.CustomButton.UseSelectable = true;
            this.txtReEnterPass.CustomButton.Visible = false;
            this.txtReEnterPass.Lines = new string[0];
            this.txtReEnterPass.Location = new System.Drawing.Point(43, 96);
            this.txtReEnterPass.MaxLength = 12;
            this.txtReEnterPass.Name = "txtReEnterPass";
            this.txtReEnterPass.PasswordChar = '●';
            this.txtReEnterPass.PromptText = "Re-enter the new password";
            this.txtReEnterPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReEnterPass.SelectedText = "";
            this.txtReEnterPass.SelectionLength = 0;
            this.txtReEnterPass.SelectionStart = 0;
            this.txtReEnterPass.ShortcutsEnabled = true;
            this.txtReEnterPass.Size = new System.Drawing.Size(276, 23);
            this.txtReEnterPass.TabIndex = 1;
            this.txtReEnterPass.UseSelectable = true;
            this.txtReEnterPass.WaterMark = "Re-enter the new password";
            this.txtReEnterPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReEnterPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(258, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(192, 128);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(126, 128);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 169);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtReEnterPass);
            this.Controls.Add(this.txtNewPass);
            this.MaximizeBox = false;
            this.Name = "frmChangePass";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Chnage Password";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNewPass;
        private MetroFramework.Controls.MetroTextBox txtReEnterPass;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}