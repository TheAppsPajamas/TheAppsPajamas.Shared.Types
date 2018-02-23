
using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class MediaOrientationType : Enumeration<MediaOrientationType>
    {
        public readonly static MediaOrientationType Portrait = new MediaOrientationType(0, "Portrait");
        public readonly static MediaOrientationType Landscape = new MediaOrientationType(1, "Landscape");

        protected MediaOrientationType(int value, string displayName) : base(value, displayName)
        {
        }
    }
}
