namespace One2Twelve
{
    partial class AttributeProperty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tmpDataGridViewProperty = new System.Windows.Forms.DataGridView();
            this.fieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tmpDataGridViewProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // tmpDataGridViewProperty
            // 
            this.tmpDataGridViewProperty.AllowUserToAddRows = false;
            this.tmpDataGridViewProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tmpDataGridViewProperty.BackgroundColor = System.Drawing.Color.White;
            this.tmpDataGridViewProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tmpDataGridViewProperty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldName,
            this.fieldValue});
            this.tmpDataGridViewProperty.Location = new System.Drawing.Point(-2, 0);
            this.tmpDataGridViewProperty.Margin = new System.Windows.Forms.Padding(4);
            this.tmpDataGridViewProperty.Name = "tmpDataGridViewProperty";
            this.tmpDataGridViewProperty.RowHeadersVisible = false;
            this.tmpDataGridViewProperty.RowTemplate.Height = 23;
            this.tmpDataGridViewProperty.Size = new System.Drawing.Size(549, 281);
            this.tmpDataGridViewProperty.TabIndex = 2;
            // 
            // fieldName
            // 
            this.fieldName.HeaderText = "字段名称";
            this.fieldName.Name = "fieldName";
            this.fieldName.ReadOnly = true;
            this.fieldName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fieldName.Width = 274;
            // 
            // fieldValue
            // 
            this.fieldValue.HeaderText = "字段值";
            this.fieldValue.Name = "fieldValue";
            this.fieldValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fieldValue.Width = 275;
            // 
            // Modify_button
            // 
            this.Modify_button.Location = new System.Drawing.Point(453, 290);
            this.Modify_button.Name = "Modify_button";
            this.Modify_button.Size = new System.Drawing.Size(75, 23);
            this.Modify_button.TabIndex = 3;
            this.Modify_button.Text = "修改";
            this.Modify_button.UseVisualStyleBackColor = true;
            this.Modify_button.Click += new System.EventHandler(this.Modify_button_Click);
            // 
            // AttributeProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 321);
            this.Controls.Add(this.Modify_button);
            this.Controls.Add(this.tmpDataGridViewProperty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AttributeProperty";
            this.Text = "AttributeProperty";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AttributeProperty_FormClosing_1);
            ((System.ComponentModel.ISupportInitialize)(this.tmpDataGridViewProperty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tmpDataGridViewProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldValue;
        private System.Windows.Forms.Button Modify_button;

    }
}