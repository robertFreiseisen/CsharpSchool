using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLINQ.Models
{
    public class Marking:ModelObject
    {
        public int StudentId { get; set; }
        public string Cours { get; set; }
        public int Mark { get; set; }
    }
}
