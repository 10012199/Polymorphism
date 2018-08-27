using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    class ITStudent : Student
    {
        public override int Grades()
        {
            return base.Grades() / 3;
        }
    }
}
