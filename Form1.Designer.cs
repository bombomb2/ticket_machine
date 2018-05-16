namespace test
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
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.page_auditorium1 = new test.page_auditorium();
            this.page11 = new test.page1();
            this.page21 = new test.page2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(723, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 442);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // page_auditorium1
            // 
            this.page_auditorium1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.page_auditorium1.Location = new System.Drawing.Point(0, 38);
            this.page_auditorium1.Name = "page_auditorium1";
            this.page_auditorium1.Size = new System.Drawing.Size(762, 435);
            this.page_auditorium1.TabIndex = 10;
            this.page_auditorium1.VisibleChanged += new System.EventHandler(this.visiblechange);
            // 
            // page11
            // 
            this.page11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.page11.Location = new System.Drawing.Point(-3, 47);
            this.page11.Name = "page11";
            this.page11.Size = new System.Drawing.Size(762, 390);
            this.page11.TabIndex = 8;          
            // 
            // page21
            // 
            this.page21.BackColor = System.Drawing.SystemColors.ControlDark;
            this.page21.Location = new System.Drawing.Point(-2, 38);
            this.page21.Name = "page21";
            this.page21.Size = new System.Drawing.Size(762, 397);
            this.page21.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(760, 437);
            this.Controls.Add(this.page_auditorium1);
            this.Controls.Add(this.page11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.page21);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";            
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private page2 page21;
        private page1 page11;
        private page_auditorium page_auditorium1;        
    }
}

