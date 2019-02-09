using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class StringFieldType : FieldType
    {
        public StringFieldDisplayType FieldDisplayType { get; }
        public string DefaultValue { get; }

        public StringFieldType(string value
            , string displayName
            , ProjectType projectType
            , FieldHolderType fieldHolderType
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , StringFieldType inheritsFromDefault
            , StringFieldDisplayType fieldDisplayType
            , string defaultValue) : base(value, displayName, projectType, fieldHolderType, order, isForClient, isProdReady, defaultToDisabled, inheritsFromDefault)
        {
            FieldDisplayType = fieldDisplayType;
            DefaultValue = defaultValue;
        }

    }
}
