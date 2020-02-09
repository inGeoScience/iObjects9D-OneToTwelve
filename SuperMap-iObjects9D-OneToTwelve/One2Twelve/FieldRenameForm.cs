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
    public partial class FieldRenameForm : Form
    {
        public FieldRenameForm()
        {
            InitializeComponent();
        }

        private void NewName_textbox_TextChanged(object sender, EventArgs e)
        {
            if (NewName_textbox.Text != "" && comboBox1.Text != "")
            {
                confirmName_Button.Enabled = true;
            }
            else
            {
                confirmName_Button.Enabled = false;
            }
        }

        private void FieldRenameForm_Load(object sender, EventArgs e)
        {

        }

        public void FieldRenameForm_PreLoad(List<string> fieldNameList)
        {
            for (int t = 0; t < fieldNameList.Count; t++)
            {
                comboBox1.Items.Add(fieldNameList[t]);
                
            }
        }

        private void confirmName_Button_Click(object sender, EventArgs e)
        {
            Common.tmpFieldRename = NewName_textbox.Text;
            Common.tmpFieldBeRenamed = comboBox1.Text;
            this.Close();
        }

        private void FieldRenameForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void NewName_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '\b') && (!Char.IsLetter(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
