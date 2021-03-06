﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheAppsPajamas.Shared.Types
{
    public static class FieldTypeHelpers
    {
        //public static TFieldType Master<TFieldType>(this IEnumerable<TFieldType> fieldTypes)
        //    where TFieldType : AppIconFieldType
        //{
        //    return fieldTypes.FirstOrDefault(x => x.IsMaster);
        //}

        //public static IEnumerable<TFieldType> Others<TFieldType>(this IEnumerable<TFieldType> fieldTypes)
        //    where TFieldType : AppIconFieldType
        //{
        //    return fieldTypes.Where(x => !x.IsMaster).OrderBy(x => x.Order);
        //}

        public static IEnumerable<TFieldType> Shared<TFieldType>(this IEnumerable<TFieldType> fieldTypes)
            where TFieldType : FieldType
        {
            return fieldTypes.Where(x => x.ProjectType == ProjectType.Shared).OrderBy(x => x.Order);
        }

        public static IEnumerable<TFieldType> Ios<TFieldType>(this IEnumerable<TFieldType> fieldTypes)
             where TFieldType : FieldType
        {
            return fieldTypes.Where(x => x.ProjectType == ProjectType.Ios).OrderBy(x => x.Order);
        }

        public static IEnumerable<TFieldType> Droid<TFieldType>(this IEnumerable<TFieldType> fieldTypes)
              where TFieldType : FieldType
        {
            return fieldTypes.Where(x => x.ProjectType == ProjectType.Droid).OrderBy(x => x.Order);
        }

        //public static IEnumerable<TFieldType> SharedOthers<TFieldType>(this IEnumerable<TFieldType> fieldTypes)
        //    where TFieldType : StringFieldType
        //{
        //    return fieldTypes.Where(x => x.IsShared).OrderByDescending(x => x.Order);
        //}

        //public static IEnumerable<TFieldType> NotSharedOthers<TFieldType>(this IEnumerable<TFieldType> fieldTypes)
        //    where TFieldType : StringFieldType
        //{
        //    return fieldTypes.Where(x => !x.IsShared).OrderByDescending(x => x.Order);
        //}

        public static string GetMetadata(this FieldType fieldType, string key)
        {
            if (fieldType.Metadata == null)
                return string.Empty;

            if (fieldType.Metadata.TryGetValue(key, out string value))
            {
                return value;
            }
            return string.Empty;
        }
    }
}
