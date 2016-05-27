﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IHFF.Helpers
{
    public static class StringExtensions
    {
        public static string UppercaseFirst(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        // Create a substring for movie descriptions
        public static string TrimStringIfLongerThan(this string value, int maxLenght)
        {
            if (value.Length > maxLenght)
            {
                return (value.Substring(0, maxLenght) + "...");
            }

            return value;
        }
    }
}