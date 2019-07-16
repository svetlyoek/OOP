namespace Stream_Progress
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface IResult
    {
        int Length { get; }

        int BytesSent { get; }
    }
}
