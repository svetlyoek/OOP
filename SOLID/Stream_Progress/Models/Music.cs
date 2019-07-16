namespace Stream_Progress
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Music : IResult
    {
        public Music(string artist, string album, string name, int length, int bytesSent)
        {
            this.Artist = artist;
            this.Album = album;
            this.Name = name;
            this.Length = length;
            this.BytesSent = bytesSent;
        }

        public string Artist { get; private set; }

        public string Album { get; private set; }

        public string Name { get; private set; }

        public int Length { get; private set; }

        public int BytesSent { get; private set; }
    }
}
