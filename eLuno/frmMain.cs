using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLuno
{
    public partial class frmMain : Form
    {
        urlDialogue getUrl;     // Form to input the url or web page
        string url="https://";  // Only support https not http
        string htmldoc = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /*
         * Display the Form: urlDialogue and input the URI to open.
         * 
         */
        private void loadSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getUrl = new urlDialogue();
            getUrl.Show();
            

        }

        private void displayPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            url = url + getUrl.GetPageLink();
            // Loads the contents of the web site as per url and displays the elements.
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();
            // Extract the header
            extractHeader(sr);

        }

        private void extractHeader(StreamReader sr)
        {
            
            
        }




        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        /*
         * Select and HTML document to open 
         * 
         */
        private void selectHTMLDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            htmldoc = openFileDialog1.FileName;

            // Open the file and process
           
            using (StreamReader sr2 = new StreamReader(htmldoc))
            {
                char[] c = null;
                char[,] resHTML = new char[10,255];
                char[,] results = new char[50,1024];
                int i = 0;   // Character counter
                int l = 0;   // Line counter
                int p = 0;   // File positional counter

                while (sr2.Peek() >= 0)
                {
                    c = new char[1];
                    sr2.Read(c,0,1);
                    p += 1;
                     if (c[0] == '<')   // Save the character and read till next '>'
                    {
                        resHTML[l, i] = c[0];
                        i += 1;
                        while ((sr2.Peek() >= 0) && c[0] != '>')
                        {
                            c = new char[1];
                            sr2.Read(c, 0, 1);
                            resHTML[l,i] = c[0];
                            i += 1;
                        }               // We have reached the character '>'
                        // increment the line counter - l and reset character counter - i
                        l += 1;
                        i = 0;
                    }
                        Console.WriteLine(c);

                }
                MessageBox.Show("File to be opened: ");
            }





        }

        private string GetHtmlSection(string str)
        {



            return "Replace";

        }
    }
}
