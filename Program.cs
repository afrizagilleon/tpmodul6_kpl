namespace tpmodul6_103022300154
{
    class Program
    {
        public static void Main(string[] args)
        {
            SayaTubeVideo vid = new SayaTubeVideo("mantap jiwa");
            vid.IncreasePlayCount(2);
            vid.PrintVideoDetails();
        }
    }
}