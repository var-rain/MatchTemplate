namespace MatchTemplate
{
    partial class MainFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.selectSourceBut = new System.Windows.Forms.Button();
            this.selectTemplateBut = new System.Windows.Forms.Button();
            this.startBut = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectSourceBut
            // 
            this.selectSourceBut.Location = new System.Drawing.Point(13, 13);
            this.selectSourceBut.Name = "selectSourceBut";
            this.selectSourceBut.Size = new System.Drawing.Size(75, 23);
            this.selectSourceBut.TabIndex = 0;
            this.selectSourceBut.Text = "选择原图";
            this.selectSourceBut.UseVisualStyleBackColor = true;
            this.selectSourceBut.Click += new System.EventHandler(this.selectSourceBut_Click);
            // 
            // selectTemplateBut
            // 
            this.selectTemplateBut.Location = new System.Drawing.Point(13, 43);
            this.selectTemplateBut.Name = "selectTemplateBut";
            this.selectTemplateBut.Size = new System.Drawing.Size(75, 23);
            this.selectTemplateBut.TabIndex = 1;
            this.selectTemplateBut.Text = "选择模板";
            this.selectTemplateBut.UseVisualStyleBackColor = true;
            this.selectTemplateBut.Click += new System.EventHandler(this.selectTemplateBut_Click);
            // 
            // startBut
            // 
            this.startBut.Location = new System.Drawing.Point(13, 73);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(75, 23);
            this.startBut.TabIndex = 2;
            this.startBut.Text = "开始匹配";
            this.startBut.UseVisualStyleBackColor = true;
            this.startBut.Click += new System.EventHandler(this.startBut_Click);
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(94, 78);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(71, 12);
            this.resultText.TabIndex = 3;
            this.resultText.Text = "调用信息 : ";
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.startBut);
            this.Controls.Add(this.selectTemplateBut);
            this.Controls.Add(this.selectSourceBut);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrom";
            this.Text = "模板匹配图像识别";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectSourceBut;
        private System.Windows.Forms.Button selectTemplateBut;
        private System.Windows.Forms.Button startBut;
        private System.Windows.Forms.Label resultText;
    }
}

