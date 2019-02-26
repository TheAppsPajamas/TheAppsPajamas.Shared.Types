using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class SplashFieldVersionType : FieldVersionType
    {
        public static readonly SplashFieldVersionType CurrentVersion = SplashFieldVersionType.Version1;

        public static readonly SplashFieldVersionType Undefined = new SplashFieldVersionType(0, "undefined", "undefined", "undefined");
        public static readonly SplashFieldVersionType Version1 = new SplashFieldVersionType(1, "v1.0.0", "Splash Version 1", "undefined");
        
        public SplashFieldVersionType(int value, string displayName, string versionDescription, string versionLink) : base(value, displayName, versionDescription, versionLink)
        {
        }
    }
}
