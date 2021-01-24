using System;
using System.Collections.Generic;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person()
            {
                Id = 1,
                FirstName = "Emirhan",
                LastName = "Çetin",
                TcNo = "TcNo",
                YearofBirth = 1996,
                Role = "Player"
            };
            Person player1 = new Person()
            {
                Id = 1,
                FirstName = "Emirhan",
                LastName = "Çetin",
                TcNo = "TcNo",
                YearofBirth = 1996,
                Role = "Player"
            };

            Item item1 = new Item()
            {
                Id = 2,
                ItemName = "Abc",
                Price = 100,
                StockAmount = 25

            };
            Item item2 = new Item()
            {
                Id = 3,
                ItemName = "Abcd",
                Price = 120,
                StockAmount = 30

            };
            GameCampaign gameCampaign1 = new GameCampaign()
            {
                Id = 4,
                EventName = "Etkinlik1",
                EventTime = DateTime.Now,
                Discount = 20
            };
            GameCampaign gameCampaign2 = new GameCampaign()
            {
                Id = 5,
                EventName = "Etkinlik2",
                EventTime = DateTime.Now,
                Discount = 30
            };
            GameCampaign gameCampaign3 = new GameCampaign()
            {
                Id = 6,
                EventName = "Etkinlik3",
                EventTime = DateTime.Now,
                Discount = 40
            };
            GameCampaign gameCampaign4 = new GameCampaign()
            {
                Id = 7,
                EventName = "Etkinlik4",
                EventTime = DateTime.Now,
                Discount = 50
            };
            List<GameCampaign> gameCampaigns = new List<GameCampaign> { gameCampaign4, gameCampaign3, gameCampaign2, gameCampaign1 };

            IMyGameService myGameManager = new MyGameManager
                (
                new PlayerManager(), new SellManager(), new GameCampaignManager()
                );

            myGameManager.Register(person1);
            myGameManager.Login(person1, player1);
            myGameManager.GetListCampaigns(gameCampaigns);
            myGameManager.BuyItem(person1, item2);
            myGameManager.BuyItem(player1, item1, gameCampaign4);
            myGameManager.Delete(player1);
        }
    }
}
