namespace One2Twelve
{
    partial class BufferResultDataGridViewPropertyForm
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
            this.bufferResultDatagridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bufferResultDatagridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bufferResultDatagridView
            // 
            this.bufferResultDatagridView.BackgroundColor = System.Drawing.Color.White;
            this.bufferResultDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bufferResultDatagridView.Location = new System.Drawing.Point(0, 0);
            this.bufferResultDatagridView.Name = "bufferResultDatagridView";
            this.bufferResultDatagridView.RowTemplate.Height = 27;
            this.bufferResultDatagridView.Size = new System.Drawing.Size(547, 321);
            this.bufferResultDatagridView.TabIndex = 0;
            // 
            // BufferResultDataGridViewPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 321);
            this.Controls.Add(this.bufferResultDatagridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BufferResultDataGridViewPropertyForm";
            this.Text = "BufferResultDataGridViewPropertyForn";
            ((System.ComponentModel.ISupportInitialize)(this.bufferResultDatagridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bufferResultDatagridView;
    }
}