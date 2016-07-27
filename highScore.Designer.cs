namespace Minesweeper
{
    partial class highScore
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
            this.lblNoInitials = new System.Windows.Forms.Label();
            this.submitInitials = new System.Windows.Forms.Button();
            this.tbInitials = new System.Windows.Forms.TextBox();
            this.lblFstMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoInitials
            // 
            this.lblNoInitials.AutoSize = true;
            this.lblNoInitials.Location = new System.Drawing.Point(77, 76);
            this.lblNoInitials.Name = "lblNoInitials";
            this.lblNoInitials.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNoInitials.Size = new System.Drawing.Size(123, 17);
            this.lblNoInitials.TabIndex = 29;
            this.lblNoInitials.Text = "No Initials Entered";
            this.lblNoInitials.Visible = false;
            // 
            // submitInitials
            // 
            this.submitInitials.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitInitials.Location = new System.Drawing.Point(58, 125);
            this.submitInitials.Margin = new System.Windows.Forms.Padding(4);
            this.submitInitials.Name = "submitInitials";
            this.submitInitials.Size = new System.Drawing.Size(167, 52);
            this.submitInitials.TabIndex = 28;
            this.submitInitials.Text = "Submit";
            this.submitInitials.UseVisualStyleBackColor = true;
            this.submitInitials.Click += new System.EventHandler(this.submitInitials_Click);
            // 
            // tbInitials
            // 
            this.tbInitials.Location = new System.Drawing.Point(90, 96);
            this.tbInitials.MaxLength = 30;
            this.tbInitials.Name = "tbInitials";
            this.tbInitials.Size = new System.Drawing.Size(100, 22);
            this.tbInitials.TabIndex = 27;
            // 
            // lblFstMsg
            // 
            this.lblFstMsg.AutoSize = true;
            this.lblFstMsg.Location = new System.Drawing.Point(12, 9);
            this.lblFstMsg.Name = "lblFstMsg";
            this.lblFstMsg.Size = new System.Drawing.Size(145, 17);
            this.lblFstMsg.TabIndex = 30;
            this.lblFstMsg.Text = "Fastest time message";
            this.lblFstMsg.Click += new System.EventHandler(this.lblFstMsg_Click);
            // 
            // highScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 221);
            this.Controls.Add(this.lblFstMsg);
            this.Controls.Add(this.lblNoInitials);
            this.Controls.Add(this.submitInitials);
            this.Controls.Add(this.tbInitials);
            this.Name = "highScore";
            this.Text = "New High Score!";
            this.Load += new System.EventHandler(this.highScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoInitials;
        private System.Windows.Forms.Button submitInitials;
        private System.Windows.Forms.TextBox tbInitials;
        private System.Windows.Forms.Label lblFstMsg;
    }
}