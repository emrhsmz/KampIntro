using GameProject.Entity;
using GameProject.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Manager
{
    //MicroService
    class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.Validate(player)==true)
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " Başarıyla Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız. Kayıt olunamadı.");
            }
            
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " Başarıyla Güncellendi");
        }

        public void Update(Player player)
        {
            player.FirstName = "Emrah";
            player.LastName = "Semiz";
            Console.WriteLine(player.FirstName + " " + player.LastName + " Başarıyla Silindi");
        }
    }
}
