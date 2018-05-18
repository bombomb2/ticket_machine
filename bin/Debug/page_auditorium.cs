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
namespace test
{

    public partial class page_auditorium : UserControl
    {
        Color color;
        ArrayList seat_arr = new ArrayList();
        int count = 0;//좌석 선택의 수 
        public static bool isok = false;       
        int movie_id = 5;
        SQLiteConnection conn = null;
        string path2 = "";
        public page_auditorium()
        {
            InitializeComponent();
            path2 = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\data.sqlite";
            //conn = new SQLiteConnection("Data Source=" + path2  + ";Version=3;");                        
        }
        
        public delegate void OnButtonClickedEventHandler(object sender, EventArgs e);
        private OnButtonClickedEventHandler buttonClicked;
        public event OnButtonClickedEventHandler ButtonClicked
        {
            add { buttonClicked += value; }
            remove { buttonClicked -= value; }
        }
      
        public void load_data()
        {

            conn = new SQLiteConnection("Data Source=" + Form1.path2 + ";Version=3");
            conn.Open();
   

            string info = "SELECT * from timetable where movie_id ="+movie_id;
            SQLiteCommand cmd2 = new SQLiteCommand(info, conn);
            SQLiteDataReader rdr = cmd2.ExecuteReader();

            int[,] test_arr2 = new int[5, 11];
            string[] haha = new string[5];
            while (rdr.Read())
            {                
                haha[0] += rdr["booked"].ToString();
                haha[1] += rdr["date"].ToString();
            }
            if (haha[0] != null)
            {
                string[] temp_str = haha[0].Split(',');
                for (int i = 0; i < temp_str.Length; i++)
                {
                    seat_arr.Add(temp_str[i]);
                }
            }
            rdr.Close();
            conn.Close();

            for (int i = 0; i < seat_arr.Count; i++)
            {
                string ran = "button_" + seat_arr[i];
                foreach (Control x in this.Controls)
                {
                    if (x is Button && x.Name.Equals(ran))
                    {
                        x.BackColor = Color.White;
                        x.Enabled = false;
                    }
                }
            }
        }
        private void button_click(object sender, EventArgs e)
        {
          
            Button btn = sender as Button;
            if (btn != null)
            {
                string[] temp_arr = sender.ToString().Split(' ');
                string[] temp_arr2 = btn.Name.Split('_');
                if (temp_arr[temp_arr.Length - 1].Equals("구매"))
                {
                    buttonClicked.Invoke(temp_arr[temp_arr.Length - 1], e);
                    Form1.conn.Open();
                    string temp = "";
                    for (int i = 0; i < seat_arr.Count; i++)
                    {
                        if (seat_arr.Count - 1 == i)
                            temp += seat_arr[i];
                        else
                            temp += seat_arr[i] + ",";

                    }                    
                    //string temp2 = "UPDATE timetable SET booked= '" + temp + "'WHERE movie_id= '12:20'";
                   // SQLiteCommand cmd = new SQLiteCommand(temp2, conn);
                    //int result = cmd.ExecuteNonQuery();
                    Form1.conn.Close();
                }
                else
                {

                    if (count < 5)
                    {

                        if (!seat_arr.Contains(temp_arr2[temp_arr2.Length - 1]))
                        {
                            seat_arr.Add(temp_arr2[temp_arr2.Length - 1]);
                            color = btn.BackColor;
                            btn.BackColor = Color.White;
                            count++;
                        }
                        else
                        {
                            seat_arr.Remove(temp_arr2[temp_arr2.Length - 1]);
                            btn.BackColor = color;
                            count--;
                        }
                    }
                    else
                    {
                        if (seat_arr.Contains(temp_arr2[temp_arr2.Length - 1]))
                        {
                            seat_arr.Remove(temp_arr2[temp_arr2.Length - 1]);
                            btn.BackColor = color;
                            count--;
                        }
                        else
                            MessageBox.Show("선택할 수 있는 범위를 넘었습니다.");
                    }
                   
                }
            }
        }    

       
        
    }
}
