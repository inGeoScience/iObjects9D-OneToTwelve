using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One2Twelve
{
    public partial class FieldNameForm : Form
    {
        public FieldNameForm()
        {
            InitializeComponent();
        }

        private void confirmName_Button_Click(object sender, EventArgs e)
        {
            Common.tmpFieldType = comboBox1.Text;
            Common.tmpFieldName = FieldName_textbox.Text;
            this.Close();
            FieldName_textbox.Clear();
        }

        private void FieldName_textbox_TextChanged(object sender, EventArgs e)
        {
            if (FieldName_textbox.Text != "" && comboBox1.Text != "")
            {
                confirmName_Button.Enabled = true;
            }
            else
            {
                confirmName_Button.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FieldNameForm_Load(object sender, EventArgs e)
        {
            FieldName_textbox.Text = Common.tmpFieldName;
        }

        private void FieldNameForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FieldName_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '\b') && (!Char.IsLetter(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
