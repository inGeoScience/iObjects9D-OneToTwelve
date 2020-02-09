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
    public partial class DatasetNameForm : Form
    {

        string tmpDatasourceName;

        public DatasetNameForm()
        {
            InitializeComponent();
        }

        public void Init(string datasourcename)
        {
            tmpDatasourceName = datasourcename;
        }

        private void confirmName_Button_Click(object sender, EventArgs e)
        {
            Common.tmpDatasetName = DatasetName_textbox.Text;

            confirmName_Button.Enabled = false;

            this.Close();
            DatasetName_textbox.Clear();
           
        }

        private void DatasetName_textbox_TextChanged(object sender, EventArgs e)
        {

            if (DatasetName_textbox.Text != "" && !Common.namesOfExistedDatasets.Contains(tmpDatasourceName+"."+DatasetName_textbox.Text) && DatasetName_textbox.Text != "as")
            {
                confirmName_Button.Enabled = true;
            }
            else
            {
                confirmName_Button.Enabled = false;
            }
        }

        private void DatasetNameForm_Load(object sender, EventArgs e)
        {
            DatasetName_textbox.Text = Common.tmpDatasetName;
        }

        private void DatasetNameForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void DatasetName_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '\b') && (!Char.IsLetter(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
