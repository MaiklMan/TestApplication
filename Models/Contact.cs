using System.ComponentModel.DataAnnotations;

namespace TestApplication.Models
{
    public class Contact
    {
        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Вам нужно ввести имя")]
        public string Name { get; set; }
        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Вам нужно ввести фамилию")]
        public string Surname { get; set; }
        [Display(Name = "Введите возраст")]
        [Required(ErrorMessage = "Вам нужно ввести возраст")]
        public int Age { get; set; }
        [Display(Name = "Введите Email")]
        [Required(ErrorMessage = "Вам нужно ввести email")]
        public string Email { get; set; }
        [Display(Name = "Введите сообщение")]
        [Required(ErrorMessage = "Вам нужно ввести сообщение")]
        [StringLength(30, ErrorMessage = "Текст менее 30 символов")]
        public string Message { get; set; }
    }
}
