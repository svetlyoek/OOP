namespace Stream_Progress
{
    public class File : IResult
    {
        public File(string name, int length, int bytesSent)
        {
            this.Name = name;
            this.Length = length;
            this.BytesSent = bytesSent;
        }

        public string Name { get; private set; }

        public int Length { get; private set; }

        public int BytesSent { get; private set; }
    }
}
