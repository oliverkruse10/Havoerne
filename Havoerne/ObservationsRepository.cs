using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havoerne
{
    public class ObservationsRepository
    {
        private int nextId = 1;
        private List<Observation> observationsLib = new List<Observation>();

        public ObservationsRepository()
        {
            HavoerneRepository havoerneRepository = new HavoerneRepository();
            observationsLib.Add(new Observation { Id = nextId++, Lokation = "Gyrstinge Sø", Tidspunkt = DateTime.Now , Havoern = havoerneRepository.GetAll()[0]  });
            
        }

        public List<Observation> GetAll()
        {
            List<Observation> result = new List<Observation>(observationsLib);
            return result;
        }

        public Observation GetById(int id)
        {
            return observationsLib.FirstOrDefault(observation => observation.Id == id);
        }

        public Observation Add(Observation observation)
        {
            observation.Validate();
            observation.Id = nextId++;
            observationsLib.Add(observation);
            return observation;
        }

        public void Update(Observation observation)
        {
            throw new NotImplementedException();
        }
        
        public Observation Delete(int id)
        {
            Observation observationToDelete = observationsLib.FirstOrDefault(b => b.Id == id);

            if (observationToDelete != null)
            {
                observationsLib.Remove(observationToDelete);
            }

            return observationToDelete;
        }

    }
}
