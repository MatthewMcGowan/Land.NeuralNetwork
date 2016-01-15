using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.NeuralNetwork.Core.Helpers.Statics
{
    public static class Encoders
    {
        public static int[] EncodeNonNumericXValue(int total, int index)
        {
            int[] values = new int[total - 1];
            if (index == total -1)
            {
                // Special case, last value always -1
                for(int i = 0; i < total - 1; i++)
                {
                    values[i] = -1;
                }
            }
            else
            {
                values[index] = 1;
            }

            return values;
        }

        public static int EncodeBitXValue(int index)
        {
            if (index == 0)
            {
                return 1;
            }
            else if (index == 1)
            {
                return -1;
            }

            throw new IndexOutOfRangeException("0 or 1 expected.");
        }
    }
}
