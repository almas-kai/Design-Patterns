namespace Double_Buffer;

class Program
{
    static void Main(string[] args)
    {
        var doubleBuffer = new DoubleBuffer<int[]>(() => new int[10]);

        // Producer.
        Thread producer = new Thread(() =>
        {
            Random rnd = new Random();
            while (true)
            {
                int[] back = doubleBuffer.Back;
                for (int i = 0; i < back.Length; i++)
                {
                    back[i] = rnd.Next(100);
                }

                Console.WriteLine("Back Buffer: " + string.Join(", ", back));

                doubleBuffer.Swap();
                Thread.Sleep(1500);
            }
        });

        // Consumer.
        Thread consumer = new Thread(() =>
        {
            while (true)
            {
                int[] front = doubleBuffer.Front;
                Console.WriteLine("Front buffer: " + string.Join(", ", front));
                Thread.Sleep(1000);
            }
        });

        producer.Start();
        consumer.Start();
    }
}
