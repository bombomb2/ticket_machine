using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;

namespace ticket
{
    public partial class Form_signup : Form
    {
        
        private static int i, w = 0;
        private SQLiteConnection conn;        
        string path2 = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\data.sqlite";
        // private string connectionString;
        private int time_cho = 180; //3분
        Random random = new Random();
        private int x;//랜덤값        
        string search_id="";
        string search_pass="";
        bool password_code = false;       
        string sql3;
        SQLiteCommand cmd2;       
        public Form_signup()
        {
            InitializeComponent();
            SQLiteConnection.ClearAllPools();         
            string a = "* 01012345678 과 같이 입력해주세요."; //휴대폰 번호 입력 안내문구
            label1.Text = a;
            phone_Box.MaxLength = 12; //길이제한
        }
        private void button_Click(object sender, EventArgs e)
        {
            
            //conn = new SQLiteConnection("Data Source=" + path2 + ";Version=3;");           
            search_id = ID_Box.Text.ToString();
            search_pass = pass_Box.Text.ToString();  
            

            string temp = sender.ToString();
            string[] temp_arr = temp.Split(' ');

            switch (temp_arr[temp_arr.Length - 1])
            {
                case "중복확인":                    
                    int count = 0;                     
                    
                    if (!ID_Box.Text.Equals(""))
                    {
                        search_id = ID_Box.Text;                      
                        SQLiteConnection conn = new SQLiteConnection("Data Source=" + path2 + ";Version=3;");
                        conn.Open();                        
                        sql3 = "SELECT user FROM member where user='"+search_id+"';";
                        SQLiteCommand cmd2 = new SQLiteCommand(sql3, conn);
                        SQLiteDataReader read = cmd2.ExecuteReader();
                        
                        if (read.HasRows)
                        {
                            while (read.Read())
                            { 
                                    MessageBox.Show("아이디 사용 불가");
                                    break;                                                                
                            }
                        }
                        else
                        {
                         MessageBox.Show("아이디 사용 가능");
                        }                       
                        read.Close();
                        conn.Close();
                    }
                    else
                        MessageBox.Show("아이디를 입력하지 않으셨습니다.");
                    break;

                case "가입하기":                    

                    if (pass_Box.Text != check_Box.Text)
                        MessageBox.Show("비밀번호가 같지 않습니다.");//비밀번호 재확인을 눌렀을때 같지 않은 경우

                    else if(label2.Text != "중복확인")
                    {
                        MessageBox.Show("중복확인 버튼을 누르지 않았습니다.");
                    }
                    else if(password_code == false)
                    {
                        MessageBox.Show("휴대폰 인증을 해주세요");
                    }
                    else//그외의 경우 각각의 값을 저장해라
                    {
                        SQLiteConnection.ClearAllPools();          
                        string ID = ID_Box.Text;
                        string PASS = pass_Box.Text;
                        string NAME = name_Box.Text;
                        string PHONE = phone_Box.Text;
                        SQLiteConnection conn2;
                        conn2 = new SQLiteConnection("Data Source=" + path2 + ";Version=3;");                       
                        conn2.Open();                        
                        sql3 = "INSERT INTO member (user, password,point,name,phone) VALUES ('" + ID + "','" + PASS + "','0','" + NAME + "','" + PHONE + "');";                       
                        cmd2 = new SQLiteCommand(sql3, conn2);
                        cmd2.ExecuteNonQuery();                       
                        conn2.Close();                        
                        
                    }
                    this.Close();
                        break;
                case "인증번호받기":
                        if (time_cho != 0)
                        {
                            x = random.Next(1, 10000);
                            MessageBox.Show("인증번호는" + this.x.ToString() + "입니다.");
                            timer1.Start();
                        }
                        break;
                
                case "확인":
                     if (int.Parse(check_num.Text) == x)
                     {
                         MessageBox.Show("확인되었습니다.");
                         password_code = true;
                         label_check.Text = "인증되었습니다.";
                         timer1.Stop();
                         break;
                     }
                     else
                     {
                         MessageBox.Show("인증번호가 다릅니다. 다시 확인해주세요");
                         break;
                     }
                    
            }
        } 


        void clear()
        {
            ID_Box.Text = pass_Box.Text = phone_Box.Text = name_Box.Text = "";
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
                //  return;
                reset();
                this.Close();               

            }

            time.Text = bun.ToString() + ":" + cho.ToString();



        }
        private void phone_Box_KeyPress(object sende, KeyPressEventArgs e) // 오직 숫자만 입력가능(휴대폰 번호)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void reset()
        {
            ID_Box.Text = "";
            pass_Box.Text = "";
            name_Box.Text = "";
            phone_Box.Text = "";
            check_num.Text = "";
            check_Box.Text = "";
        }
    }
}
      
         


