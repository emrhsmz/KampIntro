using GameProject.Entity;
using GameProject.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Manager
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Yeni Oyun Eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Id + " nolu oyun silindi.");
        }

        public void Update(Game game)
        {
            game.Name = "PES 2021";
            Console.WriteLine(game.Id + " nolu oyun güncellendi.");
        }
    }
}
