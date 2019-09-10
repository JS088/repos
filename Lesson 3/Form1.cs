using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_3
{
    public partial class txtInput2 : Form
    {
        public txtInput2()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void IblOutput_Click(object sender, EventArgs e)
        {

        }

        private void TxtInput2_Load(object sender, EventArgs e)
        {


        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
           
        }

        private void TxtInput_TextChanged_1(object sender, EventArgs e)
        {
            //  lblOutput.Text = 'Hello World";
            lblOutput.Text = txtInput.Text.Text;
            lbxOutput.Items.Add(txtInput.Text);
        }
    }
}