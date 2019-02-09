using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class StringFieldDisplayType : Enumeration<StringFieldDisplayType>
    {
        public static readonly StringFieldDisplayType Text = new StringFieldDisplayType(0, "text");
        public static readonly StringFieldDisplayType Number = new StringFieldDisplayType(1, "number");
        public static readonly StringFieldDisplayType Bool = new StringFieldDisplayType(2, "bool");
        
        protected StringFieldDisplayType(int value, string displayName) : base(value, displayName)
        {
        }
    }
}
