static class WordCounter
{
    public static IEnumerable<KeyValuePair<string, int>> Process(string phrase)
    {
        var wordCounts = new Dictionary<string, int>();

        var words = phrase.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            var key = word;

            if (char.IsPunctuation(key[key.Length - 1]))
            {
                key = key.Remove(key.Length - 1);
            }

            if (wordCounts.TryGetValue(key, out var count))
            {
                wordCounts[key] = count + 1;
            }
            else
            {
                wordCounts.Add(key, 1);
            }
        }

        return wordCounts;
    }
}
