using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class Sprite
    {
        public ImageHolder Other { get; set; }    
    }

    public class ImageHolder
    {
        public ImageLink Dream_world { get; set; }
    }

    public class ImageLink
    {
        public string Front_default { get; set; }
    }
}
