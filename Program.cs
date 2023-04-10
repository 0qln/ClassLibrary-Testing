class Program
{
    static void Main(string[] args)
    {
        Debugger.Console console = Debugger.Console.Instaciate;
        console.Log("Test");

        NeatImplementation.NEAT neat = new NeatImplementation.NEAT(3, 3, 10);
        for (int i = 0; i < 1000; i++) {
            neat.NextGeneration();
        }
        float[] output = neat.FeedForward(new float[] {1, 1, 1}, neat.BestGenome());
        
        Console.ReadKey();
    }
}
