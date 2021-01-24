using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    interface IMyGameService
    {
        void Register(Person person);
        void Login(Person person, Person player);
        void Delete(Person person);
        void BuyItem(Person person, Item ıtem, GameCampaign gameCampaign=null);
        void GetListCampaigns(List<GameCampaign> gameCampaigns);
    }
}
