using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu kayıt edildi." + '\n');
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız!.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu silindi!" + '\n');
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu güncellendi." + '\n');
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız! Güncelleme başarısız!.");
            }
        }
    }
}