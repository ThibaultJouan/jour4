using System.Diagnostics;

Stopwatch sw = new Stopwatch();
sw.Start();
var input = File.ReadAllLines("input.txt");
int result = 0;
/*foreach(string s in input)
{
    result += Traitement.Part1(s);
}*/

Traitement traitement = new Traitement(input);
result = traitement.Part2();
sw.Stop();
Console.WriteLine(sw.Elapsed);
Console.WriteLine(result);
