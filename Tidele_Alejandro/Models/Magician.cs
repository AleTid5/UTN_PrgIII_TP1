using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tidele_Alejandro.Models
{
    public class Magician
    {
        public Magician()
        {
            this.Subjects = new List<bool>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime Borndate { get; set; }
        public string Kind { get; set; }
        public string House { get; set; }
        public List<bool> Subjects { get; set; }

        public bool Validate()
        {
            return !String.IsNullOrEmpty(this.Name) &&
                   !String.IsNullOrWhiteSpace(this.Name) &&
                   !String.IsNullOrEmpty(this.Lastname) &&
                   !String.IsNullOrWhiteSpace(this.Lastname) &&
                   !String.IsNullOrEmpty(this.Kind) &&
                   !String.IsNullOrWhiteSpace(this.Kind) &&
                   !String.IsNullOrEmpty(this.House) &&
                   !String.IsNullOrEmpty(this.House);
        }
    }
}
