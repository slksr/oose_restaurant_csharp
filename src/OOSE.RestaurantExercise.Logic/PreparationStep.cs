using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE.RestaurantExercise.Logic
{
    public class PreparationStep
    {
        public PreparationStep(string step)
        {
            Step = step;
        }
        public string Step { get; private set; }
    }

    
}
