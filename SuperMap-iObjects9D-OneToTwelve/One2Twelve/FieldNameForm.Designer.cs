namespace One2Twelve
{
    partial class FieldNameForm
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
            this.confirmName_Button = new System.Windows.Forms.Button();
            this.FieldName_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // confirmName_Button
            // 
            this.confirmName_Button.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.confirmName_Button.Enabled = false;
            this.confirmName_Button.Location = new System.Drawing.Point(176, 139);
            this.confirmName_Button.Name = "confirmName_Button";
            this.confirmName_Button.Size = new System.Drawing.Size(75, 23);
            this.confirmName_Button.TabIndex = 8;
            this.confirmName_Button.Text = "确认";
            this.confirmName_Button.UseVisualStyleBackColor = true;
            this.confirmName_Button.Click += new System.EventHandler(this.confirmName_Button_Click);
            // 
            // FieldName_textbox
            // 
            this.FieldName_textbox.Location = new System.Drawing.Point(64, 83);
            this.FieldName_textbox.Name = "FieldName_textbox";
            this.FieldName_textbox.Size = new System.Drawing.Size(132, 25);
            this.FieldName_textbox.TabIndex = 7;
            this.FieldName_textbox.TextChanged += new System.EventHandler(this.FieldName_textbox_TextChanged);
            this.FieldName_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FieldName_textbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "请输入新建字段名";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "16位整型",
            "32位整型",
            "64位整型",
            "双精度",
            "单精度",
            "文本型",
            "宽字符",
            "字符型",
            "布尔",
            "日期",
            "字节",
            "二进制型"});
            this.comboBox1.Location = new System.Drawing.Point(249, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FieldNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 190);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.confirmName_Button);
            this.Controls.Add(this.FieldName_textbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FieldNameForm";
            this.Text = "FieldNameForm";
            this.Load += new System.EventHandler(this.FieldNameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmName_Button;
        private System.Windows.Forms.TextBox FieldName_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}