namespace Stream_Progress
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class StreamProgressInfo
    {
        private readonly IResult file;
        public StreamProgressInfo(IResult file)
        {
            this.file = file;
        }

        public int CalculateCurrentPercent()
        {
            return (this.file.BytesSent * 100) / this.file.Length;
        }
    }
}
