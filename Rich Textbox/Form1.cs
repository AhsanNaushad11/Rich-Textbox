using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rich_Textbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**************************All Initialized Variables******************************/
        public string contents, data;
        public OpenFileDialog openFile;
        public Form1 NewFile;
        public string file, dataFromFile;

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Exit pressed from menustrip.");
                this.Close();
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occured: " + exp);
            }
            finally
            {
                this.Close();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Save pressed from menustrip.");
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occured: " + exp);
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Save As pressed from menustrip.");

            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occured: " + exp);
            }
        }
        

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Open pressed from menustrip.");

                openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    file = openFile.FileName;
                    Console.WriteLine("Opening file: " + file);

                    dataFromFile = File.ReadAllText(file);
                    MyTextBox.Text = dataFromFile;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occured: " + exp);
            }
        }

        /* Launches a new instance of editor from menustrip > File > New */
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("New pressed from menustrip.");

                NewFile = new Form1();
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occured: " + exp);
            }
        }

        /***********************TextBox_TextChanged***********************/
        private void MyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /***************************Form Load***************************/
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /* Inserts date/time from menustrip > edit > date/time */
        private void DateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Date Time pressed from menustrip.");
                MyTextBox.Text = (DateTime.Now).ToString();
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occured: " + exp);
            }
        }

        /* This method allows dragging text from outside to be dropped inside of given textfield. */
        private void MyTextBox_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.All;
                contents = (e.Data.GetData(DataFormats.Text)).ToString();
                MyTextBox.Text = contents;
            }
            catch (Exception exp)
            {
                MyTextBox.Text = "Following exception occured:\n\n" + exp.ToString();
            }
        }
    }
}
