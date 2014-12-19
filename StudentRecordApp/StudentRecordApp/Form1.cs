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
using CSVLib;

namespace StudentRecordApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string fileLocation = @"E:\StudentRecord.CSV";
        private void saveButton_Click(object sender, EventArgs e)
        {
            string regno = reg_notextBox.Text;
            string name = name_textBox.Text;
            if (File.Exists(fileLocation))
            {
                bool uniqueReg = checker(regno);
                if (uniqueReg == true)
                {
                    FileStream aFileStream = new FileStream(fileLocation, FileMode.Append);
                    //StreamWriter aStreamWriter=new StreamWriter(aFileStream);
                    CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                    List<string> studentList = new List<string>();
                    studentList.Add(regno);
                    studentList.Add(name);
                    aWriter.WriteRow(studentList);
                    aFileStream.Close();
                }
                else
                {
                    MessageBox.Show("No need to add");
                }
            }
            else
            {
                FileStream aFileStream = new FileStream(fileLocation, FileMode.Append);
                //StreamWriter aStreamWriter=new StreamWriter(aFileStream);
                CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                List<string> studentList = new List<string>();
                studentList.Add(regno);
                studentList.Add(name);
                aWriter.WriteRow(studentList);
                aFileStream.Close();
            }
        }

        private bool checker(string regno)
        {
            int registerationno = Convert.ToInt32(regno);
            FileStream aFileStream=new FileStream(fileLocation,FileMode.Append);
            //StreamWriter aStreamWriter=new StreamWriter(aFileStream);
            CsvFileReader aReader=new CsvFileReader(aFileStream);
            List<string> studentList=new List<string>();
            int unireg = Convert.ToInt32(studentList[0]);
            bool p = true;
            while (aReader.ReadRow(studentList))
            {
                if (registerationno==unireg)
                {
                    p = false;
                }
                else
                {
                    p = true;

                }
            }
            aFileStream.Close();
            return p;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream=new FileStream(fileLocation,FileMode.Open);
            CsvFileReader aReader=new CsvFileReader(aFileStream);
            List<string> studentList = new List<string>();
            student_listBox.Items.Clear();
            while (aReader.ReadRow(studentList))
            {
                string studentRegNo = studentList[0];
                string studentName = studentList[1];
               student_listBox.Items.Add(studentRegNo + " " + studentName);
            }
            aFileStream.Close();
        }
    }
}
