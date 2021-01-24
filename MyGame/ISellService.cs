using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    interface ISellService
    {
        void Sell(Person person, Item item, GameCampaign gameCampaign=null);
    }
}
