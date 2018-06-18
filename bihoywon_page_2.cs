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
    public partial class bihoywon_page_2 : UserControl
    {
        SQLiteConnection conn = null;
        string path2 = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\data.sqlite";
        public static int non_id;//비회원 아이디값

        public bihoywon_page_2()
        {
            InitializeComponent();
            string a= "* 01012345678 과 같이 입력해주세요."; //휴대폰 번호 입력 안내문구
            label6.Text = a;
            phone.MaxLength = 12; // 휴대폰 번호 길이 제한
        }

        public delegate void OnButtonClickedEventHandler(object sender, EventArgs e);

        private OnButtonClickedEventHandler buttonClicked;
        public event OnButtonClickedEventHandler ButtonClicked
        {
            add { buttonClicked += value; }
            remove { buttonClicked -= value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn;
            btn = sender as Button;
            if (btn.Text.Equals("확인"))
            {
                conn = new SQLiteConnection("Data source=" + path2 + ";Version=3;");
                conn.Open();
                /* string sql3 = "select * from member";
                 SQLiteCommand cmd2 = new SQLiteCommand(sql3, conn);
                 SQLiteDataReader read = cmd2.ExecuteReader();*/


                string text1 = name.Text;
                string text2 = phone.Text;
                string text4 = pass_2.Text;
                string text3 = pass.Text;



                if ((text1 == "" || text2 == "") || (text3 == "" || text4 == "")) //입력 칸에 공백이 하나라도 있다면
                    MessageBox.Show("입력하신 정보를 다시 확인해주세요.");
                else if (text4 != text3)
                {
                    MessageBox.Show("비밀번호가 같지 않습니다.");
                }
                else
                {
                    MessageBox.Show("가입성공");
                    string PASS = pass.Text;
                    string NAME = name.Text;
                    string PASS_2 = pass_2.Text;
                    string PHONE = phone.Text;
                    String sql = "INSERT INTO non_member (name,phone, password) VALUES ('" + NAME + "','" + PHONE + "','" + PASS + "')";
                    SQLiteCommand command = new SQLiteCommand(sql, conn);
                    command.ExecuteNonQuery();
                    string sql2 = "SELECT id FROM non_member where name='" + NAME + "';";
                    SQLiteCommand cmd2 = new SQLiteCommand(sql2, conn);
                    SQLiteDataReader rdr = cmd2.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            non_id = int.Parse(rdr["id"].ToString());
                        }
                    }
                    conn.Close();
                    Form1.is_nonmember = true;
                    if (buttonClicked != null)
                    {
                        reset();
                        buttonClicked.Invoke("finish_nonmember", e);
                    }
                }
            }
            else if(btn.Text.Equals("취소"))
            {
                reset();
                buttonClicked.Invoke("finish_cancel", e);
            }

        }

        private void phone_KeyPress(object sende, KeyPressEventArgs e) // 오직 숫자만 입력가능(휴대폰 번호)
        {   
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void bihoywon_page_2_Load(object sender, EventArgs e)
        {

        }
        private void reset()
        {
            name.Text = "";
            phone.Text = "";
            pass.Text = "";
            pass_2.Text = "";
        }
    }
}
