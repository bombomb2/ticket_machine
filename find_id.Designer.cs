namespace ticket
{
    partial class find_id
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.check_num = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("굴림", 20F);
            this.label3.Location = new System.Drawing.Point(45, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "아이디 찾기";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(127, 142);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 12);
            this.label_name.TabIndex = 7;
            this.label_name.Text = "이름";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 8;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(110, 177);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(69, 12);
            this.label_phone.TabIndex = 7;
            this.label_phone.Text = "핸드폰 번호";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 8;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_Keypress);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "아이디확인";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(333, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "인증번호받기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "인증번호확인";
            // 
            // check_num
            // 
            this.check_num.Location = new System.Drawing.Point(213, 210);
            this.check_num.Name = "check_num";
            this.check_num.Size = new System.Drawing.Size(100, 21);
            this.check_num.TabIndex = 8;
            this.check_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_Keypress);
            this.check_num.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(347, 219);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(33, 12);
            this.time.TabIndex = 12;
            this.time.Text = "00:00";
            // 
            // find_id
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.time);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.check_num);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "find_id";
            this.Size = new System.Drawing.Size(560, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox check_num;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
    }
}
