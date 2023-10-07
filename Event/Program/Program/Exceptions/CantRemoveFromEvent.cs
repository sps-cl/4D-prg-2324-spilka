using System;

namespace EventApp.Exceptions
{  
    public class CantRemoveFromEvent : Exception{
        public CantRemoveFromEvent(string message = "Nemůžeš odebírat z neexistujicího eventu.") : base(message){

        }
    }
}