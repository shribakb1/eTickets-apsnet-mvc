using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public  int  CinemaID { get; set; }

        public string  CinemaLogo { get; set; }

        public string Name { get; set; }

        public string Desctiption { get; set; }
    }
}
