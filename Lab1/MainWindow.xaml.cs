/// Chapter No. 9 and 10 - Week4_Lab1
/// File Name: Lab1.java
/// @author: Rossana Palma
/// Date:  September 13, 2021
///
/// Problem Statement: Write a GUI program that takes your full name and changes it to a new name using Pig Latin rules.
/// 
/// Overall Plan:
/// 1) Create text boxs, labels and buttom in GUI application
/// 2) Declare variables in console application
/// 3) Write in lowercase the first and the last names
/// 4) Move the first letter of each name to the end and add "ay" to the end for both words
/// 5) Capitalize the new first letter of each word
/// 6) Display the pig latin name on the screen
/// 
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

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pigLatinButton_Click(object sender, RoutedEventArgs e)
        {
            String firstName = firstNameTextBox.Text;
            String lastName = lastNameTextBox.Text;
            String pigLatinFirstName;
            String pigLatinLastName;
            firstName = firstName.ToLower();
            lastName = lastName.ToLower();

            pigLatinFirstName = firstName.Substring(1, firstName.Length - 1) + firstName.Substring(0, 1) + "ay";
            pigLatinFirstName = pigLatinFirstName.Substring(0, 1).ToUpper() + pigLatinFirstName.Substring(1, pigLatinFirstName.Length - 1);

            pigLatinLastName = lastName.Substring(1, lastName.Length - 1) + lastName.Substring(0, 1) + "ay";
            pigLatinLastName = pigLatinLastName.Substring(0, 1).ToUpper() + pigLatinLastName.Substring(1, pigLatinLastName.Length - 1);

            MessageBox.Show("Your name in pigLatin is : " + pigLatinFirstName + " " + pigLatinLastName);
        }
    }
}