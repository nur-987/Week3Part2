using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HcfLcmEvents
{
    class HcmLcmChecker
    {
        public event operation CalculationHcfComplete;
        public event operation CalculationLcmComplete;

        public void FindHcf(int a, int b)
        {
            //action to calculate HCF
            int hcf = 0;
            int j = (a < b) ? a : b;
            for (int i = 1; i <= j; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    hcf = i;
                }
            }

            if (CalculationHcfComplete != null)
            {
                CalculationHcfComplete.Invoke(hcf);
            }
        }

        public void FindLcm(int a, int b)
        {
            //action to calculate HCF
            int x, y;
            int lcm;

            if (a > b)
            {
                x = a;
                y = b;
            }
            else
            {
                x = b;
                y = a;
            }
            for (int i = 1; i <= y; i++)
            {
                if ((x * i) % y == 0)
                {
                    lcm = x * i;
                }
            }
            lcm = y;

            if (CalculationLcmComplete != null)
            {
                CalculationLcmComplete.Invoke(lcm);
            }
        }

    }
}
