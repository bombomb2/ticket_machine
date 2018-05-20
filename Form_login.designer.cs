namespace ticket
{
    partial class Form_login
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
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_pw = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_nobuy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_findpw = new System.Windows.Forms.Button();
            this.button_findid = new System.Windows.Forms.Button();
            this.button_signin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_id
            // 
            this.text_id.BackColor = System.Drawing.SystemColors.Control;
            this.text_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_id.Font = new System.Drawing.Font("굴림", 20F);
            this.text_id.Location = new System.Drawing.Point(80, 78);
            this.text_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(392, 31);
            this.text_id.TabIndex = 3;
            // 
            // text_pw
            // 
            this.text_pw.BackColor = System.Drawing.SystemColors.Control;
            this.text_pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_pw.Font = new System.Drawing.Font("굴림", 20F);
            this.text_pw.Location = new System.Drawing.Point(80, 114);
            this.text_pw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_pw.Name = "text_pw";
            this.text_pw.PasswordChar = '*';
            this.text_pw.Size = new System.Drawing.Size(392, 31);
            this.text_pw.TabIndex = 3;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Red;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Location = new System.Drawing.Point(79, 155);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(396, 34);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "로그인";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_Click);
            // 
            // button_nobuy
            // 
            this.button_nobuy.Location = new System.Drawing.Point(350, 250);
            this.button_nobuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_nobuy.Name = "button_nobuy";
            this.button_nobuy.Size = new System.Drawing.Size(140, 31);
            this.button_nobuy.TabIndex = 6;
            this.button_nobuy.Text = "비회원 예매 확인";
            this.button_nobuy.UseVisualStyleBackColor = true;
            this.button_nobuy.Click += new System.EventHandler(this.button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "비회원 예매시, 이벤트 포인트 등의 혜택을";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "받으실 수 없습니다.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(383, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "---------------------------------------------------------------";
            // 
            // button_findpw
            // 
            this.button_findpw.Location = new System.Drawing.Point(219, 194);
            this.button_findpw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_findpw.Name = "button_findpw";
            this.button_findpw.Size = new System.Drawing.Size(104, 31);
            this.button_findpw.TabIndex = 11;
            this.button_findpw.Text = "비밀번호 찾기";
            this.button_findpw.UseVisualStyleBackColor = true;
            this.button_findpw.Click += new System.EventHandler(this.button_Click);
            // 
            // button_findid
            // 
            this.button_findid.Location = new System.Drawing.Point(80, 194);
            this.button_findid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_findid.Name = "button_findid";
            this.button_findid.Size = new System.Drawing.Size(104, 31);
            this.button_findid.TabIndex = 12;
            this.button_findid.Text = "아이디 찾기";
            this.button_findid.UseVisualStyleBackColor = true;
            this.button_findid.Click += new System.EventHandler(this.button_Click);
            // 
            // button_signin
            // 
            this.button_signin.Location = new System.Drawing.Point(368, 194);
            this.button_signin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(104, 31);
            this.button_signin.TabIndex = 13;
            this.button_signin.Text = "회원가입";
            this.button_signin.UseVisualStyleBackColor = true;
            this.button_signin.Click += new System.EventHandler(this.button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(579, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 16;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(968, 415);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 18);
            this.button6.TabIndex = 28;
            this.button6.Text = "다음";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(424, 327);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 24);
            this.button7.TabIndex = 40;
            this.button7.Text = "취소";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(564, 391);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_signin);
            this.Controls.Add(this.button_findid);
            this.Controls.Add(this.button_findpw);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_nobuy);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.text_pw);
            this.Controls.Add(this.text_id);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_pw;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_nobuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_findpw;
        private System.Windows.Forms.Button button_findid;
        private System.Windows.Forms.Button button_signin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

