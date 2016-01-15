using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.NeuralNetwork.Core.Models.Encodings
{
    using Helpers.Statics;

    public class Region
    {
        #region Private Fields

        private const int N = 9;

        private readonly string name;

        #endregion

        #region Public Fields

        public static readonly Region EastMidlands = new Region(0, "East Midlands");
        public static readonly Region EastOfEngland = new Region(1, "East of England");
        public static readonly Region London = new Region(2, "London");
        public static readonly Region NorthEast = new Region(3, "North East");
        public static readonly Region NorthWest = new Region(4, "North West");
        public static readonly Region SouthEast = new Region(5, "South East");
        public static readonly Region SouthWest = new Region(6, "South West");
        public static readonly Region WestMidlands = new Region(7, "West Midlands");
        public static readonly Region YorkshireAndTheHumber = new Region(8, "Yorkshire and The Humber");

        public static readonly List<Region> All = new List<Region>(9)
                                                      {
                                                          EastMidlands,
                                                          EastOfEngland,
                                                          London,
                                                          NorthEast,
                                                          NorthWest,
                                                          SouthEast,
                                                          SouthWest,
                                                          WestMidlands,
                                                          YorkshireAndTheHumber
                                                      };

        #endregion

        #region Constructors

        private Region(int n, string name)
        {
            Value = Encoders.EncodeNonNumericXValue(N, n);
            this.name = name;
        }

        #endregion

        public int[] Value { get; private set; }

        #region Public Methods

        public override string ToString()
        {
            return name;
        }

        public bool Equals(Region obj)
        {
            return this.name == obj.name && this.Value == obj.Value;
        }

        #endregion
    }
}
