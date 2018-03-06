﻿using System;
using System.Collections.Generic;
using System.Text;
using SmartSql.Abstractions;

namespace SmartSql.SqlMap.Tags
{
    public class Placeholder : Tag
    {
        public override TagType Type => TagType.Placeholder;
        public override string BuildSql(RequestContext context)
        {
            if (IsCondition(context))
            {
                Object reqVal = GetPropertyValue(context);
                return $" {Prepend}{reqVal.ToString()}";
            }
            return String.Empty;
        }

        public override bool IsCondition(RequestContext context)
        {
            if (context.RequestParameters == null) { return false; }
            return context.RequestParameters.ContainsKey(Property);
        }
    }
}
