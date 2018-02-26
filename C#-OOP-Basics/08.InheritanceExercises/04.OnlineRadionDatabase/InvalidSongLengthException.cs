using System;
public class InvalidSongLengthException : InvalidSongException
{
    private const string Message = "Song length should be between 0 second and 14 minutes and 59 seconds.";
    public InvalidSongLengthException()
        : base(Message)
    {

    }

    public InvalidSongLengthException(string message)
        : base(message)
    {
    }
}