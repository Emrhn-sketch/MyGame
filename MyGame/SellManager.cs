using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class SellManager : ISellService
    {
        public void Sell(Person person, Item item, GameCampaign gameCampaign = null)
        {         
            if (gameCampaign != null)
            {
                Console.WriteLine("{0} oyuncusu tarafından {1} eşyasını {2} kampanyasındaki {3} indirimiyle satın alındı. ", person.FirstName, item.ItemName, gameCampaign.EventName, gameCampaign.Discount);
            }
            else
            {
                Console.WriteLine("{0} oyuncusu tarafından {1} eşyası satın alındı. ", person.FirstName, item.ItemName);
            }

            
        }
    }
}
