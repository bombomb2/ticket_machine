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
using System.IO;

namespace ticket
{
    public partial class search_pass : UserControl
    {

        SQLiteConnection conn = null;
        private int time_cho = 180; //3분
        Random random = new Random();
        private int x;//랜덤값
        string path2 = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\data.sqlite";

        public delegate void OnButtonClickedEventHandler(object sender, EventArgs e);

        private OnButtonClickedEventHandler buttonClicked;
        public event OnButtonClickedEventHandler ButtonClicked
        {
            add { buttonClicked += value; }
            remove { buttonClicked -= value; }
        }

        public search_pass()
        {
            InitializeComponent();
            string a = "* 01012345678 과 같이 입력해주세요.";
            anne.Text = a;
        }

        private void search_pass_button_Click(object sender, EventArgs e)
        {
           

            Button tmp = (Button)sender;
            string temp = tmp.Text;

            switch (temp)
            {

                case "인증번호 받기":
                    {
                        time_cho = 180;
                        if (time_cho != 0)
                        {
                            x = random.Next(1, 10000);
                            MessageBox.Show("인증번호는" + this.x.ToString() + "입니다.");
                            timer1.Start();
                        }
                    }
                    break;

                case "확인":
                    SQLiteConnection.ClearAllPools();
                    conn = new SQLiteConnection("Data source=" + path2 + ";Version=3;");
                    conn.Open();

                    string name = namebox.Text; // 이름
                    string phone = phonebox.Text; // 휴대폰번호 
                    string bunho = bunhobox.Text; // 인증번호
                    string user = USER.Text;

                    if (bunho.Equals(x.ToString())) //bunho.tostirng()하면 이상한값 나옴, bunho.text로 하기!!
                    {
                        string sql3 = "select password from member where user = '"+ user + "' and name = '"+ name + "' and phone = '"+phone+"';" ;
                        SQLiteCommand cmd2 = new SQLiteCommand(sql3, conn);
                        SQLiteDataReader read = cmd2.ExecuteReader();                        
                        if (read.HasRows)
                        {
                            while (read.Read())
                            {
                                timer1.Stop();
                                string pass = read["password"].ToString();
                                MessageBox.Show("비밀번호는 " + pass + " 입니다.");

                                if (buttonClicked != null)
                                {
                                    reset();
                                    buttonClicked.Invoke("find_password", e);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("등록된 정보가 없습니다.\n입력된 정보를 다시 확인해주세요.");
                        }
                        read.Close();
                        conn.Close();

                    }

                    else
                    {
                        MessageBox.Show("인증번호가 같지 않습니다.");
                        x = random.Next(1, 10000);
                        bunhobox.Text = "";
                        break;
                    }
                    break;    
                case "취소":
                    reset();
                    buttonClicked.Invoke("pass_cancel", e);
                    break;
                    
            }
        }
        private void reset()
        {
            namebox.Text = "";
            bunhobox.Text = "";
            USER.Text = "";
            phonebox.Text = "";
            time_cho = 180;
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e) //타이머에 대한 함수

        {
            if (time_cho != 0)
            {
                time_cho--;
            }
            else if (time_cho == 0){
                timer1.Enabled = false; 

            }
              
            int bun = time_cho / 60; //분
            int cho = time_cho % 60;//초

            if (timer1.Enabled==false)
            {
                MessageBox.Show("요청시간이 지났습니다."); // 요청시간이 지날경우 화면이 사라지게??
              //  return;
                reset();
                buttonClicked.Invoke("passtimeover", e);                
                
            }

            time.Text = bun.ToString() + ":" + cho.ToString();



        }

        private void phonebox_KeyPress(object sende, KeyPressEventArgs e) // 오직 숫자만 입력가능(휴대폰 번호)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }


        }       

    }
}
