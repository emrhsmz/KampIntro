using GameProject.Entity;
using GameProject.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Manager
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni Bir Kampanya Yayınlandı.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Id + " nolu kampanya silindi.");
        }

        public void Update(Campaign campaign)
        {
            campaign.Name = "Büyük İndirim";
            Console.WriteLine(campaign.Id + " nolu kampanya güncellendi.");
        }
    }
}