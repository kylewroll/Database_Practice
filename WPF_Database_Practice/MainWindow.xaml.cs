/*Author: Kyle Rolland
 * Date: 2/20/2021
 * File: MainWindow.xaml.cs
 * Description: Implementation for button functions, main window, and connection to database
 */

using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.OleDb;

namespace WPF_Database_Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    //creates connection to database
    public partial class MainWindow : Window
    {
        OleDbConnection cn;

        public MainWindow()
        {
            InitializeComponent();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\DatabasePractice1.accdb");
        }
        


        //function for clicking See Assets button, takes asset table and displays data in the text box under button
        private void See_Assets_Click(object sender, RoutedEventArgs e)
        {
            //select all columns from assets table
            string query = "SELECT * from Assets";

            //create command using select from assets string
            OleDbCommand cmd = new OleDbCommand(query, cn);

            //opens database
            cn.Open();

            //used for reading data
            OleDbDataReader read = cmd.ExecuteReader();

            

            string data = "";

            //could probaly be implemented better, but it gets the job done well enough
            while(read.Read())
            {
                //tabs for readbility
                data += read[0].ToString() + "\t"; 
                data += read[1].ToString() + "\t"; 
                data += read[2].ToString() + "\n";
            }

            cn.Close();

            //updates text box beneath See Assets button
            Asset_Display.Text = data;
        }

        //function for clicking See Employees button, takes employee table and displays data in text under button
        private void See_Employees_Click(object sender, RoutedEventArgs e)
        {
            //select all comlumns from employees table
            string query = "select * from Employees";

            //create command using select from employees string
            OleDbCommand cmd = new OleDbCommand(query, cn);

            cn.Open();

            OleDbDataReader read = cmd.ExecuteReader();

            string data = "";

            while(read.Read())
            {
                data += read[0].ToString() + "\t";
                data += read[1].ToString() + "\t";
                data += read[2].ToString() + "\n";
            }

            cn.Close();

            //updates text in box beneath See Employees button
            Employee_Display.Text = data;
        }
    }
}
