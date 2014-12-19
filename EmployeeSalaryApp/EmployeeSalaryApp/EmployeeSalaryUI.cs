using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class EmployeeSalaryUI : Form
    {
        private string path = @"E:\employee.txt";
        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string employeeInfo = nameTextBox.Text + "," + idTextBox.Text + "," + salaryTextBox.Text;
            FileStream aFileStream = new FileStream(path, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(employeeInfo);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
            aFileStream.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(path, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);

            showAllListBox.Items.Clear();
            double salary, totalAmount=0;

            while (!aStreamReader.EndOfStream)
            {
                string showResult = aStreamReader.ReadLine();
                showAllListBox.Items.Add(showResult);
                string[] employeeInfo = showResult.Split(',');
                salary = Convert.ToDouble(employeeInfo[2]);
                totalAmount += salary;
            }

            totalSalaryTextBox.Text = totalAmount.ToString();

            aStreamReader.Close();
            aFileStream.Close();
        }

       
    }
}
