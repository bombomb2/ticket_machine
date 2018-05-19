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
    public partial class page2 : UserControl
    {
       
        public page2()
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
       
        private void button2_clicked(object sender, EventArgs e)
        {
            if (buttonClicked != null)
            {
             
                string temp = sender.ToString();
                string[] temp_arr = temp.Split(' ');                
                buttonClicked.Invoke(temp_arr[temp_arr.Length - 1], e);
             
               
            }
        }

    }
}
