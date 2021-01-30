using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISaleService
    {
        public void SellGameWithCampaign(Gamer gamer, Game game, Campaign campaign);
        public void SellGameWithoutCampaign(Gamer gamer, Game game);
    }
}
