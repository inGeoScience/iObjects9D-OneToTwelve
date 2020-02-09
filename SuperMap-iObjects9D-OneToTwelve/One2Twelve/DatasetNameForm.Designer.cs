namespace One2Twelve
{
    partial class DatasetNameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.DatasetName_textbox = new System.Windows.Forms.TextBox();
            this.confirmName_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入新建数据集名";
            // 
            // DatasetName_textbox
            // 
            this.DatasetName_textbox.Location = new System.Drawing.Point(87, 82);
            this.DatasetName_textbox.Name = "DatasetName_textbox";
            this.DatasetName_textbox.Size = new System.Drawing.Size(271, 25);
            this.DatasetName_textbox.TabIndex = 1;
            this.DatasetName_textbox.TextChanged += new System.EventHandler(this.DatasetName_textbox_TextChanged);
            this.DatasetName_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DatasetName_textbox_KeyPress);
            // 
            // confirmName_Button
            // 
            this.confirmName_Button.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.confirmName_Button.Enabled = false;
            this.confirmName_Button.Location = new System.Drawing.Point(186, 136);
            this.confirmName_Button.Name = "confirmName_Button";
            this.confirmName_Button.Size = new System.Drawing.Size(75, 23);
            this.confirmName_Button.TabIndex = 2;
            this.confirmName_Button.Text = "确认";
            this.confirmName_Button.UseVisualStyleBackColor = true;
            this.confirmName_Button.Click += new System.EventHandler(this.confirmName_Button_Click);
            // 
            // DatasetNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 190);
            this.Controls.Add(this.confirmName_Button);
            this.Controls.Add(this.DatasetName_textbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DatasetNameForm";
            this.Text = "DatasetNameForm";
            this.Load += new System.EventHandler(this.DatasetNameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DatasetName_textbox;
        private System.Windows.Forms.Button confirmName_Button;
    }
}