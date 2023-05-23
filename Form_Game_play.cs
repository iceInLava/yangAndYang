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
    public partial class Form_Game_play : Form
    {
        GameObjectManager game;
        public Form_Game_play(int level)
        {
            InitializeComponent();
            GameObjectManager.fgp = this;
            panel_menu.Hide();
            wmp_bgm.URL = "musics/bgm.mp3";
            wmp_bgm.settings.volume = 10;
            wmp_bgm.settings.setMode("loop", true);
            trackBar_volume.Value = 10;

            wmp_effect.settings.volume = 10;
            trackBar_effect.Value = 10;
            Show();
            game = new GameObjectManager(level);
            timer1.Start();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            wmp_bgm.Ctlcontrols.play();
            game.Init_buttons();
            game.Show_buttons(game);
            game.Active_btn();
            btn_start.Enabled = false;
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            game.isGameRunning = false;
            
            game.Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btn_restart.Enabled = game.isGameRunning;
            lbl_score_value.Text = game.score.ToString();
            if (panel_menu.Visible)
            {
                lbl_volume_value.Text = trackBar_volume.Value.ToString();
                wmp_bgm.settings.volume = trackBar_volume.Value;
                lbl_effect_value.Text = trackBar_effect.Value.ToString();
                wmp_effect.settings.volume = trackBar_effect.Value;
            }
            //lbl_volume_value.Text = trackBar_vol.Value.ToString();
        }

        private void Form_Game_play_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btn_settings_Click_1(object sender, EventArgs e)
        {
            if(panel_menu.Visible == false)
            {
                panel_menu.BringToFront();
                panel_menu.Visible = true;
            }
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            panel_menu.Hide();
        }

        private void btn_back_to_title_Click(object sender, EventArgs e)
        {
            Hide();
            GameObjectManager.form1.Show();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
