using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class GameCampaignManager : IGameCampaignService
    {
        public void Add(GameCampaign gameCampaign)
        {
            Console.WriteLine("Kampanya Eklendi. ");
        }

        public void Delete(GameCampaign gameCampaign, Person person)
        {
            Console.WriteLine("{1} Kampanyası {0} Adlı Kullanıcı İçin Silindi. ",person.FirstName,gameCampaign.EventName);
        }

        public void GetList(List<GameCampaign> gameCampaigns)
        {
            foreach (var gameCampaign in gameCampaigns)
            {
                Console.WriteLine(gameCampaign.EventName);
            }
        }

        public void Update(GameCampaign gameCampaign)
        {
            Console.WriteLine("Kampanya Güncellendi. ");
        }
    }
}
