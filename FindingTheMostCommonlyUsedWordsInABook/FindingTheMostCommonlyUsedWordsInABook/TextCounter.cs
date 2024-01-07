using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindingTheMostCommonlyUsedWordsInABook
{
    public class TextCounter
    {
        private readonly HashSet<string> _stopWords;

        public TextCounter(string stopWordPath)
        {
            Console.WriteLine($"Reading stop word file: {stopWordPath}");
            _stopWords = new HashSet<string>(File.ReadAllLines(stopWordPath));
        }

        public IEnumerable<Tuple<string, int>> Process(string text, int maximumWords)
        {
            var words = Regex
                .Split(text.ToLower(), @"\s+")
                .Where(t => !_stopWords.Contains(t))
                .GroupBy(t => t)
                .Select(grp => Tuple.Create(grp.Key, grp.Count()))
                .OrderByDescending(tup => tup.Item2) //int
                .Take(maximumWords);

            return words;
        }
    }
}
