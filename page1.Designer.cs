namespace test
{
    partial class page1
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.test_id = new System.Windows.Forms.Label();
            this.button_join = new System.Windows.Forms.Button();
            this.test_pw = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 435);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "테스트 페이지 2";           
            // 
            // button_login
            // 
            this.button_login.AutoSize = true;
            this.button_login.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_login.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_login.Location = new System.Drawing.Point(541, 125);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(118, 60);
            this.button_login.TabIndex = 1;
            this.button_login.Text = "로그인";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(266, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(266, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.Location = new System.Drawing.Point(270, 150);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(243, 21);
            this.textBox_id.TabIndex = 3;
            // 
            // textBox_pw
            // 
            this.textBox_pw.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_pw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_pw.Location = new System.Drawing.Point(270, 213);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.PasswordChar = '*';
            this.textBox_pw.Size = new System.Drawing.Size(243, 21);
            this.textBox_pw.TabIndex = 3;
            // 
            // test_id
            // 
            this.test_id.AutoSize = true;
            this.test_id.Location = new System.Drawing.Point(268, 292);
            this.test_id.Name = "test_id";
            this.test_id.Size = new System.Drawing.Size(38, 12);
            this.test_id.TabIndex = 4;
            this.test_id.Text = "label5";
            // 
            // button_join
            // 
            this.button_join.AutoSize = true;
            this.button_join.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_join.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_join.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_join.Location = new System.Drawing.Point(541, 207);
            this.button_join.Name = "button_join";
            this.button_join.Size = new System.Drawing.Size(118, 34);
            this.button_join.TabIndex = 1;
            this.button_join.Text = "회원가입";
            this.button_join.UseVisualStyleBackColor = false;
            this.button_join.Click += new System.EventHandler(this.button1_Click);
            // 
            // test_pw
            // 
            this.test_pw.AutoSize = true;
            this.test_pw.Location = new System.Drawing.Point(268, 351);
            this.test_pw.Name = "test_pw";
            this.test_pw.Size = new System.Drawing.Size(38, 12);
            this.test_pw.TabIndex = 4;
            this.test_pw.Text = "label5";
            // 
            // page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.test_pw);
            this.Controls.Add(this.test_id);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.textBox_pw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_join);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.panel1);
            this.Name = "page1";
            this.Size = new System.Drawing.Size(762, 435);            
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.Label test_id;
        private System.Windows.Forms.Button button_join;
        private System.Windows.Forms.Label test_pw;
    }
}
