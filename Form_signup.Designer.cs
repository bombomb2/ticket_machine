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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_signup));
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.AutoSize = true;
            this.name_txt.Font = new System.Drawing.Font("서울남산체 M", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_txt.Location = new System.Drawing.Point(89, 42);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(51, 26);
            this.name_txt.TabIndex = 0;
            this.name_txt.Text = "이름";
            // 
            // name_Box
            // 
            this.name_Box.BackColor = System.Drawing.Color.White;
            this.name_Box.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_Box.Location = new System.Drawing.Point(222, 41);
            this.name_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(128, 34);
            this.name_Box.TabIndex = 1;
            // 
            // phone_txt
            // 
            this.phone_txt.AutoSize = true;
            this.phone_txt.Font = new System.Drawing.Font("서울남산체 M", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phone_txt.Location = new System.Drawing.Point(89, 100);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(72, 26);
            this.phone_txt.TabIndex = 0;
            this.phone_txt.Text = "휴대폰";
            // 
            // phone_Box
            // 
            this.phone_Box.BackColor = System.Drawing.Color.White;
            this.phone_Box.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phone_Box.Location = new System.Drawing.Point(221, 92);
            this.phone_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_Box.Name = "phone_Box";
            this.phone_Box.Size = new System.Drawing.Size(207, 34);
            this.phone_Box.TabIndex = 2;
            this.phone_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_Box_KeyPress);
            // 
            // id_txt
            // 
            this.id_txt.AutoSize = true;
            this.id_txt.Font = new System.Drawing.Font("서울남산체 M", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_txt.Location = new System.Drawing.Point(89, 236);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(70, 26);
            this.id_txt.TabIndex = 0;
            this.id_txt.Text = "아이디";
            // 
            // ID_Box
            // 
            this.ID_Box.BackColor = System.Drawing.Color.White;
            this.ID_Box.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID_Box.Location = new System.Drawing.Point(222, 241);
            this.ID_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(207, 34);
            this.ID_Box.TabIndex = 3;
            // 
            // pass_txt
            // 
            this.pass_txt.AutoSize = true;
            this.pass_txt.Font = new System.Drawing.Font("서울남산체 M", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pass_txt.Location = new System.Drawing.Point(89, 297);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(89, 26);
            this.pass_txt.TabIndex = 0;
            this.pass_txt.Text = "비밀번호";
            // 
            // pass_Box
            // 
            this.pass_Box.BackColor = System.Drawing.Color.White;
            this.pass_Box.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pass_Box.Location = new System.Drawing.Point(222, 294);
            this.pass_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass_Box.Name = "pass_Box";
            this.pass_Box.PasswordChar = '*';
            this.pass_Box.Size = new System.Drawing.Size(207, 34);
            this.pass_Box.TabIndex = 4;
            // 
            // check_txt
            // 
            this.check_txt.AutoSize = true;
            this.check_txt.Font = new System.Drawing.Font("서울남산체 M", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.check_txt.Location = new System.Drawing.Point(89, 360);
            this.check_txt.Name = "check_txt";
            this.check_txt.Size = new System.Drawing.Size(135, 26);
            this.check_txt.TabIndex = 0;
            this.check_txt.Text = "비밀번호 확인";
            // 
            // check_Box
            // 
            this.check_Box.BackColor = System.Drawing.Color.White;
            this.check_Box.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.check_Box.Location = new System.Drawing.Point(222, 357);
            this.check_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_Box.Name = "check_Box";
            this.check_Box.PasswordChar = '*';
            this.check_Box.Size = new System.Drawing.Size(207, 34);
            this.check_Box.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("서울남산체 M", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(222, 440);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "가입하기";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("서울남산체 M", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(452, 238);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "중복확인";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("서울남산체 M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(219, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(465, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("서울남산체 M", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(89, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "인증번호";
            // 
            // check_num
            // 
            this.check_num.BackColor = System.Drawing.Color.White;
            this.check_num.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.check_num.Location = new System.Drawing.Point(221, 166);
            this.check_num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_num.Name = "check_num";
            this.check_num.Size = new System.Drawing.Size(96, 34);
            this.check_num.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("서울남산체 M", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(436, 97);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "인증번호받기";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("서울남산체 M", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(436, 164);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 31);
            this.button5.TabIndex = 7;
            this.button5.Text = "확인";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // label_check
            // 
            this.label_check.AutoSize = true;
            this.label_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(240)))));
            this.label_check.Location = new System.Drawing.Point(219, 218);
            this.label_check.Name = "label_check";
            this.label_check.Size = new System.Drawing.Size(45, 15);
            this.label_check.TabIndex = 8;
            this.label_check.Text = "label1";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(344, 175);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(44, 15);
            this.time.TabIndex = 11;
            this.time.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ticket.Properties.Resources.그림4;
            this.pictureBox3.Location = new System.Drawing.Point(492, 388);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 102);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // Form_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(629, 513);
            this.Controls.Add(this.pictureBox3);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원가입";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

