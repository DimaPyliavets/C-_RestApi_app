using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required] // поле обовязкове для заповнення не може бути пустим
        public string Name { get; set; }

        [Required] // поле обовязкове для заповнення не може бути пустим
        public int Price { get; set; }
    }
}
