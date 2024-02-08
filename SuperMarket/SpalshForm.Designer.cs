namespace SuperMarket
{
    partial class SpalshForm
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
            this.CircleButton_SpalshForm = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.label_SuperMarketManagementSystem = new System.Windows.Forms.Label();
            this.AM_ProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label_AM = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.timer_Start = new System.Windows.Forms.Timer(this.components);
            this.AM_ProgressBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // CircleButton_SpalshForm
            // 
            this.CircleButton_SpalshForm.CheckedState.Parent = this.CircleButton_SpalshForm;
            this.CircleButton_SpalshForm.CustomImages.Parent = this.CircleButton_SpalshForm;
            this.CircleButton_SpalshForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CircleButton_SpalshForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CircleButton_SpalshForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CircleButton_SpalshForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CircleButton_SpalshForm.DisabledState.Parent = this.CircleButton_SpalshForm;
            this.CircleButton_SpalshForm.FillColor = System.Drawing.Color.White;
            this.CircleButton_SpalshForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CircleButton_SpalshForm.ForeColor = System.Drawing.Color.White;
            this.CircleButton_SpalshForm.HoverState.Parent = this.CircleButton_SpalshForm;
            this.CircleButton_SpalshForm.Location = new System.Drawing.Point(-5, 237);
            this.CircleButton_SpalshForm.Name = "CircleButton_SpalshForm";
            this.CircleButton_SpalshForm.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CircleButton_SpalshForm.ShadowDecoration.Parent = this.CircleButton_SpalshForm;
            this.CircleButton_SpalshForm.Size = new System.Drawing.Size(642, 274);
            this.CircleButton_SpalshForm.TabIndex = 0;
            // 
            // label_SuperMarketManagementSystem
            // 
            this.label_SuperMarketManagementSystem.AutoSize = true;
            this.label_SuperMarketManagementSystem.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SuperMarketManagementSystem.Location = new System.Drawing.Point(73, 19);
            this.label_SuperMarketManagementSystem.Name = "label_SuperMarketManagementSystem";
            this.label_SuperMarketManagementSystem.Size = new System.Drawing.Size(522, 28);
            this.label_SuperMarketManagementSystem.TabIndex = 1;
            this.label_SuperMarketManagementSystem.Text = "SUPERMARKET MANAGEMENT SYSTEM";
            // 
            // AM_ProgressBar
            // 
            this.AM_ProgressBar.Backwards = true;
            this.AM_ProgressBar.Controls.Add(this.label_AM);
            this.AM_ProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AM_ProgressBar.ForeColor = System.Drawing.Color.White;
            this.AM_ProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AM_ProgressBar.Location = new System.Drawing.Point(235, 70);
            this.AM_ProgressBar.Minimum = 0;
            this.AM_ProgressBar.Name = "AM_ProgressBar";
            this.AM_ProgressBar.ProgressColor = System.Drawing.Color.Yellow;
            this.AM_ProgressBar.ProgressColor2 = System.Drawing.Color.Red;
            this.AM_ProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.AM_ProgressBar.ShadowDecoration.Parent = this.AM_ProgressBar;
            this.AM_ProgressBar.Size = new System.Drawing.Size(161, 161);
            this.AM_ProgressBar.TabIndex = 2;
            this.AM_ProgressBar.Text = "guna2CircleProgressBar1";
            // 
            // label_AM
            // 
            this.label_AM.AutoSize = true;
            this.label_AM.Font = new System.Drawing.Font("Bradley Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AM.ForeColor = System.Drawing.Color.Black;
            this.label_AM.Location = new System.Drawing.Point(36, 53);
            this.label_AM.Name = "label_AM";
            this.label_AM.Size = new System.Drawing.Size(86, 50);
            this.label_AM.TabIndex = 3;
            this.label_AM.Text = "AM";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // timer_Start
            // 
            this.timer_Start.Tick += new System.EventHandler(this.timer_Start_Tick);
            // 
            // SpalshForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(632, 353);
            this.Controls.Add(this.AM_ProgressBar);
            this.Controls.Add(this.label_SuperMarketManagementSystem);
            this.Controls.Add(this.CircleButton_SpalshForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpalshForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpalshForm";
            this.Load += new System.EventHandler(this.SpalshForm_Load);
            this.AM_ProgressBar.ResumeLayout(false);
            this.AM_ProgressBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton CircleButton_SpalshForm;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label label_SuperMarketManagementSystem;
        private Guna.UI2.WinForms.Guna2CircleProgressBar AM_ProgressBar;
        private System.Windows.Forms.Label label_AM;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Timer timer_Start;
    }
}