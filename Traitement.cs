
class Traitement
{
    string[] Input {get; set;}
    public Traitement(string[] inputs)
    {
        Input = inputs;
    }
    public int Part2()
    {
        List<String> total = new List<string>(Input);
        List<String> buffer = new List<string>();

        for(int x = 0; x < total.Count; x++)
        {
            int truc = HowMany(total[x]);
            int here = int.Parse(total[x].Substring(5, total[x].IndexOf(':')-5));

            for(int i = here; i <= here + truc - 1; i++)
            {
                buffer.Add(Input[i]);
            }
            total.AddRange(buffer);
            buffer = new List<string>();
        }

        return total.Count;
    }
    public static int Part1(string input)
    {
        string[] winning;
        string[] numbers;
        int res = 1;

        string buffer = input.Replace("  ", " ").Substring(input.IndexOf(':')+1);
        string[] split = buffer.Split('|');

        winning = split[0].Trim().Split(' ');
        numbers = split[1].Trim().Split(' ');

        string[] result = winning.Intersect(numbers).ToArray(); 

        if(result.Length < 2)
        {
            return result.Length;
        }

        for(int i = 1; i < result.Length; i++)
        {
            res *= 2;
        }

        return res;
    }

    public static int HowMany(string input)
    {
        string[] winning;
        string[] numbers;

        string buffer = input.Replace("  ", " ").Substring(input.IndexOf(':')+1);
        string[] split = buffer.Split('|');

        winning = split[0].Trim().Split(' ');
        numbers = split[1].Trim().Split(' ');

        string[] result = winning.Intersect(numbers).ToArray(); 

        return result.Length;
    }
}