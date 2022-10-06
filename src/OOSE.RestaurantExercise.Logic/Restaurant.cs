using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOSE.RestaurantExercise.Logic.Preparations;

namespace OOSE.RestaurantExercise.Logic
{
    public class Restaurant
    {
        private List<Cook> cooks;

        public Restaurant(List<Cook> cooks)
        {
            this.cooks = cooks;
        }

        public List<Cook> Cooks { get => cooks; }

        public void StartShift()
        {
            foreach(var cook in cooks)
            {
                Console.WriteLine(cook.StartPreparation());
                Console.WriteLine(" =========== ");
            }
        }


        public void EndContractCooksWithPreparation(Type preparationType)
        {
            if (preparationType.BaseType != typeof(Preparation))
            {
                return;
            }
            cooks.RemoveAll(c=>c.Preparation.GetType() == preparationType);
        }
    }
}
