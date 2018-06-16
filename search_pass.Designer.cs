namespace ticket
{
    partial class search_pass
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.phonebox = new System.Windows.Forms.MaskedTextBox();
            this.bunhobox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bunho_but = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.USER = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.anne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "비밀번호 찾기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(33, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "휴대폰 번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(33, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "인증번호";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(157, 81);
            this.namebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(179, 21);
            this.namebox.TabIndex = 1;
            // 
            // phonebox
            // 
            this.phonebox.Location = new System.Drawing.Point(157, 164);
            this.phonebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phonebox.Name = "phonebox";
            this.phonebox.Size = new System.Drawing.Size(182, 21);
            this.phonebox.TabIndex = 3;
            this.phonebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phonebox_KeyPress);
            // 
            // bunhobox
            // 
            this.bunhobox.Location = new System.Drawing.Point(154, 236);
            this.bunhobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunhobox.Name = "bunhobox";
            this.bunhobox.Size = new System.Drawing.Size(81, 21);
            this.bunhobox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.search_pass_button_Click);
            // 
            // bunho_but
            // 
            this.bunho_but.Location = new System.Drawing.Point(380, 164);
            this.bunho_but.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunho_but.Name = "bunho_but";
            this.bunho_but.Size = new System.Drawing.Size(112, 22);
            this.bunho_but.TabIndex = 8;
            this.bunho_but.Text = "인증번호 받기";
            this.bunho_but.UseVisualStyleBackColor = true;
            this.bunho_but.Click += new System.EventHandler(this.search_pass_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(284, 240);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(33, 12);
            this.time.TabIndex = 11;
            this.time.Text = "00:00";
            // 
            // USER
            // 
            this.USER.Location = new System.Drawing.Point(157, 122);
            this.USER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.USER.Name = "USER";
            this.USER.Size = new System.Drawing.Size(179, 21);
            this.USER.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(33, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "아이디";
            // 
            // anne
            // 
            this.anne.AutoSize = true;
            this.anne.ForeColor = System.Drawing.Color.Red;
            this.anne.Location = new System.Drawing.Point(157, 190);
            this.anne.Name = "anne";
            this.anne.Size = new System.Drawing.Size(35, 12);
            this.anne.TabIndex = 13;
            this.anne.Text = "labe6";
            // 
            // search_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.anne);
            this.Controls.Add(this.USER);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.time);
            this.Controls.Add(this.bunho_but);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunhobox);
            this.Controls.Add(this.phonebox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "search_pass";
            this.Size = new System.Drawing.Size(531, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.MaskedTextBox phonebox;
        private System.Windows.Forms.MaskedTextBox bunhobox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bunho_but;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.TextBox USER;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label anne;
    }   
}
