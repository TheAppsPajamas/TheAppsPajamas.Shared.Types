using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class PackagingFieldVersionType : FieldVersionType
    {
        public static readonly PackagingFieldVersionType CurrentVersion = PackagingFieldVersionType.Version1;

        public static readonly PackagingFieldVersionType Undefined = new PackagingFieldVersionType(1, "undefined", "undefined", "undefined");
        public static readonly PackagingFieldVersionType Version1 = new PackagingFieldVersionType(2, "v1.0.0", "Version 1", "undefined");
        
        public PackagingFieldVersionType(int value, string displayName, string versionDescription, string versionLink) : base(value, displayName, versionDescription, versionLink)
        {
        }
    }
}
