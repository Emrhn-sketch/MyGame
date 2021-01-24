using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class MyGameManager : IMyGameService
    {
        private IPlayerService _playerService;
        private ISellService _sellService;
        private IGameCampaignService _gameCampaignService;

        public MyGameManager(IGameCampaignService gameCampaignService)
        {
            _gameCampaignService = gameCampaignService;
        }

        public MyGameManager(ISellService sellService)
        {
            _sellService = sellService;
        }
        public MyGameManager(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public MyGameManager(IPlayerService playerService, ISellService sellService)
        {
            _playerService = playerService;
            _sellService = sellService;
        }
        public MyGameManager(ISellService sellService, IGameCampaignService gameCampaignService)
        {
            _sellService = sellService;
            _gameCampaignService = gameCampaignService;
        }
        public MyGameManager(IPlayerService playerService, ISellService sellService, IGameCampaignService gameCampaignService)
        {
            _playerService = playerService;
            _sellService = sellService;
            _gameCampaignService = gameCampaignService;
        }

        public void BuyItem(Person person, Item ıtem, GameCampaign gameCampaign = null)
        {
            if (_playerService.CheckPlayerExistence(person, person) && gameCampaign != null)
            {
                _sellService.Sell(person, ıtem, gameCampaign);
                _gameCampaignService.Delete(gameCampaign, person);
            }
            else if (_playerService.CheckPlayerExistence(person, person) && gameCampaign == null)
            {
                _sellService.Sell(person, ıtem, gameCampaign);
            }
        }

        public void Login(Person person, Person player)
        {
            if (_playerService.CheckPlayerExistence(person, player))
            {
                Console.WriteLine("Giriş yapıldı. ");
            }
        }
        public void Delete(Person person)
        {
            _playerService.Delete(person);
        }

        public void Register(Person person)
        {
            _playerService.CheckPerson(person);
            _playerService.Add(person);
        }

        public void GetListCampaigns(List<GameCampaign> gameCampaigns)
        {
            _gameCampaignService.GetList(gameCampaigns);
        }
    }
}
