using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odevim
{
    public abstract class FruitBase
    {
        public string FruitName { get; set; }
        public float Weight { get; set; }
        public float VitaminAFor100g { get; set; }
        public float VitaminCFor100g { get; set; }
        public float CalculatedVitaminA { get; set; }
        public float CalculatedVitaminC { get; set; }
        public int YieldMin { get; set; }
        public int YieldMax { get; set; }        
        public bool isCitrus { get; set; }
        public int ImageIndex { get; set; }
    }
}
