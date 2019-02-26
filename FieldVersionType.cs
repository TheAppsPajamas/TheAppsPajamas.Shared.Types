using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class FieldVersionType : Enumeration<FieldVersionType>
    {

        public string VersionDescription { get; }
        public string VersionLink { get; }

        public FieldVersionType(int value, string displayName, string versionDescription, string versionLink) : base(value, displayName)
        {
            VersionDescription = versionDescription;
            VersionLink = versionLink;
        }
    }
}
