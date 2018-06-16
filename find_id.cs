using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace ticket
{
    public partial class find_id : UserControl
    {
        string temp_name = "";
        string temp_phone = "";
        string temp_id = "";
        string findid="";
        private int time_cho = 180; //3분
        Random random = new Random();
        private int x;//랜덤값
        SQLiteConnection conn;
        public find_id()
        {
            InitializeComponent();
            textBox1.Text = "";
            textBox2.Text = "";
        }
        public delegate void OnButtonClickedEventHandler(object sender, EventArgs e);
        private OnButtonClickedEventHandler buttonClicked;
        public event OnButtonClickedEventHandler ButtonClicked
        {
            add { buttonClicked += value; }
            remove { buttonClicked -= value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp_name = textBox1.Text.ToString();
            temp_phone = textBox2.Text.ToString();
            conn = new SQLiteConnection("Data source=" + Form1.path2 + ";Version = 3;");

            conn.Open();
            string sql3 = "SELECT * FROM member"; //DB읽기
            SQLiteCommand cmd2 = new SQLiteCommand(sql3, conn);
            SQLiteDataReader read = cmd2.ExecuteReader();

            string temp = sender.ToString();
            string[] temp_arr = temp.Split(' ');
            while (read.Read())
            {
                if (read["name"].ToString().Equals(temp_name) && read["phone"].ToString().Equals(temp_phone))
                {//name과 phone 동일하면
                    if (int.Parse(check_num.Text) == x)
                    {
                        temp_id = read["user"].ToString(); //id읽기
                        findid = temp_id;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("인증번호가 같지 않습니다." + x.ToString() + check_num.Text);                        
                        check_num.Text = "";
                        break;
                    }
                }
                else
                {
                    temp_id = null;
                    findid = null; 
                }

            }
            if(findid != null)
            {
                timer1.Stop();
                MessageBox.Show("아이디는 " + findid + " 입니다.");
                if (buttonClicked != null)                    
                buttonClicked.Invoke("로그인화면이동", e);
            }
            else
            {
                MessageBox.Show("등록된 정보가 없습니다.");
            }
        }
        private void textBox2_Keypress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }
        private void textBox2_Leave(object sender, System.EventArgs e)
        {
            Regex emarliregex = new Regex(@"[0-9]"); //숫자만입력
            Boolean ismatch = emarliregex.IsMatch(textBox2.Text);
            if (!ismatch)
            {
                MessageBox.Show("숫자만 입력해주세요.");
            }
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            time_cho = 180;
            if (time_cho != 0)
            {
                x = random.Next(1, 10000);
                MessageBox.Show("인증번호는" + this.x.ToString() + "입니다.");
                timer1.Start();
            }
        }
       private void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            check_num.Text = "";
        }
        private void timer1_Tick(object sender, EventArgs e) //타이머에 대한 함수
        {
            if (time_cho != 0)
            {
                time_cho--;
            }
            else if (time_cho == 0)
            {
                timer1.Enabled = false;

            }

            int bun = time_cho / 60; //분
            int cho = time_cho % 60;//초

            if (timer1.Enabled == false)
            {
                MessageBox.Show("요청시간이 지났습니다."); // 요청시간이 지날경우 화면이 사라지게??
                reset();
                buttonClicked.Invoke("idtimeover", e);             

            }
            time.Text = bun.ToString() + ":" + cho.ToString();
            
        }

    }
}
