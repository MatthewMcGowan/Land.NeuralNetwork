using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.NeuralNetwork.Core.Models.Encodings
{
    using Helpers.Statics;

    public class IsNew
    {
        private IsNew(int n)
        {
            Value = Encoders.EncodeBitXValue(n);
        }

        public int Value { get; private set; }

        public static IsNew Y = new IsNew(0);
        public static IsNew N = new IsNew(1);
    }
}
