Solution solution = new();

var indexes = solution.FindAnagrams("baa", "aa");

foreach(var index in indexes) Console.WriteLine(index);
