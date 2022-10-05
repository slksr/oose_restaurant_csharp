using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE.RestaurantExercise.Logic
{
    public class Preparation
    {
        private List<PreparationStep> preparationSteps;

        public Preparation()
        {
            preparationSteps = new List<PreparationStep>();
        }

        public List<PreparationStep> PreparationSteps 
        { 
            get => preparationSteps;  
        }

        public void SetPreparationStep(PreparationStep preparationStep)
        {
            if (!preparationSteps.Any(x => x.Step == preparationStep.Step))
            {
                preparationSteps.Add(preparationStep);
            }
        }

    }
}
