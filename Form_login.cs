using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ticket
{
    public partial class Form_login : Form
    {
        public static string temp_id = "";
        string temp_pw = "";
        SQLiteConnection conn = null;
        public static int join = 0;
        public static int id; //member id값 저장
        Form_signup signup;
        public Form_login()
        {
            
            InitializeComponent();            
            conn = new SQLiteConnection("Data source=" + Form1.path2 + ";Version=3;");
            find_id1.Visible = false;
            find_id1.ButtonClicked += button_Click;
            search_pass1.Visible = false; //이거 추가
            search_pass1.ButtonClicked += button_Click;
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string temp = sender.ToString();
            string[] temp_arr = temp.Split(' ');         
            switch (temp_arr[temp_arr.Length - 1])
            {
                case "로그인":
                    temp_id = text_id.Text.ToString();
                    temp_pw = text_pw.Text.ToString();

                    conn.Open();
                    string sql3 = "SELECT user, password,id FROM member where user = '"+ temp_id+"' and password = '"+ temp_pw+"';";
                    SQLiteCommand cmd2 = new SQLiteCommand(sql3, conn);
                    SQLiteDataReader read = cmd2.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            Form1.login_check = 1;
                            text_id.Text = "";
                            text_pw.Text = "";
                            id = int.Parse(read["id"].ToString());
                            Form1.login_check = 1;
                            this.Close();
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("로그인 실패! \n다시 확인해주세요.");
                    }
                    read.Close();
                    conn.Close();
                    break;
                case "취소":
                    this.Close();
                    break;
                case "회원가입":
                    SQLiteConnection.ClearAllPools();   
                    signup = new Form_signup();
                    signup.ShowDialog();
                    break; 
                case "아이디찾기":
                    find_id1.Visible = true;
                    break;
                case "로그인화면이동":
                    find_id1.Visible = false;
                    break;
                case "비밀번호찾기": //이거 이름 바꿈
                    search_pass1.Visible = true;
                    break;
                case "find_password": //이거 추가
                    search_pass1.Visible = false;
                    break;                   
                default:
                    MessageBox.Show("아직 구현되지 않았습니다");
                    break;
                case "비회원로그인": //이거 이름 바꿈
                    Form1.login_check = 2;
                    this.Close();
                    break;
                case "passtimeover":
                    search_pass1.Visible = false;
                    break;
                case "idtimeover":
                    find_id1.Visible = false;
                    break;
                case "find_id_cancel":
                    find_id1.Visible = false;
                    break;
                case "pass_cancel":
                    search_pass1.Visible = false;
                    break;
                
            }           
            
            
            //read.Close();
            conn.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
