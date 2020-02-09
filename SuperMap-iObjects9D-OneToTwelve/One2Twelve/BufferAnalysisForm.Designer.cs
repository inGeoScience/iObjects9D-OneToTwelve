namespace One2Twelve
{
    partial class BufferAnalysisForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmBuffer_button = new System.Windows.Forms.Button();
            this.leftDistance_Textbox = new System.Windows.Forms.TextBox();
            this.rightDistance_Textbox = new System.Windows.Forms.TextBox();
            this.bufferRadius_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datasetName_Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "点缓冲分析半径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "线缓冲分析右缓冲区距离";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "线缓冲分析左缓冲区距离";
            // 
            // confirmBuffer_button
            // 
            this.confirmBuffer_button.Location = new System.Drawing.Point(177, 155);
            this.confirmBuffer_button.Name = "confirmBuffer_button";
            this.confirmBuffer_button.Size = new System.Drawing.Size(75, 23);
            this.confirmBuffer_button.TabIndex = 3;
            this.confirmBuffer_button.Text = "确认";
            this.confirmBuffer_button.UseVisualStyleBackColor = true;
            this.confirmBuffer_button.Click += new System.EventHandler(this.confirmBuffer_button_Click);
            // 
            // leftDistance_Textbox
            // 
            this.leftDistance_Textbox.Location = new System.Drawing.Point(250, 12);
            this.leftDistance_Textbox.Name = "leftDistance_Textbox";
            this.leftDistance_Textbox.Size = new System.Drawing.Size(122, 25);
            this.leftDistance_Textbox.TabIndex = 4;
            // 
            // rightDistance_Textbox
            // 
            this.rightDistance_Textbox.Location = new System.Drawing.Point(250, 47);
            this.rightDistance_Textbox.Name = "rightDistance_Textbox";
            this.rightDistance_Textbox.Size = new System.Drawing.Size(122, 25);
            this.rightDistance_Textbox.TabIndex = 5;
            // 
            // bufferRadius_Textbox
            // 
            this.bufferRadius_Textbox.Location = new System.Drawing.Point(250, 84);
            this.bufferRadius_Textbox.Name = "bufferRadius_Textbox";
            this.bufferRadius_Textbox.Size = new System.Drawing.Size(122, 25);
            this.bufferRadius_Textbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "分析结果数据集名";
            // 
            // datasetName_Textbox
            // 
            this.datasetName_Textbox.Location = new System.Drawing.Point(250, 120);
            this.datasetName_Textbox.Name = "datasetName_Textbox";
            this.datasetName_Textbox.Size = new System.Drawing.Size(122, 25);
            this.datasetName_Textbox.TabIndex = 8;
            this.datasetName_Textbox.TextChanged += new System.EventHandler(this.datasetName_Textbox_TextChanged);
            // 
            // BufferAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 190);
            this.Controls.Add(this.datasetName_Textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bufferRadius_Textbox);
            this.Controls.Add(this.rightDistance_Textbox);
            this.Controls.Add(this.leftDistance_Textbox);
            this.Controls.Add(this.confirmBuffer_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BufferAnalysisForm";
            this.Text = "BufferAnalysisForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirmBuffer_button;
        private System.Windows.Forms.TextBox leftDistance_Textbox;
        private System.Windows.Forms.TextBox rightDistance_Textbox;
        private System.Windows.Forms.TextBox bufferRadius_Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox datasetName_Textbox;
    }
}