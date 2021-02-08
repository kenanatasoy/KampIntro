using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.BirthYear = 1985;
            gamer.FirstName = "Kerem";
            gamer.LastName = "Akkiraz";
            gamer.IdentityNumber = 12345;

            GamerManager gamerManager = new GamerManager(new NewStateUserValidationManager());
            gamerManager.Add(gamer);

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.Name = "TwoInOne";
            campaign.Type = "Small Campaign";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            Game game = new Game();
            game.Id = 1;
            game.Price = "€8";
            game.Category = "Flight Simulator";
            game.Title = "MSFS 2020";

            SaleManager saleManager = new SaleManager();
            saleManager.SellGameWithCampaign(gamer, game, campaign);
            saleManager.SellGameWithoutCampaign(gamer, game);

            Console.WriteLine();
            
        }
    }
}
