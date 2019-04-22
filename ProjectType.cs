using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class ProjectType : Enumeration<ProjectType>
    {
        public static readonly ProjectType Undefined = new ProjectType(0, "Undefined", 0);
        public static readonly ProjectType Shared = new ProjectType(1, "Shared", 1);
        public static readonly ProjectType Library = new ProjectType(4, "Library", 2);
        public static readonly ProjectType Droid = new ProjectType(2, "Droid", 3);
        public static readonly ProjectType Ios = new ProjectType(3, "Ios", 4);

        public ProjectType(int value, string displayName, int order) : base(value, displayName) {
            Order = order;
        }

        public int Order { get; }
    }
}
