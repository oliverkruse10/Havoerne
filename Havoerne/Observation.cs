using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havoerne
{
    public class Observation
    {
        public int Id { get; set; }

        public string Lokation { get; set; }

        public DateTime Tidspunkt { get; set; }

        public Havoern Havoern { get; set; }

        public string Beskrivelse { get; set; }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Lokation))
            {
                throw new ArgumentException("Lokation skal udfyldes");
            }
            if (Tidspunkt == null)
            {
                throw new ArgumentException("Tidspunkt skal udfyldes");
            }
            if (Havoern == null)
            {
                throw new ArgumentException("Havørn skal udfyldess");
            }
        }

    }
}
