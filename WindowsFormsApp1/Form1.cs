using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ConvertManager convertManager = new ConvertManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string text = Convert.ToString(rtxtInput.Text);
            char[] list = text.ToLower().ToCharArray();
            rtxtOuput.Text = convertManager.convertTo("piglin", list);
        }
    }
}
