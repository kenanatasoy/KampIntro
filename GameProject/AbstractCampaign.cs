using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    abstract class AbstractCampaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public abstract string Discount { get; set; }

    }
}
