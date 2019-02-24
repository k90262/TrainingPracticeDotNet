namespace PinBall
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.brick16 = new PinBall.Brick();
            this.ball6 = new PinBall.Ball();
            this.brick11 = new PinBall.Brick();
            this.brick12 = new PinBall.Brick();
            this.brick13 = new PinBall.Brick();
            this.brick14 = new PinBall.Brick();
            this.brick15 = new PinBall.Brick();
            this.brick6 = new PinBall.Brick();
            this.brick7 = new PinBall.Brick();
            this.brick8 = new PinBall.Brick();
            this.brick9 = new PinBall.Brick();
            this.brick10 = new PinBall.Brick();
            this.brick5 = new PinBall.Brick();
            this.brick4 = new PinBall.Brick();
            this.brick3 = new PinBall.Brick();
            this.brick2 = new PinBall.Brick();
            this.bat1 = new PinBall.Bat();
            this.brick1 = new PinBall.Brick();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // brick16
            // 
            this.brick16.Location = new System.Drawing.Point(484, 45);
            this.brick16.Name = "brick16";
            this.brick16.Size = new System.Drawing.Size(75, 23);
            this.brick16.Status = PinBall.BrickStatus.Floating;
            this.brick16.TabIndex = 22;
            this.brick16.UseVisualStyleBackColor = true;
            // 
            // ball6
            // 
            this.ball6.AutoSize = true;
            this.ball6.Checked = true;
            this.ball6.Location = new System.Drawing.Point(165, 235);
            this.ball6.Name = "ball6";
            this.ball6.Size = new System.Drawing.Size(14, 13);
            this.ball6.TabIndex = 21;
            this.ball6.TabStop = true;
            this.ball6.UseVisualStyleBackColor = true;
            // 
            // brick11
            // 
            this.brick11.Location = new System.Drawing.Point(327, 60);
            this.brick11.Name = "brick11";
            this.brick11.Size = new System.Drawing.Size(75, 23);
            this.brick11.Status = PinBall.BrickStatus.Normal;
            this.brick11.TabIndex = 16;
            this.brick11.UseVisualStyleBackColor = true;
            // 
            // brick12
            // 
            this.brick12.Location = new System.Drawing.Point(246, 60);
            this.brick12.Name = "brick12";
            this.brick12.Size = new System.Drawing.Size(75, 23);
            this.brick12.Status = PinBall.BrickStatus.Normal;
            this.brick12.TabIndex = 15;
            this.brick12.UseVisualStyleBackColor = true;
            // 
            // brick13
            // 
            this.brick13.Location = new System.Drawing.Point(165, 60);
            this.brick13.Name = "brick13";
            this.brick13.Size = new System.Drawing.Size(75, 23);
            this.brick13.Status = PinBall.BrickStatus.Normal;
            this.brick13.TabIndex = 14;
            this.brick13.UseVisualStyleBackColor = true;
            // 
            // brick14
            // 
            this.brick14.Location = new System.Drawing.Point(84, 60);
            this.brick14.Name = "brick14";
            this.brick14.Size = new System.Drawing.Size(75, 23);
            this.brick14.Status = PinBall.BrickStatus.Normal;
            this.brick14.TabIndex = 13;
            this.brick14.UseVisualStyleBackColor = true;
            // 
            // brick15
            // 
            this.brick15.Location = new System.Drawing.Point(3, 60);
            this.brick15.Name = "brick15";
            this.brick15.Size = new System.Drawing.Size(75, 23);
            this.brick15.Status = PinBall.BrickStatus.Normal;
            this.brick15.TabIndex = 12;
            this.brick15.UseVisualStyleBackColor = true;
            // 
            // brick6
            // 
            this.brick6.Location = new System.Drawing.Point(327, 31);
            this.brick6.Name = "brick6";
            this.brick6.Size = new System.Drawing.Size(75, 23);
            this.brick6.Status = PinBall.BrickStatus.Normal;
            this.brick6.TabIndex = 11;
            this.brick6.UseVisualStyleBackColor = true;
            // 
            // brick7
            // 
            this.brick7.Location = new System.Drawing.Point(246, 31);
            this.brick7.Name = "brick7";
            this.brick7.Size = new System.Drawing.Size(75, 23);
            this.brick7.Status = PinBall.BrickStatus.Normal;
            this.brick7.TabIndex = 10;
            this.brick7.UseVisualStyleBackColor = true;
            // 
            // brick8
            // 
            this.brick8.Location = new System.Drawing.Point(165, 31);
            this.brick8.Name = "brick8";
            this.brick8.Size = new System.Drawing.Size(75, 23);
            this.brick8.Status = PinBall.BrickStatus.Normal;
            this.brick8.TabIndex = 9;
            this.brick8.UseVisualStyleBackColor = true;
            // 
            // brick9
            // 
            this.brick9.Location = new System.Drawing.Point(84, 31);
            this.brick9.Name = "brick9";
            this.brick9.Size = new System.Drawing.Size(75, 23);
            this.brick9.Status = PinBall.BrickStatus.Normal;
            this.brick9.TabIndex = 8;
            this.brick9.UseVisualStyleBackColor = true;
            // 
            // brick10
            // 
            this.brick10.Location = new System.Drawing.Point(3, 31);
            this.brick10.Name = "brick10";
            this.brick10.Size = new System.Drawing.Size(75, 23);
            this.brick10.Status = PinBall.BrickStatus.Normal;
            this.brick10.TabIndex = 7;
            this.brick10.UseVisualStyleBackColor = true;
            // 
            // brick5
            // 
            this.brick5.Location = new System.Drawing.Point(327, 2);
            this.brick5.Name = "brick5";
            this.brick5.Size = new System.Drawing.Size(75, 23);
            this.brick5.Status = PinBall.BrickStatus.Normal;
            this.brick5.TabIndex = 6;
            this.brick5.UseVisualStyleBackColor = true;
            // 
            // brick4
            // 
            this.brick4.Location = new System.Drawing.Point(246, 2);
            this.brick4.Name = "brick4";
            this.brick4.Size = new System.Drawing.Size(75, 23);
            this.brick4.Status = PinBall.BrickStatus.Normal;
            this.brick4.TabIndex = 5;
            this.brick4.UseVisualStyleBackColor = true;
            // 
            // brick3
            // 
            this.brick3.Location = new System.Drawing.Point(165, 2);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(75, 23);
            this.brick3.Status = PinBall.BrickStatus.Normal;
            this.brick3.TabIndex = 4;
            this.brick3.UseVisualStyleBackColor = true;
            // 
            // brick2
            // 
            this.brick2.Location = new System.Drawing.Point(84, 2);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(75, 23);
            this.brick2.Status = PinBall.BrickStatus.Normal;
            this.brick2.TabIndex = 3;
            this.brick2.UseVisualStyleBackColor = true;
            // 
            // bat1
            // 
            this.bat1.Location = new System.Drawing.Point(119, 308);
            this.bat1.Name = "bat1";
            this.bat1.Size = new System.Drawing.Size(156, 23);
            this.bat1.TabIndex = 2;
            this.bat1.UseVisualStyleBackColor = true;
            // 
            // brick1
            // 
            this.brick1.Location = new System.Drawing.Point(3, 2);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(75, 23);
            this.brick1.Status = PinBall.BrickStatus.Normal;
            this.brick1.TabIndex = 0;
            this.brick1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 364);
            this.Controls.Add(this.brick16);
            this.Controls.Add(this.ball6);
            this.Controls.Add(this.brick11);
            this.Controls.Add(this.brick12);
            this.Controls.Add(this.brick13);
            this.Controls.Add(this.brick14);
            this.Controls.Add(this.brick15);
            this.Controls.Add(this.brick6);
            this.Controls.Add(this.brick7);
            this.Controls.Add(this.brick8);
            this.Controls.Add(this.brick9);
            this.Controls.Add(this.brick10);
            this.Controls.Add(this.brick5);
            this.Controls.Add(this.brick4);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.bat1);
            this.Controls.Add(this.brick1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Brick brick1;
        private Bat bat1;
        private Brick brick2;
        private Brick brick3;
        private Brick brick4;
        private Brick brick5;
        private Brick brick6;
        private Brick brick7;
        private Brick brick8;
        private Brick brick9;
        private Brick brick10;
        private Brick brick11;
        private Brick brick12;
        private Brick brick13;
        private Brick brick14;
        private Brick brick15;
        private Ball ball6;
        private Brick brick16;
    }
}

