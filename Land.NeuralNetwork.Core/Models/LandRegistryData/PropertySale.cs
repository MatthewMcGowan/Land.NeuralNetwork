using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.NeuralNetwork.Core.Models.LandRegistryData
{
    using Encodings;

    public class PropertySale
    {
        decimal Price { get; set; }
        TransferDate TransferDate { get; set; }
        Region Region { get; set; }
        PropertyType PropertyType { get; set; }
        IsNew IsNew { get; set; }
        Duration Duration { get; set; }
    }
}
