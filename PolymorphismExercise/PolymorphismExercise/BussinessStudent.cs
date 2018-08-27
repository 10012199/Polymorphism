using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    class BussinessStudent : Student
    {
        public override int Grades()
        {

            int littles = 0;

            if (Grade1 >= Grade2 && Grade1 >= Grade3) littles = Grade2 + Grade3;
            if (Grade2 >= Grade1 && Grade2 >= Grade3) littles = Grade1 + Grade3;
            if (Grade3 >= Grade1 && Grade3 >= Grade2) littles = Grade1 + Grade2;
            
            return base.Grades() - littles;
            
          /*if (Grade1 >= Grade2 && Grade1 >= Grade3)
                return Grade1;
            else if (Grade2 >= Grade1 && Grade2 >= Grade3)
                return Grades2;
            else if (Grade3 >= Grade1 && Grade3 >= Grade2)
                return Grades3;*/
        }
    }
}
