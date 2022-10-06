using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE.RestaurantExercise.Logic.Preparations
{
    public static class PreparationFactory
    {
        public static IPreparation GetPreparation(PreparationType preparationType)
        {
            if (preparationType == PreparationType.Hardrock)
            {
                return new HardRockPreparation();
            }
            if (preparationType == PreparationType.Meditation)
            {
                return new MeditationPreparation();
            }
            if (preparationType == PreparationType.Simpel)
            {
                return new SimplePreparation();
            }
            if (preparationType == PreparationType.Soccer)
            {
                return new SoccerPreparation();
            }
            return new SimplePreparation();
        }
    }
}
