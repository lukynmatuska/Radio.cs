using System;
using System.Collections.Generic;
using System.Text;

namespace RadioTemplate.Exceptions
{
    public class RadioBankruptException : Exception
    {
        public RadioBankruptException() : base("Rádio zbankrotovalo")
        {
            ;
        }
    }
}
