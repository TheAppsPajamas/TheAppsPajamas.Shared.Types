using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class MediaFieldType : FieldType
    {
        public virtual int Width { get; }
        
        public virtual int Height { get; }
        
        public MediaFieldType(string value
            , string displayName
            , ProjectType projectType
            , FieldHolderType fieldHolderType
            , FieldVersionType fieldVersionType
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , MediaFieldType inheritsFromDefault
            , Dictionary<string, string> metadata
            , int width
            , int height = 0
            ) : base(value
                , displayName
                , projectType
                , fieldHolderType
                , fieldVersionType
                , order
                , isForClient
                , isProdReady
                , defaultToDisabled
                , inheritsFromDefault
                , metadata)
        {
            Width = width;
            if (height == 0)
            {
                Height = width;
            }
            else
            {
                Height = height;
            }
        }

    }
}
