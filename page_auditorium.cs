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

    public partial class page_auditorium : UserControl
    {
        Color color;
        ArrayList seat_arr = new ArrayList();//
        ArrayList temp_seatarr;//현재 선택된 좌석
        int count = 0;//좌석 선택의 수         
        int[] select_count = new int[4]; //사용자가 지정한 좌석수
        int[] now_seat_count = new int[3];
        int movie_id = 5;//넘어오는 값
        int check = 9;
        string[] button_text;//버튼의 텍스트값
        string[] button_name;//버튼의 이름
        string[] print_seatcount = new string[4];//좌석 정보 출력
        string[] print_pay = new string[4];
        string print_seat = "";
        Button[] preview = new Button[3];
        Button btn;//버튼 객체      
        SQLiteConnection conn = null;
        string path2 = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\data.sqlite";
        public page_auditorium()
        {
            InitializeComponent();
            temp_seatarr = new ArrayList();
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

            conn = new SQLiteConnection("Data Source=" + path2 + ";Version=3");
            conn.Open();


            string info = "SELECT * from timetable where movie_id =" + movie_id;
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

            btn = sender as Button;//sender를 버튼화 함             
            if (btn != null)//이 부분이 영화 좌석 눌렀을시
            {
                button_text = sender.ToString().Split(' ');//버튼 텍스트 추출
                button_name = btn.Name.Split('_');//버튼 이름 추출
                if (button_text[button_text.Length - 1].Equals("구매"))
                {
                    buttonClicked.Invoke(button_text[button_text.Length - 1], e);
                    conn = new SQLiteConnection("Data Source=" + path2 + ";Version=3");
                    conn.Open();
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
                    conn.Close();
                }
                else if (button_text[button_text.Length - 1].Equals("취소"))
                    buttonClicked.Invoke("seatcancel", e);
                else
                {
                    if (button_name[0].Equals("kid") || button_name[0].Equals("teen") || button_name[0].Equals("adult"))
                    {                       
                            //set_seatcount();                            
                            
                    }
                    else
                    {
                        seat_count();
                        /*if (select_count[3] > 0)
                        {                            
                            seat_count();                            
                            result_price(check);                            
                        }
                        else
                            MessageBox.Show("좌석을 선택해 주세요");
                         * */
                    }
                     
                }
            }

        }
        private void seat_count()
        {
            print_seat = "";
            if (count < 5)
            {

                if (!seat_arr.Contains(button_name[button_name.Length - 1]))
                {
                    seat_arr.Add(button_name[button_name.Length - 1]);
                    temp_seatarr.Add(button_name[button_name.Length - 1]);
                    color = btn.BackColor;
                    btn.BackColor = Color.White;
                   // now_seat_count[check]--;
                    count++;
                }
                else
                {
                    seat_arr.Remove(button_name[button_name.Length - 1]);
                    temp_seatarr.Remove(button_name[button_name.Length - 1]);
                    btn.BackColor = color;
                    count--;
                   // now_seat_count[check]++;
                }
            }
            else
            {
                if (seat_arr.Contains(button_name[button_name.Length - 1]))
                {
                    seat_arr.Remove(button_name[button_name.Length - 1]);
                    temp_seatarr.Remove(button_name[button_name.Length - 1]);
                    btn.BackColor = color;
                    count--;
                   // now_seat_count[check]++;
                }
                else
                    MessageBox.Show("선택할 수 있는 범위를 넘었습니다.");
            }
            for (int i = 0; i < temp_seatarr.Count; i++)
            {
                if (temp_seatarr.Count - 1 != i)
                    print_seat += temp_seatarr[i] + ",";
                else
                    print_seat += temp_seatarr[i];
            }
            label_seat.Text = print_seat;
            check_null();
        }
        private void set_seatcount()
        {
            int total_seat = 0;//좌석수의 맥시멈을 제한하기 위한 것

            switch (button_name[0])
            {
                case "kid":
                    select_count[2] = int.Parse(button_text[button_text.Length - 1]);
                    if (select_count[2] != 0)
                        print_seatcount[2] = "어린이 X " + select_count[2];
                    break;
                case "teen":
                    select_count[1] = int.Parse(button_text[button_text.Length - 1]);
                    if (select_count[1] != 0)
                        print_seatcount[1] = "청소년 X " + select_count[1];
                    break;
                case "adult":
                    select_count[0] = int.Parse(button_text[button_text.Length - 1]);
                    if (select_count[0] != 0)
                        print_seatcount[0] = "성인 X " + select_count[0];
                    break;
            }
            total_seat = select_count[0] + select_count[1] + select_count[2];
            select_count[3] = 0;
            if (total_seat <= 8)
            {
                print_seatcount[3] = "";
                for (int i = 0; i < 3; i++)
                {
                    if (print_seatcount[i] != null)
                    {
                        print_seatcount[3] += print_seatcount[i] + " ";

                    }
                    now_seat_count[i] = select_count[i];
                }
                select_count[3] = total_seat;
                print_price.Text = print_seatcount[3];
                switch (button_name[0])
                {
                    case "kid":
                        if (preview[2] != null) preview[2].BackColor = color;
                        btn.BackColor = Color.White;
                        preview[2] = btn;
                        break;
                    case "teen":
                        if (preview[1] != null) preview[1].BackColor = color;
                        btn.BackColor = Color.White;
                        preview[1] = btn;
                        break;
                    case "adult":
                        if (preview[0] != null) preview[0].BackColor = color;
                        btn.BackColor = Color.White;
                        preview[0] = btn;
                        break;
                }
            }

            else
            {
                MessageBox.Show("최대 8자리까지 선택 가능합니다.");
            }
            check_null();
        }
        private void result_price(int check)//종류별로 가격 출력
        {
            price.Text = "";
            switch (check)
            {

                case 0:
                    if ((select_count[0] - now_seat_count[0]) != 0)
                        print_pay[0] = "성인 X" + ((select_count[0] - now_seat_count[0]) * 8000).ToString();
                    else
                        print_pay[0] = null;
                    break;
                case 1:
                    if ((select_count[1] - now_seat_count[1]) != 0)
                        print_pay[1] = "청소년 X" + ((select_count[1] - now_seat_count[1]) * 7000).ToString();
                    else
                        print_pay[1] = null;
                    break;

                case 2:
                    if ((select_count[2] - now_seat_count[2]) != 0)
                        print_pay[2] = "어린이 X" + ((select_count[2] - now_seat_count[2]) * 6000).ToString();
                    else
                        print_pay[2] = null;
                    break;

            }
            for (int i = 0; i < 3; i++)
            {
                if (print_pay[i] != null)
                    price.Text += print_pay[i] + "\n";
            }
        }

        private void check_null()
        {
            for (int i = 0; i < 3; i++)
            {
                if (now_seat_count[i] != 0)
                {
                    check = i;
                    break;
                }
            }

        }
    }
}
