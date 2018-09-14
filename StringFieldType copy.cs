using System;
using System.Collections.Generic;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public class StringFieldType : FieldType
    {
        private StringFieldDisplayType _fieldDisplayType;
        public StringFieldDisplayType FieldDisplayType { get { return _fieldDisplayType; } }
        
        private string _defaultValue;
        public string DefaultValue {  get { return _defaultValue; } }

        public StringFieldType(int value
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
            _fieldDisplayType = fieldDisplayType;
            _defaultValue = defaultValue;
        }

    }
}
