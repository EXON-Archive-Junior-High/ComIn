namespace ComIn1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.CPU_Button = new System.Windows.Forms.Button();
            this.GPU_Button = new System.Windows.Forms.Button();
            this.RAM_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CPU_Button
            // 
            this.CPU_Button.Location = new System.Drawing.Point(12, 12);
            this.CPU_Button.Name = "CPU_Button";
            this.CPU_Button.Size = new System.Drawing.Size(101, 65);
            this.CPU_Button.TabIndex = 0;
            this.CPU_Button.Text = "CPU";
            this.CPU_Button.UseVisualStyleBackColor = true;
            this.CPU_Button.Click += new System.EventHandler(this.CPU_Button_Click);
            // 
            // GPU_Button
            // 
            this.GPU_Button.Location = new System.Drawing.Point(12, 83);
            this.GPU_Button.Name = "GPU_Button";
            this.GPU_Button.Size = new System.Drawing.Size(101, 65);
            this.GPU_Button.TabIndex = 1;
            this.GPU_Button.Text = "GPU";
            this.GPU_Button.UseVisualStyleBackColor = true;
            this.GPU_Button.Click += new System.EventHandler(this.GPU_Button_Click);
            // 
            // RAM_Button
            // 
            this.RAM_Button.Location = new System.Drawing.Point(12, 154);
            this.RAM_Button.Name = "RAM_Button";
            this.RAM_Button.Size = new System.Drawing.Size(101, 65);
            this.RAM_Button.TabIndex = 2;
            this.RAM_Button.Text = "RAM";
            this.RAM_Button.UseVisualStyleBackColor = true;
            this.RAM_Button.Click += new System.EventHandler(this.RAM_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RAM_Button);
            this.Controls.Add(this.GPU_Button);
            this.Controls.Add(this.CPU_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CPU_Button;
        private System.Windows.Forms.Button GPU_Button;
        private System.Windows.Forms.Button RAM_Button;
    }
}

