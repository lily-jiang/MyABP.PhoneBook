using System.ComponentModel.DataAnnotations;

namespace MyABP.PhoneBook.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}