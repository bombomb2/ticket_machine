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

namespace ticket //남은 좌석수 표시하기
{
    public partial class page_movie_select : UserControl
    {
        public static SQLiteConnection conn = null;
        private bool isSelected_movie = false;
        private bool isSelected_date = false;
        public static bool isSelected_time = false;
        public int movie_id;
        private string date = "";
        string movie_path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/photo/";    

        public delegate void OnButtonClickedEventHandler(object sender, EventArgs e);
        private OnButtonClickedEventHandler buttonClicked;
        public event OnButtonClickedEventHandler ButtonClicked
        {
            add { buttonClicked += value; }
            remove { buttonClicked -= value; }
        }

        public page_movie_select()
        {
            InitializeComponent();

        }
        
        public void InitListbox()
        {
            listBox_movie_select.Items.Clear();
            listBox_date.Items.Clear();
            conn = new SQLiteConnection("Data source=" + Form1.path2 + ";Version=3");
            conn.Open();
            string sql = "SELECT DISTINCT title from movie, timetable where movie.title_num = timetable.title_num;";
            SQLiteCommand cmd2 = new SQLiteCommand(sql, conn);
            SQLiteDataReader rdr = cmd2.ExecuteReader();

            while (rdr.Read())
            {
                listBox_movie_select.Items.Add(rdr["title"]);
            }

            sql = "SELECT DISTINCT date from timetable;";
            cmd2 = new SQLiteCommand(sql, conn);
            rdr = cmd2.ExecuteReader();

            while (rdr.Read())
            {
                DateTime myDate = DateTime.Parse(rdr["date"].ToString());
                string rdr_date = myDate.ToString("MM월 dd일");
                listBox_date.Items.Add(rdr_date);
            }
            movie_picture.ImageLocation = movie_path + "default.jpg";
            movie_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }
        private void listBox_movie_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_movie_select.SelectedItem != null)
            {
                isSelected_movie = true;
                loadTime();
            }

            string sql = "SELECT DISTINCT content,title_num from movie where title = '" + listBox_movie_select.Text + "';";
            SQLiteCommand cmd2 = new SQLiteCommand(sql, conn);
            SQLiteDataReader rdr = cmd2.ExecuteReader();

            while (rdr.Read())
            {
                movie_content.Text = (rdr["content"].ToString());
                movie_picture.ImageLocation = movie_path + rdr["title_num"] + ".jpg";
            }           
        }

        private void listBox_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_date.SelectedItem != null) { 
            isSelected_date = true;
            DateTime myDate = DateTime.Parse(listBox_date.SelectedItem.ToString());
            date = "18." + myDate.ToString("MM.dd");
            loadTime();
        }
        }



        private void loadTime()
        {
            if (isSelected_date && isSelected_movie)
            {
                         listBox_time.Items.Clear();
                         string sql = "SELECT movie_id, auditorium_num, time from timetable " +
                               "where title_num =(SELECT title_num from movie where title = '"
                               + listBox_movie_select.SelectedItem.ToString() + "') and date = '" + date + "';";

                         SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                         SQLiteDataReader rdr = cmd.ExecuteReader();

                         while (rdr.Read())
                         {
                             int auditorium_num = int.Parse(rdr["auditorium_num"].ToString());
                             String time = rdr["time"].ToString();
                             listBox_time.Items.Add(auditorium_num + "상영관    " + time);
                         }
                     }
            
        }

        private void button_Click(object sender, EventArgs e)
        {
    
            string[] temp_arr = sender.ToString().Split(' ');
            if (temp_arr[temp_arr.Length - 1].Equals("이전"))
            {
                buttonClicked.Invoke("movieselect_cancel", e);
                conn.Close();
            }
            else if (temp_arr[temp_arr.Length - 1].Equals("좌석선택"))
            {
                if (isSelected_time)
                {
                    string sql = "SELECT movie_id from timetable " +
                                  "where title_num =(SELECT title_num from movie where title = '"
                                  + listBox_movie_select.SelectedItem.ToString() + "') and date = '" + date + "' and time = '" + listBox_time.SelectedItem.ToString().Substring(8, 5) + "';";

                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    SQLiteDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        movie_id = int.Parse(rdr["movie_id"].ToString());
                       // MessageBox.Show("movie_id: " + movie_id);
                    }
                    buttonClicked.Invoke("movieselect_next", e);

                 //   conn.Close();

                    if(Form1.login_check==1)
                        conn.Close();

                }
                else
                {
                    MessageBox.Show("영화 시간을 선택해주세요.");
                }
            }       
        }


        private void listBox1_DrawItem(object sender, DrawItemEventArgs e) //목록이 그려질 때 발생하는 DrawItem 이벤트 수정
        {
                e.DrawBackground();
                Graphics g = e.Graphics;
                Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? Brushes.Red : new SolidBrush(e.BackColor); //BackColor 수정 하는 곳
                g.FillRectangle(brush, e.Bounds);
            if(e.Index>-1)
                e.Graphics.DrawString(listBox_movie_select.Items[e.Index].ToString(), e.Font,
                    ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? Brushes.Black : new SolidBrush(e.ForeColor), e.Bounds, StringFormat.GenericDefault); //ForeColor 수정하는 곳 
                e.DrawFocusRectangle();
            
        }

        private void listBox_date_DrawItem(object sender, DrawItemEventArgs e)
        {
           
                string sOoutput = listBox_date.Items[e.Index].ToString();
                float folength = e.Graphics.MeasureString(sOoutput, e.Font).Width;
                float fpos = (listBox_date.Width - folength) / 2;
                Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? Brushes.Red : new SolidBrush(e.BackColor); //BackColor 수정 하는 곳
                e.Graphics.FillRectangle(brush, e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height);
                e.Graphics.DrawString(sOoutput, e.Font,
                    ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? Brushes.Black : new SolidBrush(e.ForeColor), fpos, e.Bounds.Top);
        }
        private void listBox_time_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (isSelected_date && isSelected_movie)
            {
                string sOoutput = listBox_time.Items[e.Index].ToString();
                float folength = e.Graphics.MeasureString(sOoutput, e.Font).Width;
                float fpos = (listBox_time.Width - folength) / 2;
                Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? Brushes.Red : new SolidBrush(e.BackColor); //BackColor 수정 하는 곳
                e.Graphics.FillRectangle(brush, e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height);
                e.Graphics.DrawString(sOoutput, e.Font,
                    ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? Brushes.Black : new SolidBrush(e.ForeColor), fpos, e.Bounds.Top);
            }
        }

        private void listBox_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            isSelected_time = true;
        }
    }
}
