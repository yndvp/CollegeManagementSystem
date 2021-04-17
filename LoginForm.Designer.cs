
namespace CollegeManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.StudentPictureBox = new System.Windows.Forms.PictureBox();
            this.administratorPictureBox = new System.Windows.Forms.PictureBox();
            this.studentButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.StudentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.administratorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentPictureBox
            // 
            this.StudentPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StudentPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StudentPictureBox.Image = ((System.Drawing.Image) (resources.GetObject("StudentPictureBox.Image")));
            this.StudentPictureBox.InitialImage = null;
            this.StudentPictureBox.Location = new System.Drawing.Point(126, 200);
            this.StudentPictureBox.Name = "StudentPictureBox";
            this.StudentPictureBox.Size = new System.Drawing.Size(219, 237);
            this.StudentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentPictureBox.TabIndex = 0;
            this.StudentPictureBox.TabStop = false;
            // 
            // administratorPictureBox
            // 
            this.administratorPictureBox.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("administratorPictureBox.BackgroundImage")));
            this.administratorPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.administratorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.administratorPictureBox.Location = new System.Drawing.Point(489, 200);
            this.administratorPictureBox.Name = "administratorPictureBox";
            this.administratorPictureBox.Size = new System.Drawing.Size(219, 237);
            this.administratorPictureBox.TabIndex = 1;
            this.administratorPictureBox.TabStop = false;
            // 
            // studentButton
            // 
            this.studentButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.studentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.studentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentButton.Location = new System.Drawing.Point(150, 475);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(170, 27);
            this.studentButton.TabIndex = 2;
            this.studentButton.Text = "STUDENT";
            this.studentButton.UseVisualStyleBackColor = false;
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.adminButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminButton.Location = new System.Drawing.Point(515, 475);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(170, 27);
            this.adminButton.TabIndex = 3;
            this.adminButton.Text = "ADMINISTRATOR";
            this.adminButton.UseVisualStyleBackColor = false;
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginLabel.Location = new System.Drawing.Point(150, 42);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(535, 96);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Please tell us who you are...!";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(838, 604);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.administratorPictureBox);
            this.Controls.Add(this.StudentPictureBox);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize) (this.StudentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.administratorPictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label loginLabel;

        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button adminButton;

        private System.Windows.Forms.PictureBox StudentPictureBox;
        private System.Windows.Forms.PictureBox administratorPictureBox;

        #endregion
    }
}