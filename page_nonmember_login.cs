using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace ticket
{
    public partial class page_nonmember_login : UserControl
    {
        public static int non_member_id = 999999;
        SQLiteConnection conn = null;
        public static string non_member;
        string path2 = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\data.sqlite";
        public page_nonmember_login()
        {
            InitializeComponent();
            string a = "* 01012345678 과 같이 입력해주세요."; //휴대폰 번호 입력 안내문구
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
            conn = new SQLiteConnection("Data source=" + path2 + ";Version=3;");
            conn.Open();

            string text1 = name.Text;
            string text2 = phone.Text;
            string text3 = pass.Text;

            if ((text1 == "" || text2 == "") || (text3 == "")) //입력 칸에 공백이 하나라도 있다면
                MessageBox.Show("입력하신 정보를 다시 확인해주세요.");
            
            else
            {
                string PASS = pass.Text;
                string NAME = name.Text;
                string PHONE = phone.Text;
                String sql = "SELECT id from non_member where name = '" + NAME + "' and phone = '" + PHONE + "' and password = '" + PASS + "';";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        non_member_id = int.Parse(rdr["id"].ToString());
                        Form1.is_nonmember = true;
                    }
                    if (buttonClicked != null)
                        buttonClicked.Invoke("check_nonmember", e);

                }
                else
                {
                    MessageBox.Show("일치하는 정보가 없습니다.");
                }
                conn.Close();
            }
        }

        private void phone_KeyPress(object sende, KeyPressEventArgs e) // 오직 숫자만 입력가능(휴대폰 번호)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
}
}
