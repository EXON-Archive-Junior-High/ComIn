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
            this.Name_Label = new System.Windows.Forms.Label();
            this.Type_Label = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.Label();
            this.Text2 = new System.Windows.Forms.Label();
            this.Text3 = new System.Windows.Forms.Label();
            this.Text4 = new System.Windows.Forms.Label();
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
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name_Label.Location = new System.Drawing.Point(189, 17);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(58, 21);
            this.Name_Label.TabIndex = 3;
            this.Name_Label.Text = "Name";
            this.Name_Label.Click += new System.EventHandler(this.CPU_Name_Button_Click);
            // 
            // Type_Label
            // 
            this.Type_Label.AutoSize = true;
            this.Type_Label.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Type_Label.Location = new System.Drawing.Point(119, 12);
            this.Type_Label.Name = "Type_Label";
            this.Type_Label.Size = new System.Drawing.Size(73, 27);
            this.Type_Label.TabIndex = 4;
            this.Type_Label.Text = "Type";
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Text1.Location = new System.Drawing.Point(122, 48);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(103, 19);
            this.Text1.TabIndex = 5;
            this.Text1.Text = "CPU_Speed";
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Text2.Location = new System.Drawing.Point(122, 74);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(139, 19);
            this.Text2.TabIndex = 6;
            this.Text2.Text = "CPU_CoreCount";
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Text3.Location = new System.Drawing.Point(122, 100);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(165, 19);
            this.Text3.TabIndex = 7;
            this.Text3.Text = "CPU_Thread_Count";
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Text4.Location = new System.Drawing.Point(122, 126);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(112, 19);
            this.Text4.TabIndex = 8;
            this.Text4.Text = "CPU_Voltage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Type_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.RAM_Button);
            this.Controls.Add(this.GPU_Button);
            this.Controls.Add(this.CPU_Button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CPU_Button;
        private System.Windows.Forms.Button GPU_Button;
        private System.Windows.Forms.Button RAM_Button;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Type_Label;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.Label Text4;
    }
}

