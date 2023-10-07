using System;

namespace EventApp.Exceptions
{  
    public class CantAddToEvent : Exception{
        public CantAddToEvent(string message = "Nemůžeš přidávat do neexistujicího eventu.") : base(message){}
    }
}