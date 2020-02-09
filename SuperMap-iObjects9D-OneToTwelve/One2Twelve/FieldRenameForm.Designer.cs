namespace One2Twelve
{
    partial class FieldRenameForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.confirmName_Button = new System.Windows.Forms.Button();
            this.NewName_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // confirmName_Button
            // 
            this.confirmName_Button.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.confirmName_Button.Enabled = false;
            this.confirmName_Button.Location = new System.Drawing.Point(176, 135);
            this.confirmName_Button.Name = "confirmName_Button";
            this.confirmName_Button.Size = new System.Drawing.Size(75, 23);
            this.confirmName_Button.TabIndex = 12;
            this.confirmName_Button.Text = "确认";
            this.confirmName_Button.UseVisualStyleBackColor = true;
            this.confirmName_Button.Click += new System.EventHandler(this.confirmName_Button_Click);
            // 
            // NewName_textbox
            // 
            this.NewName_textbox.Location = new System.Drawing.Point(64, 79);
            this.NewName_textbox.Name = "NewName_textbox";
            this.NewName_textbox.Size = new System.Drawing.Size(132, 25);
            this.NewName_textbox.TabIndex = 11;
            this.NewName_textbox.TextChanged += new System.EventHandler(this.NewName_textbox_TextChanged);
            this.NewName_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewName_textbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "新的名字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "待重命名字段";
            // 
            // FieldRenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 190);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.confirmName_Button);
            this.Controls.Add(this.NewName_textbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FieldRenameForm";
            this.Text = "FieldRenameForm";
            this.Load += new System.EventHandler(this.FieldRenameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button confirmName_Button;
        private System.Windows.Forms.TextBox NewName_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}