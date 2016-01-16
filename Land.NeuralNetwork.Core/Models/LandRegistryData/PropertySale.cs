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
        DateTime TransferDate { get; set; }
        string Region { get; set; }
        char PropertyType { get; set; }
        char IsNew { get; set; }
        char Duration { get; set; }
    }
}
