﻿using System.Text.Json;

namespace Identity4121.CrossCuttingConcerns.ExtensionMethods
{
    public static class ObjectExtensions
    {
        public static string AsJsonString(this object obj)
        {
            var content = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
            return content;
        }
    }
}
