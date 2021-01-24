using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    interface IPlayerService
    {
        void Add(Person person);
        void Update(Person person);
        void Delete(Person person);
        void CheckPerson(Person person);
        bool CheckPlayerExistence(Person person, Person player);
    }
}
