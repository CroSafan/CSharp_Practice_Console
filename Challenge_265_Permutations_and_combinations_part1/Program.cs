using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_265_Permutations_and_combinations_part1
{
    class Program
    {
        public static IEnumerable<IEnumerable<T>> Permutations<T>(IEnumerable<T> items, int take = 0)
        {
            if (take == 0) take = items.Count();
            if (take == 1) return items.Select(x => new T[] { x });
            return Permutations(items, take - 1).SelectMany(x => items.Where(y => !x.Contains(y)), (x1, x2) => x1.Concat(new T[] { x2 }));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(string.Concat(Permutations(Enumerable.Range(0, 7)).Skip(3239).Take(1).Single()));

            Console.Read();
        }
    }
}
