using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE.RestaurantExercise.Logic
{
    public class Restaurant
    {
        private List<Cook> cooks;

        public Restaurant(List<Cook> cooks)
        {
            this.cooks = cooks;
        }

        public void StartShift()
        {
            foreach(var cook in cooks)
            {
                Console.WriteLine(cook.StartPreparation());
                Console.WriteLine(" =========== ");
            }
        }

    }
}
