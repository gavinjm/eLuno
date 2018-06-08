using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLuno
{
    public partial class urlDialogue : Form
    {
        string url;

        public urlDialogue()
        {
            InitializeComponent();
            url = "";
        }

        public string GetPageLink()
        {
            return url;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            url = this.textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
