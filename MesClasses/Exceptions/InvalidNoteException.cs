using System;

namespace MesClasses.Exceptions
{
    class InvalidNoteException : Exception
    {
        public InvalidNoteException(string message) : base(message)
        {
        }
    }
}
