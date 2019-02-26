using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class BuildConfigRecordSetFieldVersionType : FieldVersionType
    {
        public static readonly BuildConfigRecordSetFieldVersionType CurrentVersion = BuildConfigRecordSetFieldVersionType.Version1;

        public static readonly BuildConfigRecordSetFieldVersionType Undefined = new BuildConfigRecordSetFieldVersionType(1, "undefined", "undefined", "undefined");
        public static readonly BuildConfigRecordSetFieldVersionType Version1 = new BuildConfigRecordSetFieldVersionType(2, "v1.0.0", "Version 1", "undefined");
        
        public BuildConfigRecordSetFieldVersionType(int value, string displayName, string versionDescription, string versionLink) : base(value, displayName, versionDescription, versionLink)
        {
        }
    }
}
