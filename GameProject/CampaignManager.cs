using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " updated");
        }

    }
}
