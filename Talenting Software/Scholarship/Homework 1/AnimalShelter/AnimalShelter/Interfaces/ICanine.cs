using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.Interfaces
{
    internal interface ICanine : IPet
    {
        public void Howl();
        public void ShedHair();
    }
}
