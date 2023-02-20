using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvalifikacijkiZadatak.Shared
{
    public class Kvarovi
    {
        public int Id { get; set; }
        public string Ime { get; set; } = string.Empty;
        public string Prioritet { get; set; } = string.Empty;
        public string Pocetak { get; set; } = string.Empty;
        public string Zavrsetak { get; set; } = string.Empty;
       [Required] public string DetaljniOpis { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
