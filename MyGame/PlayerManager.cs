using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class PlayerManager : IPlayerService
    {
        public void Add(Person person)
        {
            Console.WriteLine("Kullanıcı Eklendi. ");
        }

        public void Delete(Person person)
        {
            Console.WriteLine("Kullanıcı Silindi. ");
        }

        public void Update(Person person)
        {
            Console.WriteLine("Kullanıcı Durumu Güncellendi. ");
        }
        public void CheckPerson(Person person)
        {
            Console.WriteLine("Kişi doğrulandı. ");
        }
        public bool CheckPlayerExistence(Person person, Person player)
        {
            if (player == person)
            {
                return true;
            }
            return false;
        }
    }
}
