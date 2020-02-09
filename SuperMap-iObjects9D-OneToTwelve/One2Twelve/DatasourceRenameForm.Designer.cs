namespace One2Twelve
{
    partial class DatasourceRenameForm
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
            this.RenameDatasource_Textbox = new System.Windows.Forms.TextBox();
            this.RenameconFirm_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入新的别名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RenameDatasource_Textbox
            // 
            this.RenameDatasource_Textbox.Location = new System.Drawing.Point(104, 80);
            this.RenameDatasource_Textbox.Name = "RenameDatasource_Textbox";
            this.RenameDatasource_Textbox.Size = new System.Drawing.Size(229, 25);
            this.RenameDatasource_Textbox.TabIndex = 1;
            this.RenameDatasource_Textbox.TextChanged += new System.EventHandler(this.RenameDatasource_Textbox_TextChanged);
            // 
            // RenameconFirm_button
            // 
            this.RenameconFirm_button.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.RenameconFirm_button.Location = new System.Drawing.Point(180, 135);
            this.RenameconFirm_button.Name = "RenameconFirm_button";
            this.RenameconFirm_button.Size = new System.Drawing.Size(75, 23);
            this.RenameconFirm_button.TabIndex = 2;
            this.RenameconFirm_button.Text = "确认";
            this.RenameconFirm_button.UseVisualStyleBackColor = true;
            this.RenameconFirm_button.Click += new System.EventHandler(this.RenameconFirm_button_Click);
            // 
            // DatasourceRenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 190);
            this.Controls.Add(this.RenameconFirm_button);
            this.Controls.Add(this.RenameDatasource_Textbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DatasourceRenameForm";
            this.Text = "RenameDatasourceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RenameDatasource_Textbox;
        private System.Windows.Forms.Button RenameconFirm_button;
    }
}