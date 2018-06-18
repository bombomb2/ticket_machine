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
        Color color = Color.FromArgb(220, 240, 245);
        Color select_color = Color.FromArgb(249, 129, 138);
        ArrayList seat_arr = new ArrayList();//
        ArrayList temp_seatarr = new ArrayList();//현재 선택된 좌석        
        int[] seat_count = new int[4];      
        int count = 0;//좌석 선택의 수            
        int now_click;
        public static int total_seat = 110;
        public static string already_seat;
        public static string now_seat;//좌석 현황 넘기기
        public static float now_count;//총 금액 넘기기        
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
            button_purchase.Enabled = false;
        }

       public void reset() 
        {

            foreach(Control x in this.Controls)
            {                
                if (x is Button && x.Name.Contains("adult") || x.Name.Contains("kid") || x.Name.Contains("teen"))
                    x.BackColor = color;
                if(x is Button && x.Name.Contains("_a")|| x.Name.Contains("_b") || x.Name.Contains("_c") || x.Name.Contains("_d") || x.Name.Contains("_e") 
                    || x.Name.Contains("_f") || x.Name.Contains("_g") || x.Name.Contains("_h") || x.Name.Contains("_i") || x.Name.Contains("_j") )
                    x.BackColor = color;

            }
            temp_seatarr.Clear();            
            seat_arr.Clear();
            button_name = null;
            button_text = null;
            print_seat = "";
            print_people.Text = "";
            label_seat.Text = "";
             price.Text = "";
            total_price.Text = "0원";
             count = 0;
           for(int i=0; i< 4; i++)
           {
               print_pay[i] = null;
               print_seatcount[i] = null;
               seat_count[i] = 0;
           }
           for (int z = 0; z < 3; z++)
               preview[z] = null;
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
            reset();
            conn = new SQLiteConnection("Data Source=" + path2 + ";Version=3");
            conn.Open();
                       
            string info = "SELECT * from timetable where movie_id =" + page_movie_select.movie_id+";";
            SQLiteCommand cmd2 = new SQLiteCommand(info, conn);
            SQLiteDataReader rdr = cmd2.ExecuteReader();

            int[,] test_arr2 = new int[5, 11];
            string[] haha = new string[5];
            while (rdr.Read())
            {
                haha[0] += rdr["booked"].ToString();               
            }
            already_seat = haha[0];
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
                if (button_text[button_text.Length - 1].Equals("다음"))
                {                    
                   if(seat_count[3] == temp_seatarr.Count && seat_count[3]!=0)
                   {                       
                       now_count = seat_count[0] * 10000 + seat_count[1] * 8000 + seat_count[2] * 6000;
                       buttonClicked.Invoke("좌석선택다음", e);                       
                      // MessageBox.Show(now_count.ToString());
                   }
                   else
                   {
                       MessageBox.Show("좌석 선택이 완료되지 않았습니다.");
                   }
                }
                else if (button_text[button_text.Length - 1].Equals("취소"))
                {
                    temp_seatarr.Clear();
                    for (int i = 0; i < 3; i++)
                    {
                        preview[i] = null;
                        print_pay[i] = null;
                        print_seatcount[i] = null;
                        if (i == 2)
                        {
                            print_pay[i+1] = null;
                            print_seatcount[i+1] = null;                        
                        }
                    }
                       
                        buttonClicked.Invoke("seatcancel", e);
                }
                else
                {
                    if (button_name[0].Equals("kid") || button_name[0].Equals("teen") || button_name[0].Equals("adult"))
                    {

                        set_seat_count();
                        print_recipt();
                    }
                    else
                    {

                        if (seat_count[3] > 0)
                        {
                            select_seat();
                        }
                        else
                            MessageBox.Show("인원수를 설정해 주세요");

                    }

                }
            }

        }
        private void select_seat()
        {           
            print_seat = "";
            if (count < seat_count[3])
            {

                if (!seat_arr.Contains(button_name[button_name.Length - 1]))
                {
                    seat_arr.Add(button_name[button_name.Length - 1]);
                    temp_seatarr.Add(button_name[button_name.Length - 1]);                    
                    btn.BackColor = select_color;                   
                    count++;
                }
                else
                {
                    seat_arr.Remove(button_name[button_name.Length - 1]);
                    temp_seatarr.Remove(button_name[button_name.Length - 1]);
                    btn.BackColor = color;                   
                    count--;                   
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
                }
                else
                    MessageBox.Show("선택할 수 있는 범위를 넘었습니다.");
            }
           
            label_seat.Text = "";
            now_seat = "";
            for (int i = 0; i < temp_seatarr.Count; i++)
            {
                label_seat.Text += " " + temp_seatarr[i];
                if (i == 0)
                    now_seat += temp_seatarr[i];
                else
                    now_seat += "," + temp_seatarr[i];
            }
            if(seat_count[3] == temp_seatarr.Count)
            {
                button_purchase.Enabled = true;
            }
        }
        
        private void set_seat_count()
        {

            switch (button_name[0])
            {
                case "adult":
                    if (seat_count[0] != 0) seat_count[3] -= seat_count[0];
                    seat_count[0] = int.Parse(btn.Text);
                    if (preview[0] != null) preview[0].BackColor = color;
                    btn.BackColor = select_color;                   
                    seat_count[3] += seat_count[0];
                    now_click = 0;
                    break;
                case "teen":
                    if (seat_count[1] != 0) seat_count[3] -= seat_count[1];
                    seat_count[1] = int.Parse(btn.Text);
                    if (preview[1] != null) preview[1].BackColor = color;
                    btn.BackColor = select_color;                   
                    seat_count[3] += seat_count[1];
                    now_click = 1;
                    break;
                case "kid":
                    if (seat_count[2] != 0) seat_count[3] -= seat_count[2];
                    seat_count[2] = int.Parse(btn.Text);
                    if (preview[2] != null) preview[2].BackColor = color;
                    btn.BackColor = select_color;                    
                    seat_count[3] += seat_count[2];
                    now_click = 2;
                    break;
            }

            if(seat_count[3] > 8) //8명이 넘으면 해당 선택 종류의 값을 0으로 초기화
            {
                MessageBox.Show("8명 까지만 가능");
                switch (button_name[0])
                {
                    case "adult":
                        seat_count[3] -= seat_count[0];
                        seat_count[0] = 0;
                        btn.BackColor = color;                   
                        break;
                    case "teen":
                        seat_count[3] -= seat_count[1];
                        seat_count[1] = 0;
                        btn.BackColor = color;    
                        break;
                    case "kid":
                        seat_count[3] -= seat_count[2];
                        seat_count[2] = 0;
                        btn.BackColor = color;    
                        break;
                }
            }

            if (seat_count[3] < temp_seatarr.Count) //적게 선택하는 경우에 대한 예외처리
            {
                MessageBox.Show("선택된 좌석수보다 작게할 수 없습니다.");
                btn.BackColor = color;
                seat_count[3] -= int.Parse(btn.Text);
                preview[now_click].BackColor = Color.Firebrick;
                seat_count[3] += int.Parse(preview[now_click].Text);
            }
            preview[now_click] = btn;
            total_price.Text = (seat_count[0] * 10000 + seat_count[1] * 8000 + seat_count[2] * 6000).ToString()+"원";

        }
        
      
        private void print_recipt()
        {
            print_pay[3] = "";
            print_seat = "";
            for (int j = 0; j < 3; j++)
            {
                if(j==0){
                     if(seat_count[0] != 0)
                     {
                        print_pay[0] = "성인 X" + (seat_count[0]  * 10000).ToString();
                        print_seatcount[0] = "성인 X" + seat_count[0].ToString();
                     }
                     else
                     {
                         print_pay[0] = null;
                         print_seatcount[0] = null;
                     }                       
                }
                if(j==0){
                     if(seat_count[1] != 0){
                        print_pay[1] = "청소년 X" + (seat_count[1]* 8000).ToString();
                        print_seatcount[1] = "청소년 X" + seat_count[1].ToString();
                     }
                     else
                     {
                         print_pay[1] = null;
                         print_seatcount[1] = null;
                     }                       
                }
                if(j==0){
                     if(seat_count[2] != 0){
                        print_pay[2] = "어린이 X" + (seat_count[2] * 6000).ToString();
                        print_seatcount[2] = "어린이 X" + seat_count[2].ToString();
                     }
                     else
                     {
                         print_pay[2] = null;
                         print_seatcount[2] = null;
                     }                       
                }                 
                
            }
           for(int i=0; i<3 ; i++)
           {
               if (print_pay[i] != null)
                   print_pay[3] += print_pay[i] + "\n";
               if (print_seatcount[i] != null)
                   print_seat += print_seatcount[i] + " ";
           }
           
           print_people.Text = print_seat;
           price.Text = print_pay[3];

        }
     
    }
}
/* 현재 구현은 다 되었는데  인원 추가 선택후에 문제가 발생한다. 그부분 처리를 좀더 생각해보다*/