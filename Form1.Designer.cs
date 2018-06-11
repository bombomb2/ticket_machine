namespace ticket
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
            this.page21 = new ticket.page2();
            this.page_auditorium1 = new ticket.page_auditorium();
            this.page_movie_select1 = new ticket.page_movie_select();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1234, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // page21
            // 
            this.page21.BackColor = System.Drawing.SystemColors.ControlDark;
            this.page21.Location = new System.Drawing.Point(0, 28);
            this.page21.Name = "page21";
            this.page21.Size = new System.Drawing.Size(1268, 680);
            this.page21.TabIndex = 11;
            // 
            // page_auditorium1
            // 
            this.page_auditorium1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.page_auditorium1.Location = new System.Drawing.Point(0, 27);
            this.page_auditorium1.Name = "page_auditorium1";
            this.page_auditorium1.Size = new System.Drawing.Size(1268, 681);
            this.page_auditorium1.TabIndex = 10;
            // 
            // page_movie_select1
            // 
            this.page_movie_select1.Location = new System.Drawing.Point(0, 28);
            this.page_movie_select1.Name = "page_movie_select1";
            this.page_movie_select1.Size = new System.Drawing.Size(1268, 680);
            this.page_movie_select1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.page21);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.page_auditorium1);
            this.Controls.Add(this.page_movie_select1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private page_auditorium page_auditorium1;
        private page2 page21;
        private page_movie_select page_movie_select1;
    }
}

