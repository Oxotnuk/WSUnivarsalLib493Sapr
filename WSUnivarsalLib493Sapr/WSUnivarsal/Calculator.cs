using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUnivarsalLib
{
    public class Calculator
    {

        public double coefProdType = 0;
        public double coefMatrType = 0;

        public double pld = 0;
        public int qualityRaw = 0;
        public int quality = 0;

        public int GetQuantityForProduct(int prodType, int matrType, int count, float width, float length)
        {
            if (count <= 0 || width <= 0 || length <= 0)
            {
                return -1;
            }
            else
            {
                switch (prodType)
                {
                    case 1: coefProdType = 3.5; break;
                    case 2: coefProdType = 2.5; break;
                    case 3: coefProdType = 10.9; break;
                    default: return -1;
                }
                switch (matrType)
                {
                    case 1: coefMatrType = 2.31; break;
                    case 2: coefMatrType = 2.12; break;

                    default: return -1;
                }
                double pld = width * length;
                int qualityRaw = Convert.ToInt32(pld * coefProdType * count);
                int quality = Convert.ToInt32((qualityRaw * coefMatrType) / 100 + qualityRaw);
                return quality;
            }
        }
    }
}
