﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 鸡了个鸡
{
    internal class MyButton : Button
    {
        /// <summary>
        /// 当前游戏的GameObjectManager
        /// </summary>
        public GameObjectManager this_game;
        /// <summary>
        /// button图片的URL
        /// </summary>
        public string URL;
        /// <summary>
        /// button的标签， 可以用来判断是否为同种类型的button
        /// </summary>
        public string tag;
        /// <summary>
        /// button Type 的列表，实现索引与string的转换
        /// </summary>
        public string[] buttonTypes =
        {
            "doge",
            "crazy",
            "carrot",
            "doge",
            "rabbit",
            "zh"
        };
        /// <summary>
        /// 这个button在button列表中的索引值
        /// </summary>
        public int btn_index;

        public int grid_x_btn;
        public int grid_y_btn;
        public int grid_z_btn;
        public MyButton()
        {
            this.Size = new Size(65, 65);
            tag = buttonTypes[0];
            URL = "images/" + tag + ".png";
        }
        /// <summary>
        /// MyButton 的有参构造函数
        /// </summary>
        /// <param name="btn_wide">按钮的宽度</param>
        /// <param name="btn_high">按钮的高度</param>
        /// <param name="btn_type">按钮的类型：0 doge，1 hj，2 lh，3 lyj，4 miao，5 zh（你最好别乱写（杀心渐起））</param>
        public MyButton(int btn_wide, int btn_high, int btn_type)
        {
            Size = new Size(btn_wide, btn_high);
            tag = buttonTypes[btn_type];
            URL = "images/" + tag + ".png";
            this.Click += Button_click;
        }

        /// <summary>
        /// 芝士雪豹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_click(object sender, EventArgs e)
        {

            this_game.Click_btn_to_result(((MyButton)sender).btn_index);
            ((MyButton)sender).Hide();
            this_game.Active_btn();
            this_game.Check_clean_or_lose();
        }
    }
}
