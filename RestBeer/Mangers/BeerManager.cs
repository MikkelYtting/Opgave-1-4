using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Opgave_1_og_Unit_tests_Obligatorisk_opg_1;

namespace RestBeer.Mangers
{
    public class BeerManager
    {
        private static int _nextId = 1;
        private static List<Beer> BeerData = new List<Beer>()
        {
            new Beer{Id = _nextId++, Name = "lala",Price = 51, Abv = 5},
            new Beer{Id = _nextId++, Name = "jajajaja.", Price = 5, Abv = 5},
            new Beer{Id = _nextId++, Name = ".jajajajaja",Price = 5, Abv = 5}
        };

        public List<Beer> getAll()
        {
            return BeerData;
        }

        public Beer GetById(int id)
        {
            return BeerData.Find(beer => beer.Id == id);
        }
        public Beer Add(Beer newBeer)
        {
            newBeer.Id = _nextId++;
            BeerData.Add(newBeer);
            return newBeer;
        }

        public Beer Delete (int Id)
        {
            Beer beer = BeerData.Find(Beer1 => Beer1.Id == Id);
            if (beer == null) return null;
            BeerData.Remove(beer);
            return beer;
        }

        public Beer Update(int id, Beer updates)
        {
            Beer beer = BeerData.Find(beer1 => beer1.Id == id);
            if (beer == null) return null;
            beer.Name = updates.Name;
            beer.Price = updates.Price;
            beer.Abv = updates.Abv;
            return beer;
        }
    }
}
