namespace AmplifundExample.Logic
{
    using System.Collections.Generic;
    using System.Linq;

    using Data.Core;
    using Data.Core.Contexts;

    public static class CarLogic
    {
        public static IEnumerable<CarModel> GetCars()
        {
            using var con = new CarsContext();
            return con.Cars.ToList();
        }
      }
}
