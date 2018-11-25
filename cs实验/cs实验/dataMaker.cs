using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs实验
{
    class dataMaker
    {
        public List<double> list = new List<double>();
        public dataMaker()
        {
            Random random = new Random();
            list = making(random, 9);
            list.ForEach(Console.Write);
            Console.WriteLine();
        }


        public List<double> making(Random random, int num)
        {
            List<double> list = new List<double>();
            for (int i = 1; i <= num; ++i)
            {
                double tmp = Math.Round(random.NextDouble() * 10 + 1, 2);
                list.Add(tmp);
            }
            return list;
        }
    }
}
