using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class AbstractEntity
    {
        public int ID { get; }
        
        public AbstractEntity()
        {
            this.ID = new Random().Next(0, 100000); //generate random ID.
        }
    }


}
