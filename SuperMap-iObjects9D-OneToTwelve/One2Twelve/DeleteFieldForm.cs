using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMap.Data;
using SuperMap.UI;
using SuperMap.Mapping;

namespace One2Twelve
{
    public partial class DeleteFieldForm : Form
    {
        public DeleteFieldForm()
        {
            InitializeComponent();
        }

        private void DeleteFieldForm_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadCombox(List<string> fieldList)
        {
            for (int t = 0; t < fieldList.Count; t++)
            {
                fieldDelete_comboBox.Items.Add(fieldList[t]);
            }
        }

        private void confirmDelete_Button_Click(object sender, EventArgs e)
        {
            Common.tmpFieldDeletingName = fieldDelete_comboBox.Text;
            this.Close();
        }

        private void fieldDelete_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fieldDelete_comboBox.Text != "")
            {
                confirmDelete_Button.Enabled = true;
            }
            else
            {
                confirmDelete_Button.Enabled = false;
            }
        }

        private void DeleteFieldForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
