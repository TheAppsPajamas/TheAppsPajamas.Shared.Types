using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class AppIconFieldVersionType : FieldVersionType
    {
        public static readonly AppIconFieldVersionType CurrentVersion = AppIconFieldVersionType.Version1;

        public static readonly AppIconFieldVersionType Undefined = new AppIconFieldVersionType(1, "undefined", "undefined", "undefined");
        public static readonly AppIconFieldVersionType Version1 = new AppIconFieldVersionType(2, "v1.0.0", "Version 1", "undefined");
        
        public AppIconFieldVersionType(int value, string displayName, string versionDescription, string versionLink) : base(value, displayName, versionDescription, versionLink)
        {
        }
    }
}
