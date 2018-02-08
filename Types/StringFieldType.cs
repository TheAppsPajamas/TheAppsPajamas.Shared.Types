﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Build.Shared.Types
{
    public class StringFieldType : FieldType
    {
        private StringFieldDisplayType _fieldDisplayType;
        public StringFieldDisplayType FieldDisplayType { get { return _fieldDisplayType; } }

        private bool _isShared;
        public bool IsShared { get { return _isShared;  } }

        private string _defaultValue;
        public string DefaultValue;

        public StringFieldType(int value
            , string displayName
            , ProjectType projectType
            , FieldHolderType fieldHolderType
            , bool isShared
            , int order
            , bool isForClient
            , bool isProdReady
            , bool defaultToDisabled
            , StringFieldDisplayType fieldDisplayType
            , string defaultValue) : base(value, displayName, projectType, fieldHolderType, order, isForClient, isProdReady, defaultToDisabled)
        {
            _isShared = isShared;
            _fieldDisplayType = fieldDisplayType;
            _defaultValue = defaultValue;
        }

    }
}
