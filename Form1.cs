using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_TínhCanChi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { string chi = "";
            switch( Convert.ToInt32(txtNam.Text)%12) 
            {
                case 0:
                    chi = "Thân";
                        break;
                case 1:
                    chi = " Dậu";
                    break;
                    case 2:
                    chi = "Tuất";
                    break;
                case 3:
                    chi = "Hợi";
                    break;
                    case 4:
                    chi = "tý";
                    break;
                    case 5:
                    chi = "Sửu";
                    break;
                    case 6:
                    chi = "Dần";
                    break;
                    case 7:
                    chi = "Não";
                    break;
                    case 8:
                    chi = "Thìn";
                        break;
                case 9:
                    chi = "Ty";
                        break;
                    case 10:
                    chi = "Ngọ";
                    break;
                    case 11:
                    chi = "Mùi";
                    break;





            }
            string can = "";
            switch (Convert.ToInt32(txtNam.Text) % 10) {
                case 0:
                    can = "Canh";
                    break;
                case 1:
                    can = " Tân ";
                    break;
                case 2:
                    can = "Nhâm";
                    break;
                case 3:
                    can = "Quý";
                    break;
                case 4:
                    can = "Giáp";
                    break;
                case 5:
                    can = "Ất";
                    break;
                case 6:
                    can = "Bính";
                    break;
                case 7:
                    can = "Đinh";
                    break;
                case 8:
                    can = "Mậu";
                    break;
                case 9:
                    can = "Kỷ";
                    break;








            }


            txtKQ.Text = can + "" + chi;
        }
    }
}
