using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhamVanLeBao_2001170836_AppSmart_BT2
{
    public partial class Form1 : Form
    {
        Panel pnGame = new Panel();
        Random rnd = new Random();
        //check if 2 picture same same 
        string isDisable;
        // just open 2 button
        int dem = 0;
        int verticalBtn1 = 0;
        int horizaltalBtn1 = 0;
        // list add picture number;
        List<string> listPic = new List<string>();

        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        public Form1()
        {
            InitializeComponent();
            InitializePanel();
        }

        private void btnCreatePic_Click(object sender, EventArgs e)
        {

        }

        private void InitializePanel()
        {
            pnGame.Size = new Size(970, 400);
            pnGame.BackColor = Color.White;
            pnGame.Top = 150;
            pnGame.Left = 10;
            this.Controls.Add(pnGame);

            
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            HandleWinandLost(btn);
        }
        private void HandleWinandLost(Button btn)
        {
            dem++;
            
            //call vertical location of  button click   hang doc X
            int vertical = Convert.ToInt32(btn.Tag);
            int vertical2 = vertical;
            //call horizontal location of  button click hang ngang Y
            int horizontal = Matrix[vertical].IndexOf(btn);
            int horizontal2 = horizontal;

            btn.Text = Matrix[vertical][horizontal].Name;
            if(dem == 1)
            {
                verticalBtn1 = vertical;
                horizaltalBtn1 = horizontal;
                isDisable = btn.Text;
            }
               
            if(dem == 2)
            {
                if (btn.Name != isDisable)
                {
                    //Matrix[verticalBtn1][horizaltalBtn1].Text = 
                }
                else
                {
                    
                }
            }


        }
        private void EffectBtn(Button btn)
        {
            //PhamVanLeBao_2001170836_AppSmart_BT2.sh
        }
        private void txtMaxMatrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm  , bo di la khong co dau cham
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMaxMatrix_TextChanged(object sender, EventArgs e)
        {
            if (txtMaxMatrix.Text == "")
            {
                txtMaxMatrix.Text = "0";
            }
            int txtCapMTparse = int.Parse(txtMaxMatrix.Text.ToString());
            if (txtCapMTparse > 3)
                txtMaxMatrix.Enabled = true;
            else
                txtMaxMatrix.Enabled = false;
            if (txtCapMTparse > 20)
                txtMaxMatrix.Enabled = false;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            int left = 3;
            int top = 10;
            for (int i = 0; i < int.Parse(txtMaxMatrix.Text.ToString()); i++)
            {
                //add picture number
                listPic.Add(i.ToString());
                for (int j = 0; j < int.Parse(txtMaxMatrix.Text.ToString()); j++)
                {
                    Button btnPoint = new Button();
                    btnPoint.Size = new Size(50, 50);
                    btnPoint.Left = left + 33;
                    btnPoint.Top = top;
                    left += 55;
                    btnPoint.BackColor = Color.Gray;
                    btnPoint.Name = listPic[rnd.Next(listPic.Count)];
                    //set up vertical for button;
                    btnPoint.Tag = i.ToString();

                    this.pnGame.Controls.Add(btnPoint);
                    //set up handler click event
                    btnPoint.Click += btn_Click;
                }
            }
        }
    }
}
