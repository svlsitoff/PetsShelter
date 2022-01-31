using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets_Sheleter.Models
{
    class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int IdDisease { get; set; }
        public string PicturePath { get; set; }
    }
}
