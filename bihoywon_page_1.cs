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


namespace ticket
{
    public partial class bihoywon_page_1 : UserControl
    {
       

        public bihoywon_page_1()
        {

            InitializeComponent();

            string anne;
            anne = "- ***에서는 회원가입하지 않고, 휴대폰 번호, 이름만으로 예매하실 수 있습니다\n";
            string anne_2 = "- 1회 비회원 주문하시면 이후, 처음 사용하신 휴대폰 번호와 비밀번호로 다음에도 비회원 예매를 하실 수 있습니다.\n";
            string anne_3= "- 비회원으로 예매하시면 회원에게 제공되는 마일리지 적립, 이벤트 등 각종 혜택을 이용하실 수 없습니다.\n";

            label2.Text = anne;
            label3.Text = anne_2;
            label4.Text = anne_3; 


        } // 비회원 안내 문구
        public delegate void OnButtonClickedEventHandler(object sender, EventArgs e);

        private OnButtonClickedEventHandler buttonClicked;
        public event OnButtonClickedEventHandler ButtonClicked
        {
            add { buttonClicked += value; }
            remove { buttonClicked -= value; }
        }
        private void buttonClick (object sender, EventArgs e)
        {
            
            if (buttonClicked != null)
                buttonClicked.Invoke("next_nonmember", e);

        }

       
    } // 버튼 보내는거
}
