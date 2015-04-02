using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_example.Model.Plant
{
    class Plant : Model
    {
        public virtual string Name { get; set; }
        public virtual Type Type { get; set; }
    }
}
