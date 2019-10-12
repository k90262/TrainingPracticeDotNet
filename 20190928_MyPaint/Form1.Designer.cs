namespace MyPaint
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.radLine = new System.Windows.Forms.RadioButton();
            this.radEllipse = new System.Windows.Forms.RadioButton();
            this.radRectangle = new System.Windows.Forms.RadioButton();
            this.radCrossRectangle = new System.Windows.Forms.RadioButton();
            this.radAim = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radLine
            // 
            this.radLine.AutoSize = true;
            this.radLine.Location = new System.Drawing.Point(39, 29);
            this.radLine.Name = "radLine";
            this.radLine.Size = new System.Drawing.Size(47, 16);
            this.radLine.TabIndex = 1;
            this.radLine.TabStop = true;
            this.radLine.Text = "畫線";
            this.radLine.UseVisualStyleBackColor = true;
            this.radLine.Click += new System.EventHandler(this.radLine_Click);
            // 
            // radEllipse
            // 
            this.radEllipse.AutoSize = true;
            this.radEllipse.Location = new System.Drawing.Point(39, 65);
            this.radEllipse.Name = "radEllipse";
            this.radEllipse.Size = new System.Drawing.Size(59, 16);
            this.radEllipse.TabIndex = 2;
            this.radEllipse.TabStop = true;
            this.radEllipse.Text = "畫橢圓";
            this.radEllipse.UseVisualStyleBackColor = true;
            this.radEllipse.Click += new System.EventHandler(this.radEllipse_Click);
            // 
            // radRectangle
            // 
            this.radRectangle.AutoSize = true;
            this.radRectangle.Location = new System.Drawing.Point(39, 103);
            this.radRectangle.Name = "radRectangle";
            this.radRectangle.Size = new System.Drawing.Size(59, 16);
            this.radRectangle.TabIndex = 3;
            this.radRectangle.TabStop = true;
            this.radRectangle.Text = "畫矩形";
            this.radRectangle.UseVisualStyleBackColor = true;
            this.radRectangle.Click += new System.EventHandler(this.radRectangle_Click);
            // 
            // radCrossRectangle
            // 
            this.radCrossRectangle.AutoSize = true;
            this.radCrossRectangle.Location = new System.Drawing.Point(39, 147);
            this.radCrossRectangle.Name = "radCrossRectangle";
            this.radCrossRectangle.Size = new System.Drawing.Size(83, 16);
            this.radCrossRectangle.TabIndex = 4;
            this.radCrossRectangle.TabStop = true;
            this.radCrossRectangle.Text = "畫叉叉矩形";
            this.radCrossRectangle.UseVisualStyleBackColor = true;
            this.radCrossRectangle.Click += new System.EventHandler(this.radCrossRectangle_Click);
            // 
            // radAim
            // 
            this.radAim.AutoSize = true;
            this.radAim.Location = new System.Drawing.Point(39, 192);
            this.radAim.Name = "radAim";
            this.radAim.Size = new System.Drawing.Size(59, 16);
            this.radAim.TabIndex = 5;
            this.radAim.TabStop = true;
            this.radAim.Text = "畫準星";
            this.radAim.UseVisualStyleBackColor = true;
            this.radAim.Click += new System.EventHandler(this.radAim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 491);
            this.Controls.Add(this.radAim);
            this.Controls.Add(this.radCrossRectangle);
            this.Controls.Add(this.radRectangle);
            this.Controls.Add(this.radEllipse);
            this.Controls.Add(this.radLine);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radLine;
        private System.Windows.Forms.RadioButton radEllipse;
        private System.Windows.Forms.RadioButton radRectangle;
        private System.Windows.Forms.RadioButton radCrossRectangle;
        private System.Windows.Forms.RadioButton radAim;
    }
}

