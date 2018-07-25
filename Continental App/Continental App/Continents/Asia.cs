using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Continental_App.Animals;

namespace Continental_App.Continents
{
    class Asia : Continent
    {
        public override void CreateContinent()
        {
            Animals.Add(new Panda());
            Animals.Add(new SlowLoris());
        }
    }
}
