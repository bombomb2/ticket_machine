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
    public partial class selction : UserControl
    {
        SQLiteConnection conn = null;//db쓰자
        public selction()
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
        private void buttonClick(object sender, EventArgs e)
        {
            Button btn;
            btn = sender as Button;
            buttonClicked.Invoke(btn.Text, e);

        }    
    }
}
