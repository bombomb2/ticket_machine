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

namespace ticket
{
    public partial class page_checkBook : UserControl
    {
        public static SQLiteConnection conn = null;
        public page_checkBook()
        {
            InitializeComponent();
            // load_name();
            // load_data();
        }

        public void load_data()
        {
            conn = new SQLiteConnection("Data source=" + Form1.path2 + ";Version=3");
            conn.Open();
            String sql = "";
            if (Form1.login_check == 1)
                sql = "SELECT DISTINCT reserve_num, movie_id, seat, price from reservation where reservation.id = (Select id from member where user = '" + Form_login.temp_id + "' ) ;";
            else
            {//비회원 예약확인
                if (Form1.is_nonmember)
                    sql = "SELECT DISTINCT reserve_num, movie_id, seat, price from reservation where reservation.id = '" + page_nonmember_login.non_member_id + "';";
            }
            SQLiteCommand cmd2 = new SQLiteCommand(sql, conn);
            SQLiteDataReader rdr = cmd2.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem((rdr["reserve_num"]).ToString());
                    item.SubItems.Add((rdr["seat"]).ToString());

                    string movie_id = rdr["movie_id"].ToString();
                    sql = "SELECT DISTINCT time from timetable where movie_id = " + movie_id + ";";
                    SQLiteCommand cmd3 = new SQLiteCommand(sql, conn);
                    SQLiteDataReader rdr2 = cmd3.ExecuteReader();
                    while (rdr2.Read())
                    {
                        item.SubItems.Add((rdr2["time"]).ToString());
                    }

                    item.SubItems.Add((rdr["price"]).ToString() + "원");
                    listView_check.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("예약목록이 없습니다.");
            }
            conn.Close();
        }


        public void load_name()
        {
            conn = new SQLiteConnection("Data source=" + Form1.path2 + ";Version=3");
            conn.Open();
            String sql = "";
            if (Form1.login_check == 1)
                sql = "SELECT DISTINCT name from member where user = '" + Form_login.temp_id + "';";
            else
            {
                if (Form1.is_nonmember)
                    sql = "SELECT DISTINCT name from non_member where id = '" + page_nonmember_login.non_member_id + "';";
            }
            SQLiteCommand cmd2 = new SQLiteCommand(sql, conn);
            SQLiteDataReader rdr = cmd2.ExecuteReader();

            //MessageBox.Show(sql);
            while (rdr.Read())
            {
                label_name.Text = rdr["name"].ToString() + label_name.Text;
            }
            conn.Close();
        }
    }
}
