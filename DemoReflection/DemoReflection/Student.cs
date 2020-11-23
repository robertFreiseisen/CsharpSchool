using DemoReflection.Atributtes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoReflection
{
    [DataClass(SourceName = "Unknown")]
    public class Student : Person
    {
        public string MatNumber { get; set; }
    }
}
