namespace One2Twelve
{
    partial class DeleteFieldForm
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
            this.confirmDelete_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fieldDelete_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // confirmDelete_Button
            // 
            this.confirmDelete_Button.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.confirmDelete_Button.Enabled = false;
            this.confirmDelete_Button.Location = new System.Drawing.Point(181, 135);
            this.confirmDelete_Button.Name = "confirmDelete_Button";
            this.confirmDelete_Button.Size = new System.Drawing.Size(75, 23);
            this.confirmDelete_Button.TabIndex = 8;
            this.confirmDelete_Button.Text = "删除";
            this.confirmDelete_Button.UseVisualStyleBackColor = true;
            this.confirmDelete_Button.Click += new System.EventHandler(this.confirmDelete_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "请选择字段";
            // 
            // fieldDelete_comboBox
            // 
            this.fieldDelete_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldDelete_comboBox.FormattingEnabled = true;
            this.fieldDelete_comboBox.Location = new System.Drawing.Point(113, 79);
            this.fieldDelete_comboBox.Name = "fieldDelete_comboBox";
            this.fieldDelete_comboBox.Size = new System.Drawing.Size(202, 23);
            this.fieldDelete_comboBox.TabIndex = 9;
            this.fieldDelete_comboBox.SelectedIndexChanged += new System.EventHandler(this.fieldDelete_comboBox_SelectedIndexChanged);
            // 
            // DeleteFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 190);
            this.Controls.Add(this.fieldDelete_comboBox);
            this.Controls.Add(this.confirmDelete_Button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DeleteFieldForm";
            this.Text = "DeleteFieldForm";
            this.Load += new System.EventHandler(this.DeleteFieldForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmDelete_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fieldDelete_comboBox;

    }
}