using System.ComponentModel.DataAnnotations;

namespace ChildWare.api.Model
{
    public class ChildWareModel
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir email adresi girin.")]
        public string  Email { get; set; }
        public string Name { get; set; }
    }
}
