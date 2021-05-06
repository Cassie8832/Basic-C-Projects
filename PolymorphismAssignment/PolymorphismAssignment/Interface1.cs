using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmission
{
    //Create an interface called IQuittable and have it define a void method called Quit().
    interface IQuittable
    {
        void Quit(Employee employee);
    }
}