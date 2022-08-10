using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserStreets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> streets;

        //ReadLine, take a string in quotation marks
        //and Insert "," after every string
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                var spreadsheetLocation = Path.Combine(Directory.GetCurrentDirectory());
                var filePath = string.Empty;
                
                openFileDialog.InitialDirectory = spreadsheetLocation;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    streets = new List<string>();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        richTextBox1.Clear();
                        string s;
                        bool isTitle = false;
                        while ((s = reader.ReadLine()) != null)
                        {
                            //if (s.Contains("//") && !s.Contains("///"))
                            {
                                string t = @"";
                                s = s.Insert(0, "\"");
                                s = s.Insert(s.Length, "\"");
                                s = s.Insert(s.Length, ",");
                                streets.Add(s);
                                richTextBox1.Text += s;
                                richTextBox1.Text += Environment.NewLine;
                            }
                        }
                    }
                }
            }
        }

        //Read's the file to the end
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                richTextBox1.Clear();
                var spreadsheetLocation = Path.Combine(Directory.GetCurrentDirectory());
                var filePath = string.Empty;
                streets = new List<string>();
                openFileDialog.InitialDirectory = spreadsheetLocation;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    streets = new List<string>();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string s;
                        bool isTitle = false;
                        s = reader.ReadToEnd();
                        {
                            //if (s.Contains("//") && !s.Contains("///"))
                            {
                                /*
                                s = s.Substring(s.IndexOf("//"));
                                s = s.TrimStart('/');
                                s = s.Replace("#", "Назначение: ");
                                s = s.Replace("@Comment", "");//
                                s = s.Replace("@Methoood", "@Метод: ");
                                */
                                //streets.Add(s);
                                richTextBox1.Text += s;
                                //richTextBox1.Text += Environment.NewLine;

                            }
                        }
                    }
                }
            }
        }

        //Save formatted strings to a txt file
        private void Savebutton3_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (StreamWriter writer = new StreamWriter(myStream))
                    {
                        if ((line_by_lineRadioButton.Checked) == true)
                        {
                            foreach (string str in streets)
                            {
                                writer.WriteLine(str);
                            }
                        }
                        else if ((arrayRadioButton.Checked) == true)
                        {
                            foreach (string str in streets)
                            {
                                writer.Write(str);
                            }
                        }
                    }
                    myStream.Close();
                }
            }
        }

        //Read the file line by line and removes all space characters at the end of each string
        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                var spreadsheetLocation = Path.Combine(Directory.GetCurrentDirectory());
                var filePath = string.Empty;

                openFileDialog.InitialDirectory = spreadsheetLocation;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    streets = new List<string>();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        richTextBox1.Clear();
                        string s;
                        Char[] required_symbols = { ' ' };
                        int symbol_index;
                        
                        while ((s = reader.ReadLine()) != null)
                        {
                            //Get last entry of required symbol
							symbol_index = s.LastIndexOfAny(required_symbols);
							//while last entry == lenght of processed string -> continue processing
							while (symbol_index == (s.Length - 1))
							{
								//If the required character is not the only character at the end of the line,
								//first delete the last entry
								if (symbol_index == (s.Length - 1))
								{
									while (symbol_index <= s.Length)//while index does not go beyond the line
									{
										if (symbol_index == s.Length)//if the index is equal to the length of the row
										{
											s = s.Remove(symbol_index - 1);//delete the last character of the row
										}
										symbol_index++;//moving the index to the end
									}
									//get the last entry of the searched character
									symbol_index = s.LastIndexOfAny(required_symbols);
								}
							}
							streets.Add(s);
							richTextBox1.Text += s;
							richTextBox1.Text += Environment.NewLine;
                        }
                    }
                }
            }
        }

        //Read the file line by line and delite "/r/n" symbols
        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                var spreadsheetLocation = Path.Combine(Directory.GetCurrentDirectory());
                var filePath = string.Empty;

                openFileDialog.InitialDirectory = spreadsheetLocation;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    streets = new List<string>();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        richTextBox1.Clear();
                        string s;
                        while ((s = reader.ReadLine()) != null)
                        {
                            {
                                s = s.Replace("\r\n", string.Empty);
                                streets.Add(s);
                                richTextBox1.Text += s;
                                richTextBox1.Text += Environment.NewLine;

                            }
                        }
                    }
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void line_by_lineRadioButton_Click(object sender, EventArgs e)
        {
            arrayRadioButton.Checked = false;
        }

        private void arrayRadioButton_Click(object sender, EventArgs e)
        {
            line_by_lineRadioButton.Checked = false;
        }
    }
}