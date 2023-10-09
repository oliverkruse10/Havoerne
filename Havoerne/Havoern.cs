using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havoerne
{
    public class Havoern
    {
        public int Id { get; set; }

        public string Art { get; set; }

        

        public void Validate()
        {
            if (string.IsNullOrEmpty(Art))
            {
                throw new ArgumentException("Art skal udfyldes");
            }
        }

    }
}
