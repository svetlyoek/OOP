namespace Stream_Progress
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            IResult music = new Music("Michael Jackson", "Ben", "Moonwalker", 300, 250);
            IResult file = new File("New file", 123, 500);

            var fileProgress = new StreamProgressInfo(file);
            var musicProgress = new StreamProgressInfo(music);

            Console.WriteLine(fileProgress.CalculateCurrentPercent());
            Console.WriteLine(musicProgress.CalculateCurrentPercent());

        }
    }
}
