using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;//쿼리 select*from
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Collections;


namespace ticket
{
    public partial class how_much : UserControl
    {
        int title_num;
        string date;
        string auditorium_num;
        string title;
        public static int point;
        public how_much()
        {
            InitializeComponent();               
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
            buttonClicked.Invoke("확인구매", e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonClicked.Invoke("확인취소", e);
        }
        public void set_default()
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=" + Form1.path2 + ";Version=3");
            conn.Open();

            string info = "SELECT * from timetable where movie_id =+"+page_movie_select.movie_id+";";
            SQLiteCommand cmd2 = new SQLiteCommand(info, conn);
            SQLiteDataReader rdr = cmd2.ExecuteReader();         
            while(rdr.Read())
            {
                date = rdr["date"].ToString();
                auditorium_num = rdr["auditorium_num"].ToString() + "상영관";
                title_num = int.Parse(rdr["title_num"].ToString());
            }
            info = "select title from movie where title_num='" + title_num + "';";            
            cmd2 = new SQLiteCommand(info, conn);
            rdr = cmd2.ExecuteReader();
            while(rdr.Read())
            {
                title = rdr["title"].ToString();
            }
            textBox1.Text = title;
            textBox2.Text = date;
            textBox3.Text = auditorium_num;
            textBox4.Text = page_auditorium.now_seat;
            if (!Form1.is_nonmember)
            {
                label6.Visible = true;
                textBox5.Visible = true;
                textBox5.Text = (page_auditorium.now_count * 0.01).ToString();
                point = int.Parse((page_auditorium.now_count * 0.01).ToString());
            }
            else
            {
                label6.Visible = false;
                textBox5.Visible = false;
            }

                label10.Text = (page_auditorium.now_count).ToString();
            
        }
    }
}
    

