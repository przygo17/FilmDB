using System.ComponentModel.DataAnnotations;

namespace FilmDB.Models
{
    public class FilmModels
    {
        public int  ID { get; set; }
        [Required]
        public string Title { get; set; }

        public int Year { get; set; }

    }
}
