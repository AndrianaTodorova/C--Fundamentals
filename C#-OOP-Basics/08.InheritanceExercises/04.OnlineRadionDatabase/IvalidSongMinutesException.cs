using System;
public class IvalidSongMinutesException : InvalidSongLengthException
{
    private const string Message = "Song minutes should be between 0 and 14.";
    public IvalidSongMinutesException()
        : base(Message)
    {

    }

    public IvalidSongMinutesException(string message)
        : base(message)
    {
    }
}