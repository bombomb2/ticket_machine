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
using System.Collections;
using System.IO;
namespace ticket
{
    public partial class recheck : UserControl
    {
        string info;
        SQLiteCommand cmd2;

        public recheck()
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
        string[] temp_booked;
        string[] temp_booked2;
        int count = 0;
        string temp;
        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=" + Form1.path2 + ";Version=3");
            conn.Open();                   
           
            temp_booked = page_auditorium.already_seat.Split(',');
            temp_booked2 = page_auditorium.now_seat.Split(',');
            count = page_auditorium.total_seat - (temp_booked.Length + temp_booked2.Length-1);            
            info = "update timetable set count=" + count + ",booked='" + page_auditorium.now_seat + "," + page_auditorium.already_seat + "'where movie_id='"+page_movie_select.movie_id+"';";
            cmd2 = new SQLiteCommand(info, conn);
            cmd2.ExecuteNonQuery();
            if (!Form1.is_nonmember)
            {
                info = "INSERT INTO reservation (id, movie_id, seat, price) VALUES (" + Form_login.id + "," + page_movie_select.movie_id + ",'" + page_auditorium.now_seat + "'," + int.Parse(page_auditorium.now_count.ToString()) + ");";
                cmd2 = new SQLiteCommand(info, conn);
                cmd2.ExecuteNonQuery();
                info = "UPDATE member set point=" + how_much.point + " where id=" + Form_login.id + ";";
                cmd2 = new SQLiteCommand(info, conn);
                cmd2.ExecuteNonQuery();
            }
            else
            {               
                info = "INSERT INTO reservation (id, movie_id, seat, price) VALUES (" + bihoywon_page_2.non_id + "," + page_movie_select.movie_id + ",'" + page_auditorium.now_seat + "'," + int.Parse(page_auditorium.now_count.ToString()) + ");";
                cmd2 = new SQLiteCommand(info, conn);
                cmd2.ExecuteNonQuery();
            }
            conn.Close();
            buttonClicked.Invoke("recheckok", e);           
        }
        public void test()
        {
            temp_booked = page_auditorium.already_seat.Split(',');
            temp_booked2 = page_auditorium.now_seat.Split(',');          
        }
        
    }
}
