using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HotelManagementSystemEmreAyhan.Views
{
    /// <summary>
    /// Interaction logic for SignUpView.xaml
    /// </summary>
    public partial class SignUpView : Window
    {
        public SignUpView()
        {
            InitializeComponent();
        }


        public string connectionString = @"Data Source=(localdb)\LocalDbEmre;Integrated Security=True;Connect Timeout=30;
        Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void SubmitButton(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {

                if (txtUserName.Text == "" || txtPassword.Text == "")
                    MessageBox.Show("Fill the fields");

                else if (txtPassword.Text != txtConfirmPassword.Text)
                    MessageBox.Show("Password doesn't match.");
                else
                {

                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("[HotelManagementDb].[dbo].[CreateUser]", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                
                sqlCmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Registration complete!");
                Clear();
                    LoginView lv = new LoginView();
                    this.Hide();
                    lv.Show();
                }
                    
            }

            void Clear()
            {
                txtUserName.Text = txtPassword.Text = txtFirstName.Text = txtLastName.Text = txtPhoneNumber.Text = "";
            }
        }

        private void CancelButton(object sender, RoutedEventArgs e)
        {
            LoginView lv = new LoginView();
            this.Hide();
            lv.Show();
        }
    }
}
