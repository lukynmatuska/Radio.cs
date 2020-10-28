using System;
using System.Collections.Generic;
using System.Text;

namespace RadioTemplate.Exceptions
{
    public class RadioNoModeratorException : Exception
    {
        public RadioNoModeratorException() : base("There isn't any moderator in this radio!")
        {
            ;
        }
    }
}
