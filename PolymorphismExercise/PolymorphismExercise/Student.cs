using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public class Student
    {
        public int Grade1 { get; set; }
        public int Grade2 { get; set; }
        public int Grade3 { get; set; }

        public virtual int Grades()
        {
            return Grade1 + Grade2 + Grade3;
        }
            

    }
}
