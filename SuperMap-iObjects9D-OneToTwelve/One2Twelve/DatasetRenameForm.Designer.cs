namespace One2Twelve
{
    partial class DatasetRenameForm
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
            this.RenameconFirm_button = new System.Windows.Forms.Button();
            this.RenameDataset_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RenameconFirm_button
            // 
            this.RenameconFirm_button.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.RenameconFirm_button.Location = new System.Drawing.Point(179, 135);
            this.RenameconFirm_button.Name = "RenameconFirm_button";
            this.RenameconFirm_button.Size = new System.Drawing.Size(75, 23);
            this.RenameconFirm_button.TabIndex = 5;
            this.RenameconFirm_button.Text = "确认";
            this.RenameconFirm_button.UseVisualStyleBackColor = true;
            this.RenameconFirm_button.Click += new System.EventHandler(this.RenameconFirm_button_Click);
            // 
            // RenameDataset_Textbox
            // 
            this.RenameDataset_Textbox.Location = new System.Drawing.Point(103, 80);
            this.RenameDataset_Textbox.Name = "RenameDataset_Textbox";
            this.RenameDataset_Textbox.Size = new System.Drawing.Size(229, 25);
            this.RenameDataset_Textbox.TabIndex = 4;
            this.RenameDataset_Textbox.TextChanged += new System.EventHandler(this.RenameDataset_Textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入新的别名";
            // 
            // DatasetRenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 190);
            this.Controls.Add(this.RenameconFirm_button);
            this.Controls.Add(this.RenameDataset_Textbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DatasetRenameForm";
            this.Text = "DatasetRenameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RenameconFirm_button;
        private System.Windows.Forms.TextBox RenameDataset_Textbox;
        private System.Windows.Forms.Label label1;
    }
}