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


namespace test
{
    public partial class page1 : UserControl
    {
        string temp_id;
        string temp_pw;

        SQLiteConnection conn = null;
        public page1()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=" + Form1.path2  + ";Version=3");
        }
        public delegate void OnButtonClickedEventHandler(object sender, EventArgs e);

        private OnButtonClickedEventHandler buttonClicked;
        public event OnButtonClickedEventHandler ButtonClicked
        {
            add { buttonClicked += value;  }
            remove { buttonClicked -= value; }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonClicked != null)
            {                
              
                temp_id = textBox_id.Text.ToString();
                temp_pw = textBox_pw.Text.ToString();         
              
                conn.Open();
                string sql3 = "SELECT * FROM member";           
               SQLiteCommand cmd2 = new SQLiteCommand(sql3, conn);
                SQLiteDataReader read = cmd2.ExecuteReader();
              
                string temp = sender.ToString();
                string[] temp_arr =  temp.Split(' ');
                buttonClicked.Invoke(temp_arr[temp_arr.Length - 1], e);
                switch (temp_arr[temp_arr.Length - 1]) {
                    case "로그인" :                    
                        while (read.Read())
                        {
                            test_id.Text += read["user"].ToString();
                            if (read["user"].ToString().Equals(temp_id) && read["password"].ToString().Equals(temp_pw))
                            {
                                test_id.Text = "로그인 성공";
                                break;
                            }
                            else
                                test_id.Text = "로그인 실패";
                        }
                        break;
                    case "회원가입":                       
                        
                        break;
                }            
                       
                read.Close();
                conn.Close();
            }
        }

     
    }
}
