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
        string temp_id = "";
        string temp_pw = "";
        SQLiteConnection conn = null;
        public static int join = 0;
        Form_signup signup;
        public Form_login()        {
            
            InitializeComponent();
            conn = new SQLiteConnection("Data source=" + Form1.path2 + ";Version=3;");
            
        }
        private void button_Click(object sender, EventArgs e)
        {

            temp_id = text_id.Text.ToString();
            temp_pw = text_pw.Text.ToString();

            conn.Open();
            string sql3 = "SELECT * FROM member";
            SQLiteCommand cmd2 = new SQLiteCommand(sql3, conn);
            SQLiteDataReader read = cmd2.ExecuteReader();

            string temp = sender.ToString();
            string[] temp_arr = temp.Split(' ');            

            switch (temp_arr[temp_arr.Length - 1])
            {
                case "로그인":                    
                    while (read.Read())
                    {
                        
                        if (read["user"].ToString().Equals(temp_id) && read["password"].ToString().Equals(temp_pw))
                        {
                            Form1.login_check = 1;
                            text_id.Text = "";
                            text_pw.Text = "";
                            Form1.login_check = 1;
                            this.Close();
                            break;
                        }                        
                            
                    }
                    break;
                case "취소":
                    this.Close();
                    break;

                case "회원가입":
                    signup = new Form_signup();
                    signup.ShowDialog();
                    break; 
                default:
                    MessageBox.Show("아직 구현되지 않았습니다");
                    break;
                
            }           
            
            
            read.Close();
            conn.Close();

        }

       
       
    }
}
