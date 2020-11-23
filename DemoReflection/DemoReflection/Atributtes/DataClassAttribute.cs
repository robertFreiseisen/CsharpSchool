using System;
using System.Collections.Generic;
using System.Text;

namespace DemoReflection.Atributtes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DataClassAttribute : Attribute
    {
        public string SourceName { get; set; }
    }
}
