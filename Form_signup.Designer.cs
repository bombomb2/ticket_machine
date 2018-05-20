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
            this.name_txt = new System.Windows.Forms.Label();
            this.name_Box = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.Label();
            this.phone_Box = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.Label();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.Label();
            this.pass_Box = new System.Windows.Forms.TextBox();
            this.check_txt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.check_Box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.AutoSize = true;
            this.name_txt.Font = new System.Drawing.Font("굴림", 15F);
            this.name_txt.Location = new System.Drawing.Point(67, 57);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(49, 20);
            this.name_txt.TabIndex = 0;
            this.name_txt.Text = "이름";
            // 
            // name_Box
            // 
            this.name_Box.Font = new System.Drawing.Font("굴림", 15F);
            this.name_Box.Location = new System.Drawing.Point(209, 54);
            this.name_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(112, 30);
            this.name_Box.TabIndex = 1;
            // 
            // phone_txt
            // 
            this.phone_txt.AutoSize = true;
            this.phone_txt.Font = new System.Drawing.Font("굴림", 15F);
            this.phone_txt.Location = new System.Drawing.Point(67, 106);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(69, 20);
            this.phone_txt.TabIndex = 0;
            this.phone_txt.Text = "휴대폰";
            // 
            // phone_Box
            // 
            this.phone_Box.Font = new System.Drawing.Font("굴림", 15F);
            this.phone_Box.Location = new System.Drawing.Point(209, 103);
            this.phone_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_Box.Name = "phone_Box";
            this.phone_Box.Size = new System.Drawing.Size(181, 30);
            this.phone_Box.TabIndex = 2;
            // 
            // id_txt
            // 
            this.id_txt.AutoSize = true;
            this.id_txt.Font = new System.Drawing.Font("굴림", 15F);
            this.id_txt.Location = new System.Drawing.Point(67, 188);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(69, 20);
            this.id_txt.TabIndex = 0;
            this.id_txt.Text = "아이디";
            // 
            // ID_Box
            // 
            this.ID_Box.Font = new System.Drawing.Font("굴림", 15F);
            this.ID_Box.Location = new System.Drawing.Point(209, 185);
            this.ID_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(181, 30);
            this.ID_Box.TabIndex = 3;
            // 
            // pass_txt
            // 
            this.pass_txt.AutoSize = true;
            this.pass_txt.Font = new System.Drawing.Font("굴림", 15F);
            this.pass_txt.Location = new System.Drawing.Point(67, 231);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(89, 20);
            this.pass_txt.TabIndex = 0;
            this.pass_txt.Text = "비밀번호";
            // 
            // pass_Box
            // 
            this.pass_Box.Font = new System.Drawing.Font("굴림", 15F);
            this.pass_Box.Location = new System.Drawing.Point(209, 228);
            this.pass_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass_Box.Name = "pass_Box";
            this.pass_Box.PasswordChar = '*';
            this.pass_Box.Size = new System.Drawing.Size(181, 30);
            this.pass_Box.TabIndex = 4;
            // 
            // check_txt
            // 
            this.check_txt.AutoSize = true;
            this.check_txt.Font = new System.Drawing.Font("굴림", 15F);
            this.check_txt.Location = new System.Drawing.Point(67, 281);
            this.check_txt.Name = "check_txt";
            this.check_txt.Size = new System.Drawing.Size(136, 20);
            this.check_txt.TabIndex = 0;
            this.check_txt.Text = "비밀번호 확인";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 15F);
            this.label7.Location = new System.Drawing.Point(35, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "-------------";
            // 
            // check_Box
            // 
            this.check_Box.Font = new System.Drawing.Font("굴림", 15F);
            this.check_Box.Location = new System.Drawing.Point(209, 278);
            this.check_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_Box.Name = "check_Box";
            this.check_Box.PasswordChar = '*';
            this.check_Box.Size = new System.Drawing.Size(181, 30);
            this.check_Box.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 20F);
            this.button1.Location = new System.Drawing.Point(174, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "가입하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 189);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "중복확인";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 391);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check_Box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pass_Box);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.phone_Box);
            this.Controls.Add(this.check_txt);
            this.Controls.Add(this.name_Box);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.name_txt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_signup";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox check_Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

