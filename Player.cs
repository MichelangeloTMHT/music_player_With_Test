using System.Collections.Generic;
using System.Linq;


namespace music_player
{
    public class Player
    {
        /// <summary>
        /// приватный параметр который нельзя на прямую менять  "Cписок песень"
        /// </summary>
        private List<Song> SongsList { get; set; }
         
        /// <summary>
        /// Обьявляю список песень в плеере
        /// </summary>
        public Player ()
        {
            SongsList = new List<Song>();
        }
        
        /// <summary>
        /// Мето добавит песню в список 
        /// </summary>
        /// <param name="song">Имя песни</param>
        public void Add_Song(Song song)
        {
            SongsList.Add(song);
        }
        
        /// <summary>
        /// Метод удалит песню из списка
        /// </summary>
        /// <param name="song">Имя песни</param>
        public void Delete_Song(Song song)
        {
            SongsList.Remove(song);
        }
        
        /// <summary>
        /// Метод вернет список песень
        /// </summary>
        /// <returns></returns>
        public List<Song> Return_List_Song()
        {
            return SongsList;
        }

        /// <summary>
        /// Метод  вернет песню из списка по имени через метод переходник класса Song
        /// </summary>
        /// <param name="name">Имя песни</param>
        /// <returns></returns>
        public Song  Play(string name)
        {
            return SongsList.FirstOrDefault(s => s.Get_Name() == name);
        }

    }
}