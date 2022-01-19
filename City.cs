using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer
{
    abstract class City
    {
        public double Population { get; set; }

        public City(double population)
        {
            Population = population;
        }

        public static bool operator <(City city, City city1)
        {
            return city.Population < city1.Population;
        }

        public static bool operator >(City city, City city1)
        {
            return city.Population > city1.Population;
        }
    }

    class Baku : City
    {
        public Baku(double population) : base (population)
        {

        }
    }



    class Istanbul : City
    {
        public Istanbul(double population) : base(population)
        {

        }
    }


    class Moscow : City
    {
        public Moscow(double population) : base(population)
        {

        }
    }
}
