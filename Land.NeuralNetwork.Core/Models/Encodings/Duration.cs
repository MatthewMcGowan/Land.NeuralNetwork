using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.NeuralNetwork.Core.Models.Encodings
{
    using Helpers.Statics;

    public class Duration
    {
        private Duration(int n)
        {
            Value = Encoders.EncodeBitXValue(n);
        }

        public int Value { get; private set; }

        // Freehold
        public static Duration F = new Duration(0);
        // Leasehold
        public static Duration L = new Duration(1);
    }
}
