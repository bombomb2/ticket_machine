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
        private static int i = 0;
        private SQLiteConnection conn = null;        
        string path2 = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\data.sqlite";
       // private string connectionString;
        
        public Form_signup()
        {
            InitializeComponent();
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=" + path2 + ";Version=3"); // 데이터베이스 경로추가 (보내주신 파일에 있는거 그대로 복사했어요)
            //시작
            if (name_Box.Text == "" || pass_Box.Text == "") //*표시된것을 누르지 않은경우
                MessageBox.Show("필수항목을 입력하지 않으셨습니다.");
            else if (pass_Box.Text != check_Box.Text)
                MessageBox.Show("비밀번호가 같지 않습니다.");//비밀번호 재확인을 눌렀을때 같지 않은 경우

            else//그외의 경우 각각의 값을 저장해라
            {
            }
        }
        void clear()
        {
            ID_Box.Text = pass_Box.Text = phone_Box.Text = name_Box.Text = "";
        }
    }
}
            


