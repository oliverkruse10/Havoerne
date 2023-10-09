using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havoerne
{
    public class HavoerneRepository
    {

        private int nextId = 1;
        private List<Havoern> havoerneLib = new List<Havoern>();
        public HavoerneRepository()
        {   
            havoerneLib.Add(new Havoern { Id = nextId++, Art = "Havørn" });
            havoerneLib.Add(new Havoern { Id = nextId++, Art = "Kongeørn" });
            havoerneLib.Add(new Havoern { Id = nextId++, Art = "Stor Skrigeørn" });
            havoerneLib.Add(new Havoern { Id = nextId++, Art = "Lille Skrigeørn" });
            havoerneLib.Add(new Havoern { Id = nextId++, Art = "Kejserørn" });
            havoerneLib.Add(new Havoern { Id = nextId++, Art = "Steppeørn" });
            havoerneLib.Add(new Havoern { Id = nextId++, Art = "Dværgørn" });
            havoerneLib.Add(new Havoern { Id = nextId++, Art = "Høgeørn" });
            havoerneLib.Add(new Havoern { Id = nextId++, Art = "Slangeørn" });
            havoerneLib.Add(new Havoern { Id = nextId++, Art = "Fiskeørn" });
        }

        public List<Havoern> GetAll()
        {
            List<Havoern> result = new List<Havoern>(havoerneLib);
            return result;
        }

        public Havoern GetById(int id)
        {
            return havoerneLib.FirstOrDefault(havoerne => havoerne.Id == id);
        }

        public Havoern Add(Havoern havoern)
        {
            havoern.Validate();
            havoern.Id = nextId++;
            havoerneLib.Add(havoern);
            return havoern;
        }

        public void Update(Havoern havoern)
        {
            throw new NotImplementedException();
        }

        public Havoern Delete(int id)
        {
            Havoern havoernToDelete = havoerneLib.FirstOrDefault(b => b.Id == id);

            if (havoernToDelete != null)
            {
                havoerneLib.Remove(havoernToDelete);
            }

            return havoernToDelete;
        }   
    }
}
