using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_sharp_Task4_16
{
    class Party //класс родитель
    {
        private string name;
        private double size;
        private double percentOfVotesInLastYear;

        public double Size //публичное свойство нужно для доступа к приватному полю из класса-потомка
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        public Party(string name, double size, double percentOfVotesInLastYear)
        {
            this.name = name;
            this.size = size;
            this.percentOfVotesInLastYear = percentOfVotesInLastYear;
        }

        public virtual double calculateQ() //Q
        {
            return 0.3 * size + 0.7 * percentOfVotesInLastYear;
        }

        public override string ToString()
        {
            return $"Название партии: {name}\r\nЧисленность партии(тыс. членов): {size}\r\nПроцент голосов на последних выборах: {percentOfVotesInLastYear}%";
        }
    }
}
