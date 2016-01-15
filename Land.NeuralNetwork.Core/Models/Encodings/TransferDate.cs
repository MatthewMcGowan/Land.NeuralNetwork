using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.NeuralNetwork.Core.Models.Encodings
{
    public class TransferDate
    {
        public TransferDate(DateTime transferDate, decimal mean, decimal stdDev)
        {
            Value = (transferDate.Ticks - mean) / stdDev;
        }

        public decimal Value { get; private set; }
    }
}
