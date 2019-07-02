using System;

namespace StdTask.Events
{
    public class ExceptionEventArgs : EventArgs
    {
        public ExceptionEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}
