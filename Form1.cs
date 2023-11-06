
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace music_player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        /// <summary>
        /// Обьект класса Player 
        /// </summary>
         Player ClassPlayer = new Player();
        
        
        /// <summary>
        /// Событие кнопки  добавить песню 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            try
            {
                ClassPlayer.AddSong(new Song(textBoxNameSong.Text, textBoxNameAlbom.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Событите кнопки удалить песню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            try
            {
                Song now = ClassPlayer.Play(textBoxNameSong.Text);
                   ClassPlayer.DeleteSong(now);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        /// <summary>
        /// Coбытие кнопки вернуть список песень 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnSongs_Click(object sender, EventArgs e)
        {
            try
            {     
                  List<Song> songs = ClassPlayer.Return_List_Song();
                  string sonng = "";
                  for (int i = 0; i < songs.Count; i++)
                  {
                      sonng += songs[i].GetName() + "\n";
                  }
                  MessageBox.Show(sonng);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
         
        /// <summary>
        /// Событие кнопки Play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"{ClassPlayer.Play(textBoxNameSong.Text).GetName()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        /// <summary>
        /// Событие кнопки Инфо, покажет из какого альбома какая песня
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoSongs_Click(object sender, EventArgs e)
        {
            List<Song> Songs = ClassPlayer.Return_List_Song();
            string info = "";
            foreach (Song s in Songs)
            {
                info += s.GetInfo().ToString() + "\n";
            }
            MessageBox.Show(info);
        }
    }
}