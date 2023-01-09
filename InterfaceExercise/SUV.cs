using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool HasThirdRow { get; set; }
        public bool HasFourWheelDrive { get; set; }
        public int NumberOfWheels { get; set; }

        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public string TagLine { get; set; }

    }
}
