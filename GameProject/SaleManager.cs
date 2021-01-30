using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager : ISaleService
    {
        public void SellGameWithCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(game.Title + "sold to " + gamer.FirstName + "with " + campaign.Name);
        }
        public void SellGameWithoutCampaign(Gamer gamer, Game game)
        {
            Console.WriteLine(game.Title + "sold to " + gamer.FirstName);
        }
    }
}
