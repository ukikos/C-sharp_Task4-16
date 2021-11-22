using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_sharp_Task4_16
{
    class DescendantOfTheParty : Party //класс потомок
    {
        private double sizeInLastYear; //дополнительное поле P

        public DescendantOfTheParty(string name, double size, double percentOfVotesInLastYear,
            double sizeInLastYear) : base(name, size, percentOfVotesInLastYear)
        {
            this.sizeInLastYear = sizeInLastYear;
        }

        public override double calculateQ() //Qp
        {
            if (base.Size - sizeInLastYear >= 0)
            {
                return 1.2 * base.calculateQ();
            }
            else
            {
                return 0.8 * base.calculateQ();
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\r\nЧисленность партии в прошлом году: {sizeInLastYear}";
        }
    }
}
