Dictionary<int, string> entries = new Dictionary<int, string>();

double PythagarosThereom(int a, int b)
{
    double c = Math.Pow(a, 2) + Math.Pow(b, 2);
    return Math.Sqrt(c);
}

for(int i = 1; i < 101; i++)
{
    for(int j = 1; j < 101; j++)
    {
        double result = PythagarosThereom(i, j);
        if(result % 1 == 0)
        {
            int intResult = (int)(i * j * result);

            if (!entries.ContainsKey(intResult))
            {
                string combos = "a = " + i + ", b = " + j + ", c = " + result;

                entries.Add(intResult, combos);
            }
        }
    }
}

foreach(string v in entries.Values)
{
    Console.WriteLine(v);
}

Console.WriteLine("Count: " + entries.Count());