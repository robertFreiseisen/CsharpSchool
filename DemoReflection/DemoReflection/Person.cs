using DemoReflection.Atributtes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoReflection
{
    [DataClass(SourceName = "Unknown")]
    public class Person
    {
        [DataPropatyInfo(IsRequired = true, MaxLength = 65)]
        public string LastName { get; set; }
        [DataPropatyInfo(IsRequired = true, MaxLength = 50)]
        public string FirstName { get; set; } = "Maxi";
        [DataPropatyInfo(ReadOnly = true)]
        public string FullName => $"{LastName} {FirstName}"; 
    }
}
