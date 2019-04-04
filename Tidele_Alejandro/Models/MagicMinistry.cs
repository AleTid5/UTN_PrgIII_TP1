using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tidele_Alejandro.Models
{
    public class MagicMinistry
    {
        public MagicMinistry()
        {
            this.ActiveMagicians = new List<string>();
            this.InactiveMagicians = new List<string>();
        }

        public List<string> ActiveMagicians { set; get; }
        public List<string> InactiveMagicians { set; get; }
    }
}
