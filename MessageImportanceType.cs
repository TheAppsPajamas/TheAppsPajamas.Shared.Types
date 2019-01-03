using TheAppsPajamas.Shared.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class MessageImportanceType : Enumeration<MessageImportanceType>
    {
        public static readonly MessageImportanceType Debug = new MessageImportanceType(0, "Debug");
        public static readonly MessageImportanceType Success = new MessageImportanceType(1, "Success");
        public static readonly MessageImportanceType Information = new MessageImportanceType(2, "Information");
        public static readonly MessageImportanceType Warning = new MessageImportanceType(3, "Warning");
        public static readonly MessageImportanceType Error = new MessageImportanceType(4, "Error");


        protected MessageImportanceType(int value, string displayName) : base(value, displayName)
        {
        }
    }
}
