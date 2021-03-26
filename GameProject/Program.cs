using GameProject.Entity;
using GameProject.Manager;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            Player player = new Player { Id = 1, FirstName = "EMRAH", LastName = "RAMAZAN", BirthYear = 1991, IdentityNumber = 11111111111 };

            playerManager.Add(player);
            playerManager.Update(player);
            playerManager.Delete(player);

            GameManager gameManager = new GameManager();
            Game game = new Game { Id = 1, Name = "Call Of Duty", UnitPrice = 500 };

            gameManager.Add(game);
            gameManager.Update(game);
            gameManager.Delete(game);

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign { Id = 1, Name = "Savaş Oyununda İndirim", Discount = 50 };

            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(player,game);

            saleManager.CampaignSale(player,game,campaign);

        }
    }
}
