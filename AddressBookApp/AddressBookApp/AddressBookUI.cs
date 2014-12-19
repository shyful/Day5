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

namespace AddressBookApp
{
    public partial class AddressBookUI : Form
    {
        public AddressBookUI()
        {
            InitializeComponent();
        }

        private string filePath = "E:\\Addressbookinfo.csv";

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text;
            string email = email_addresstextBox.Text;
            string homecontactno = homecontactnotextBox.Text;
            string personalcontactno = personalcontactnotextBox.Text;
            string homeaddres = homeaddresstextBox.Text;
            if (File.Exists(filePath))
            {
                if (CheckAvailability(personalcontactno))
                {
                    //bool uniqueReg = true;
                    FileStream aFileStream = new FileStream(filePath, FileMode.Append);
                    CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                    List<string> aStudentRecord = new List<string>();
                    aStudentRecord.Add(name);
                    aStudentRecord.Add(email);
                    aStudentRecord.Add(homecontactno);
                    aStudentRecord.Add(personalcontactno);
                    aStudentRecord.Add(homeaddres);
                    aWriter.WriteRow(aStudentRecord);
                    aFileStream.Close();
                }
                else
                {
                    MessageBox.Show("Duplicate contact information found");
                }
                

            }
            else
            {
                FileStream aFileStream = new FileStream(filePath, FileMode.Append);
                CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                List<string> aStudentRecord = new List<string>();
                aStudentRecord.Add(name);
                aStudentRecord.Add(email);
                aStudentRecord.Add(homecontactno);
                aStudentRecord.Add(personalcontactno);
                aStudentRecord.Add(homeaddres);
                aWriter.WriteRow(aStudentRecord);
                aFileStream.Close();
            }
        }

        private bool CheckAvailability(string personalcontactno)
        {
            FileStream aFileStream = new FileStream(filePath, FileMode.Open);
            CsvFileReader aCsvFileReader = new CsvFileReader(aFileStream);
            List<string> aStudentRecord = new List<string>();
            while (aCsvFileReader.ReadRow(aStudentRecord))
            {
                if (personalcontactno == aStudentRecord[2])
                
                    return false;
                
            }
            aFileStream.Close();
            return true;

        }

        private void showallButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                FileStream aFileStream = new FileStream(filePath, FileMode.Open);
                CsvFileReader aCsvFileReader = new CsvFileReader(aFileStream);
                List<string> aStudentDataRead = new List<string>();
                showalllistView.Items.Clear();
                while (aCsvFileReader.ReadRow(aStudentDataRead))
                {
                    //string name = aStudentDataRead[0];
                    //string email = aStudentDataRead[1];
                    //string homecontactno = aStudentDataRead[2];
                    //string personalcontactno = aStudentDataRead[3];
                    //string homeaddres = aStudentDataRead[4];
                    //showalllistView.Items.Add(name +"\n"+email+""+"\n"+homecontactno+"\n"+personalcontactno+"\n"+homeaddres);
                    ListViewItem myView = new ListViewItem(aStudentDataRead[0]);
                    for (int i = 1; i < 5; i++)
                      myView.SubItems.Add(aStudentDataRead[i]);
                    showalllistView.Items.Add(myView);
                }
                aFileStream.Close();
            }
            else
            {
                MessageBox.Show("The requested file does not exist.");
            }


           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(filePath, FileMode.Open);
            CsvFileReader aCsvFileReader = new CsvFileReader(aFileStream);
            List<string> aStudentDataRead = new List<string>();
            showalllistView.Items.Clear();
            while (aCsvFileReader.ReadRow(aStudentDataRead))
            {
                if (nameradioButton.Checked == true)
                {
                   
                    string search = aStudentDataRead[0];
                    string gainword = searchtextBox.Text;
                    //bool b=true;
                    ListViewItem myView = new ListViewItem(aStudentDataRead[0]);
                    if (aStudentDataRead[0].ToLower().Contains(gainword.ToLower()))
                    {
                        //showalllistView.Items.Add(aStudentDataRead[0]);
                        for (int i = 1; i < 5; i++)
                            myView.SubItems.Add(aStudentDataRead[i]);
                        showalllistView.Items.Add(myView);
                    }
                    
                }
                else if (emailradioButton.Checked == true)
                {
                   
                    string search = aStudentDataRead[1];
                    string gainword = searchtextBox.Text;
                    //bool b=true;
                    ListViewItem myView = new ListViewItem(aStudentDataRead[0]);
                    if (aStudentDataRead[1].ToLower().Contains(gainword.ToLower()))
                    {
                        //showalllistView.Items.Add(aStudentDataRead[1]);
                        for (int i = 1; i < 5; i++)
                            myView.SubItems.Add(aStudentDataRead[i]);
                        showalllistView.Items.Add(myView);
                       
                    }
                    
                }
                else if (noradioButton.Checked == true)
                {

                    string search = aStudentDataRead[2];
                    string gainword = searchtextBox.Text;
                    //bool b = true;
                   
                    if (aStudentDataRead[2].ToLower().Contains(gainword.ToLower()))
                    {
                        ListViewItem myView = new ListViewItem(aStudentDataRead[0]);
                        //showalllistView.Items.Add(aStudentDataRead[2]);
                        for (int i = 1; i < 5; i++)
                            myView.SubItems.Add(aStudentDataRead[i]);
                        showalllistView.Items.Add(myView);
                    }

                }

            }
            aFileStream.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showalllistView.Columns.Add(label1.Text);
            showalllistView.Columns.Add(label2.Text);
            showalllistView.Columns.Add(label3.Text);
            showalllistView.Columns.Add(label4.Text);
            showalllistView.Columns.Add(label5.Text);
        }
        }
    }
