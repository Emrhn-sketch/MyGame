using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    interface IGameCampaignService
    {
        void GetList(List<GameCampaign> gameCampaigns);
        void Add(GameCampaign gameCampaign);
        void Delete(GameCampaign gameCampaign,Person person);
        void Update(GameCampaign gameCampaign);
    }
}
