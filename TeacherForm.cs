/** Application Purpose: A class to operate teacher form
* Author: Yunna Jang 200455726
* Date: 17/4/2021
* Time: 9:13PM
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CollegeManagementSystem
{
    public partial class TeacherForm : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CollegeDB.accdb; Persist Security Info=True");
        public TeacherForm()
        {
            InitializeComponent();
      
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "Insert into teachers (firstName, lastName) Values (@firstName, @lastName)";

                command.Parameters.AddWithValue("@firstName", firstNameTextBox.Text);
                command.Parameters.AddWithValue("@lastName", lastNameTextBox.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("success");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE Records SET firstName = @firstName, lastName = @lastName WHERE [ID] = @id";
                command.Parameters.AddWithValue("@firstName", firstNameTextBox.Text);
                command.Parameters.AddWithValue("@lastName", lastNameTextBox.Text);
                //command.Parameters.AddWithValue("@id", int.Parse(id_label.Text));


                command.ExecuteNonQuery();
                MessageBox.Show("success");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "Select * from teachers";

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                teacherDataGridView.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
