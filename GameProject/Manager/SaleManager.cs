using GameProject.Entity;
using GameProject.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Manager
{
    class SaleManager : ISaleService
    {
        public void CampaignSale(Player player, Game game, Campaign campaign)
        {
            int discount = game.UnitPrice - ((game.UnitPrice * campaign.Discount) / 100);
            Console.WriteLine(game.Name + " adlı oyunu " + player.FirstName + " " + player.LastName + " % " + campaign.Discount + " indirimle satın aldı");
        }

        public void Sale(Player player, Game game)
        {
            Console.WriteLine(game.Name + " adlı oyunu " + player.FirstName + " " + player.LastName + " satın aldı");
        }
    }
}
