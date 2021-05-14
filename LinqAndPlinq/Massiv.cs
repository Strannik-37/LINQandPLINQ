using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndPlinq
{
    class Massiv
    {
        public string[] mass;
        public void Generate(int size)
        {
            Random rnd = new Random();
            mass = new string[size];
            for(int i = 0; i < size; i++)
            {
                mass[i] = rnd.Next().ToString();
            }
        }
        public string [] EvenNumbers()
        {
            string[] rez;
            rez = mass.Where(s => Convert.ToInt32(s.Last()) % 2 == 0).OrderByDescending(s=>Convert.ToInt32(s)).ToArray();
            return rez;
        }
        public string[] EvenNumbers_Parallel()
        {
            string[] rez;
            rez = mass.AsParallel().Where(s => Convert.ToInt32(s.Last()) % 2 == 0).OrderByDescending(s => Convert.ToInt32(s)).ToArray();
            return rez;
        }
        public string[] OddNumbers()
        {
            string[] rez;
            rez = mass.Where(s => Convert.ToInt32(s.Last()) % 2 == 1).OrderByDescending(s => Convert.ToInt32(s)).ToArray();
            return rez;
        }
        public string[] OddNumbers_Parallel()
        {
            string[] rez;
            rez = mass.AsParallel().Where(s => Convert.ToInt32(s.Last()) % 2 == 1).OrderByDescending(s => Convert.ToInt32(s)).ToArray();
            return rez;
        }
        public string[] SummUpperSix()
        {
            string[] rez;
            rez = mass.Where(s => s.Length > 3 && Convert.ToInt32(Convert.ToString(s[1])) + Convert.ToInt32(Convert.ToString(s[s.Length - 2])) == 6).OrderByDescending(s => Convert.ToInt32(s)).ToArray();
            return rez;
        }
        public string[] SummUpperSix_Parallel()
        {
            string[] rez;
            rez = mass.AsParallel().Where(s => s.Length > 3 && Convert.ToInt32(Convert.ToString(s[1])) + Convert.ToInt32(Convert.ToString(s[s.Length - 2])) == 6).OrderByDescending(s => Convert.ToInt32(s)).ToArray();
            return rez;
        }
        public string[] SumDigitsThirteen()
        {
            string[] rez;
            rez = mass.Where(s => s.Sum(x => Convert.ToInt32(Convert.ToString(x))) == 13).OrderByDescending(s => Convert.ToInt32(s)).ToArray();
            return rez;
        }
        public string[] SumDigitsThirteen_Parallel()
        {
            string[] rez;
            rez = mass.AsParallel().Where(s => s.Sum(x => Convert.ToInt32(Convert.ToString(x))) == 13).OrderByDescending(s => Convert.ToInt32(s)).ToArray();
            return rez;
        }
    }
}
