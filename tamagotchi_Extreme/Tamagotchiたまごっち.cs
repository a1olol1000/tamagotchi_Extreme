
public class Tamagotchiたまごっち
{
    public int hanger = 0;
    public int bardom =0;
    public List<string> words; 
    public bool isAlive = true;
    public Random generator;
    public string name;
    public void Feed()
    {
        hanger --;
        hanger --;
        hanger --;
    }
    public void Hi()
    {
        
    }
    public void Teach(string word)
    {

    }
    public void Tick()
    {

    }
    public void PrintStats()
    {

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

