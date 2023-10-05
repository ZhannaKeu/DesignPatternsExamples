using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Template_method_pattern
{
    public abstract class PastaDish
    {
        public void MakeRecipe()
        {
            BoilWater();
            AddPasta();
            CookPasta();
            DrainAndPlate();
            AddSauce();
            AddProtein();
            AddGarnish();
        }
        public abstract void AddGarnish();
        public abstract void AddProtein();
        public abstract void AddSauce();
        private void DrainAndPlate()
        {
            Console.WriteLine("Draing the water and placing on a plate");
        }
        private void CookPasta()
        {
            Console.WriteLine("Cooking pasta");
        }
        public abstract void AddPasta();
        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
    }
}
