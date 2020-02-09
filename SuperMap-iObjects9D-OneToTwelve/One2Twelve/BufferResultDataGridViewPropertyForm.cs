using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMap.Mapping;
using SuperMap.Data;
using SuperMap.UI;

namespace One2Twelve
{
    public partial class BufferResultDataGridViewPropertyForm : Form
    {

        Recordset resultInBuffer = null;

        public BufferResultDataGridViewPropertyForm(Recordset getRs)
        {
            InitializeComponent();
            resultInBuffer = getRs;
            FillTheDataGridView();
        }


        private void FillTheDataGridView()
        {
            for (int i = 0; i < resultInBuffer.FieldCount; i++)
            {
                //定义并获得字段名称
                String fieldName = resultInBuffer.GetFieldInfos()[i].Name;

                //将得到的字段名称添加到dataGridView列中
                bufferResultDatagridView.Columns.Add(fieldName, fieldName);
            }

            //初始化row
            DataGridViewRow row = null;


            //根据选中记录的个数，将选中对象的信息添加到dataGridView中显示
            while (!resultInBuffer.IsEOF)
            {
                row = new DataGridViewRow();
                for (int i = 0; i < resultInBuffer.FieldCount; i++)
                {
                    //定义并获得字段值
                    Object fieldValue = resultInBuffer.GetFieldValue(i);

                    //将字段值添加到dataGridView中对应的位置
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    if (fieldValue != null)
                    {
                        cell.ValueType = fieldValue.GetType();
                        cell.Value = fieldValue;
                    }

                    row.Cells.Add(cell);
                }

                bufferResultDatagridView.Rows.Add(row);

                resultInBuffer.MoveNext();
            }
            bufferResultDatagridView.Update();

            resultInBuffer.Dispose();

        }
    }
}
