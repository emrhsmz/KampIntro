using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Service
{
    interface ISaleService
    {
        void Sale(Player player, Game game);
        void CampaignSale(Player player, Game game, Campaign campaign);
    }
}
