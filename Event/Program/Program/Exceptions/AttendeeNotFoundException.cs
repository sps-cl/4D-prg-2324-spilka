using System;

namespace EventApp.Exceptions
{  
    public class AttendeeNotFoundException : Exception{
        public AttendeeNotFoundException(string message = "Wrong attende type") : base(message){}
    }
}