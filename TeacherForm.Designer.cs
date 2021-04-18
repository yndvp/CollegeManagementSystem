
namespace CollegeManagementSystem
{
    partial class TeacherForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.teacherDataGridView = new System.Windows.Forms.DataGridView();
            this.loadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(96, 28);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(75, 15);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(427, 28);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 15);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(96, 77);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(54, 15);
            this.genderLabel.TabIndex = 2;
            this.genderLabel.Text = "Gender";
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(427, 77);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(92, 15);
            this.DOBLabel.TabIndex = 3;
            this.DOBLabel.Text = "Date Of Birth";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(96, 124);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 15);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(427, 124);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 15);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Address";
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Location = new System.Drawing.Point(96, 178);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(54, 15);
            this.courseLabel.TabIndex = 6;
            this.courseLabel.Text = "Course";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(194, 28);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(520, 17);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.genderComboBox.Location = new System.Drawing.Point(205, 77);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 23);
            this.genderComboBox.TabIndex = 9;
            // 
            // DOBPicker
            // 
            this.DOBPicker.Location = new System.Drawing.Point(520, 73);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(251, 25);
            this.DOBPicker.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(205, 113);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 25);
            this.emailTextBox.TabIndex = 11;
            // 
            // courseTextBox
            // 
            this.courseTextBox.Location = new System.Drawing.Point(194, 167);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(100, 25);
            this.courseTextBox.TabIndex = 13;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(146, 217);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(351, 217);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 15;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(482, 217);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addressRichTextBox
            // 
            this.addressRichTextBox.Location = new System.Drawing.Point(520, 124);
            this.addressRichTextBox.Name = "addressRichTextBox";
            this.addressRichTextBox.Size = new System.Drawing.Size(188, 86);
            this.addressRichTextBox.TabIndex = 17;
            this.addressRichTextBox.Text = "";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(646, 228);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // teacherDataGridView
            // 
            this.teacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDataGridView.Location = new System.Drawing.Point(56, 273);
            this.teacherDataGridView.Name = "teacherDataGridView";
            this.teacherDataGridView.RowHeadersWidth = 51;
            this.teacherDataGridView.RowTemplate.Height = 27;
            this.teacherDataGridView.Size = new System.Drawing.Size(665, 200);
            this.teacherDataGridView.TabIndex = 19;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(350, 167);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 20;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.teacherDataGridView);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.addressRichTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.DOBPicker);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker DOBPicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.RichTextBox addressRichTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataGridView teacherDataGridView;
        private System.Windows.Forms.Button loadButton;
    }
}