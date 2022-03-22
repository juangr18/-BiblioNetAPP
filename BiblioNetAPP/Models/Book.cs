using BiblioNetAPP.Validations;
using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [FirstCapitalLetter]
        public string BookName { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        //[FirstCapitalLetter]
        public string Author { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public float Price { get; set; }
    }
}
