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
using Microsoft.EntityFrameworkCore.Design;

namespace HotelManagementSystemEmreAyhan.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }



        public string connectionString = @"Data Source=(localdb)\LocalDbEmre;Integrated Security=True;Connect Timeout=30;
        Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            string query = "Select * from [HotelManagementDb].[dbo].[Users] Where UserName = '" + txtUserName.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                MenuView mv = new MenuView();
                this.Hide();
                mv.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SignUpView sv = new SignUpView();
            this.Hide();
            sv.Show();
        }
    }
    }

