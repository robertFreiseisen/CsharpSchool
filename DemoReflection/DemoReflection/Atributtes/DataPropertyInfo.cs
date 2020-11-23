using System;
using System.Collections.Generic;
using System.Text;

namespace DemoReflection.Atributtes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class DataPropatyInfo : Attribute
    {
        public bool IsRequired { get; set; } = false;
        public bool ReadOnly { get; set; } = false;
        public int MaxLength { get; set; } = -1;
    }
}
