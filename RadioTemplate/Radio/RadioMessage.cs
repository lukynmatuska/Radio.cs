using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RadioTemplate.Radio
{
    public class RadioMessage
    {
        public RadioMessageType MessageType { get; }
        public string Message { get; }
        public string Moderator { get; }

        public RadioMessage(RadioMessageType messageType, string message, string moderator)
        {
            MessageType = messageType;
            Message = message;
            Moderator = moderator;
        }
    }
}
