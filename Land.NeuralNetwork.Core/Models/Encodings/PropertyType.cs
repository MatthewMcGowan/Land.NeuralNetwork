using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.NeuralNetwork.Core.Models.Encodings
{
    using Helpers.Statics;

    public class PropertyType
    {
        private const int N = 5;

        private PropertyType(int n)
        {
            Value = Encoders.EncodeNonNumericXValue(N, n);
        }

        public int[] Value { get; private set; }


        // D = Detached, 
        public readonly static PropertyType D = new PropertyType(1);
        // S = Semi-Detached
        public readonly static PropertyType S = new PropertyType(2);
        // T = Terraced
        public readonly static PropertyType T = new PropertyType(2);
        // F = Flats/Maisonettes 
        public readonly static PropertyType F = new PropertyType(4);
        // O = Other
        public readonly static PropertyType O = new PropertyType(5);
    }
}
