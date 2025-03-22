namespace tpmodul6_103022300154
{
    public class SayaTubeVideo
    {
        private int id { set; get; }
        private string title { set; get; }
        private int playCount { set; get; }

        public SayaTubeVideo(String title)
        {
            id = new Random().Next(10000, 99999); // id random 5 digit (10000 - 99999)
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int n)
        {
            playCount += n;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"[ {id} ] {title} played {playCount} times");
        }

    }
}
