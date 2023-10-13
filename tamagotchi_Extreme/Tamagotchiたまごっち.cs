namespace Tamagotchiたまごっち;
 class Tamagotchi
{
    public string word;
    bool nullWord=true;
    public int hanger = 0;
    public int bardom =0;
    public List<string> words; 
    public bool isAlive = true;
    public Random generator = new();
    public string name;
    public void Feed()
    {
        hanger --;
        hanger --;
        hanger --;
        if (hanger<0)
        {
            hanger =0;
        }
    }
    public void Hi()
    {
        int length = words.Count();
        generator.Next(0,length);
        Console.WriteLine(words[generator.Next(0,length)]);
        ReduceBoredom();
    }
    public void Teach(string word)
    {
        while (nullWord)
        {
            word = Console.ReadLine();
            if (word == null)
            {
                Console.WriteLine("must contain letter");   
            }
            else if (word != null)
            {
                nullWord = false;
            }
        }
        words.Add(word);
        ReduceBoredom();
    }
    public void Tick()
    {
        hanger ++;
        bardom ++;
    }
    public void PrintStats()
    {
        Console.WriteLine(hanger);
        Console.WriteLine(bardom);
    }
    public bool GetAlive(bool isAlive)
    {
        return isAlive;
    }
    public void ReduceBoredom()
    {
        bardom --;
        bardom --;
        bardom --;
        if (bardom< 0)
        {
            bardom = 0;
        }
    }

}
// − hunger: int
// − boredom: int
// − words: List<string>
// − isAlive: bool
// − generator: Random
// + name: string

// + Feed(): void
// + Hi(): void
// + Teach(word: string): void
// + Tick(): void
// + PrintStats(): void
// + GetAlive(): bool
// − ReduceBoredom(): void

