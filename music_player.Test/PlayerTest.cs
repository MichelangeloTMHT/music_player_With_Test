using Xunit;

namespace music_player.Test
{
    public class PlayerTest
    {
        // трибутом факт указываем на тестовый метод 
        // Метод должен называться именем метода + Тест 
        // Но, так как PlayerTest - Это имя проекта, назвать метод мы так не можем 
        [Fact]
        public void PlayerConstructorTest()
        {
            //Создаём обьект класса плейер
            Player player = new Player();
            
            //И проверяем его на нулл,  подавая список песень в метод NotNull();

            Assert.NotNull(player.ReturnListSong());
        }

        [Fact]
        public void GetNameTest()
        {
            Song song = new Song("Mockingbird","Encore");
            
            Assert.Equal("Mockingbird",song.GetName());
        }
    }
    public class SongTest
     {
        [Fact]
        public void GetInfoTest()
        {
            Song song = new Song("Mockingbird","Encore");
            
            Assert.Equal("Name: Mockingbird | Albom: Encore" ,song.GetInfo());
        }
    }
}