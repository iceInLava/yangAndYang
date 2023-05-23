using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 鸡了个鸡
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameObjectManager.form1 = this;
        }

        private void btn_level1_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Game_play fGP = new Form_Game_play(1);
        }

        private void btn_level2_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Game_play fGP = new Form_Game_play(2);
        }

        private void btn_level3_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Game_play fGP = new Form_Game_play(3);
        }
    }
}
