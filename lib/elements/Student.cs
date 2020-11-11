using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeitProject.Lib.Elements
{
    internal class Student
    {
        internal string MatriculationNumber { get; set; }
        internal string Name { get;set;}
        internal string Surname { get; set; }
        internal ClassRoom Classrooom { get; set; }
    }
}