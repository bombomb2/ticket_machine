namespace ticket
{
    partial class Form_signup
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
            this.components = new System.ComponentModel.Container();
            this.name_txt = new System.Windows.Forms.Label();
            this.name_Box = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.Label();
            this.phone_Box = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.Label();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.Label();
            this.pass_Box = new System.Windows.Forms.TextBox();
            this.check_txt = new System.Windows.Forms.Label();
            this.check_Box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.check_num = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label_check = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.AutoSize = true;
            this.name_txt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_txt.Location = new System.Drawing.Point(54, 24);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(42, 21);
            this.name_txt.TabIndex = 0;
            this.name_txt.Text = "이름";
            // 
            // name_Box
            // 
            this.name_Box.BackColor = System.Drawing.SystemColors.Control;
            this.name_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_Box.Font = new System.Drawing.Font("굴림", 15F);
            this.name_Box.Location = new System.Drawing.Point(171, 23);
            this.name_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(112, 23);
            this.name_Box.TabIndex = 1;
            // 
            // phone_txt
            // 
            this.phone_txt.AutoSize = true;
            this.phone_txt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phone_txt.Location = new System.Drawing.Point(54, 70);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(58, 21);
            this.phone_txt.TabIndex = 0;
            this.phone_txt.Text = "휴대폰";
            // 
            // phone_Box
            // 
            this.phone_Box.BackColor = System.Drawing.SystemColors.Control;
            this.phone_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone_Box.Font = new System.Drawing.Font("굴림", 15F);
            this.phone_Box.Location = new System.Drawing.Point(171, 71);
            this.phone_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_Box.Name = "phone_Box";
            this.phone_Box.Size = new System.Drawing.Size(181, 23);
            this.phone_Box.TabIndex = 2;
            this.phone_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_Box_KeyPress);
            // 
            // id_txt
            // 
            this.id_txt.AutoSize = true;
            this.id_txt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.id_txt.Location = new System.Drawing.Point(54, 179);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(58, 21);
            this.id_txt.TabIndex = 0;
            this.id_txt.Text = "아이디";
            // 
            // ID_Box
            // 
            this.ID_Box.BackColor = System.Drawing.SystemColors.Control;
            this.ID_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID_Box.Font = new System.Drawing.Font("굴림", 15F);
            this.ID_Box.Location = new System.Drawing.Point(171, 183);
            this.ID_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(181, 23);
            this.ID_Box.TabIndex = 3;
            // 
            // pass_txt
            // 
            this.pass_txt.AutoSize = true;
            this.pass_txt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.pass_txt.Location = new System.Drawing.Point(54, 228);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(74, 21);
            this.pass_txt.TabIndex = 0;
            this.pass_txt.Text = "비밀번호";
            // 
            // pass_Box
            // 
            this.pass_Box.BackColor = System.Drawing.SystemColors.Control;
            this.pass_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_Box.Font = new System.Drawing.Font("굴림", 15F);
            this.pass_Box.Location = new System.Drawing.Point(171, 226);
            this.pass_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass_Box.Name = "pass_Box";
            this.pass_Box.PasswordChar = '*';
            this.pass_Box.Size = new System.Drawing.Size(181, 23);
            this.pass_Box.TabIndex = 4;
            // 
            // check_txt
            // 
            this.check_txt.AutoSize = true;
            this.check_txt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.check_txt.Location = new System.Drawing.Point(54, 278);
            this.check_txt.Name = "check_txt";
            this.check_txt.Size = new System.Drawing.Size(112, 21);
            this.check_txt.TabIndex = 0;
            this.check_txt.Text = "비밀번호 확인";
            // 
            // check_Box
            // 
            this.check_Box.BackColor = System.Drawing.SystemColors.Control;
            this.check_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.check_Box.Font = new System.Drawing.Font("굴림", 15F);
            this.check_Box.Location = new System.Drawing.Point(171, 276);
            this.check_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_Box.Name = "check_Box";
            this.check_Box.PasswordChar = '*';
            this.check_Box.Size = new System.Drawing.Size(181, 23);
            this.check_Box.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 20F);
            this.button1.Location = new System.Drawing.Point(152, 327);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "가입하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 181);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "중복확인";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(168, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(54, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "인증번호";
            // 
            // check_num
            // 
            this.check_num.BackColor = System.Drawing.SystemColors.Control;
            this.check_num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.check_num.Font = new System.Drawing.Font("굴림", 15F);
            this.check_num.Location = new System.Drawing.Point(170, 112);
            this.check_num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_num.Name = "check_num";
            this.check_num.Size = new System.Drawing.Size(84, 23);
            this.check_num.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(358, 71);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "인증번호받기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(358, 110);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 25);
            this.button5.TabIndex = 7;
            this.button5.Text = "확인";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // label_check
            // 
            this.label_check.AutoSize = true;
            this.label_check.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_check.Location = new System.Drawing.Point(168, 154);
            this.label_check.Name = "label_check";
            this.label_check.Size = new System.Drawing.Size(38, 12);
            this.label_check.TabIndex = 8;
            this.label_check.Text = "label1";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(277, 119);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(33, 12);
            this.time.TabIndex = 11;
            this.time.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(490, 377);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check_Box);
            this.Controls.Add(this.pass_Box);
            this.Controls.Add(this.check_num);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.phone_Box);
            this.Controls.Add(this.check_txt);
            this.Controls.Add(this.name_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.name_txt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_txt;
        private System.Windows.Forms.TextBox name_Box;
        private System.Windows.Forms.Label phone_txt;
        private System.Windows.Forms.TextBox phone_Box;
        private System.Windows.Forms.Label id_txt;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.Label pass_txt;
        private System.Windows.Forms.TextBox pass_Box;
        private System.Windows.Forms.Label check_txt;
        private System.Windows.Forms.TextBox check_Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox check_num;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label_check;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
    }
}

