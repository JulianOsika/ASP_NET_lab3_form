using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace lab3formularz.Models
{
    public class Dane
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Podaj imie")]
        [MinLength(2)]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Podaj nazwisko")]
        [MinLength(2)]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Podaj haslo")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$",
            ErrorMessage = "Hasło musi zawierać przynajmniej jedną literę małą, dużą oraz cyfrę")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Potwierdz haslo")]
        [Compare("Haslo", ErrorMessage = "Hasla musza byc identyczne")]
        public string PotwierdzHaslo { get; set; }

        [Phone(ErrorMessage = "Niepoprawny numer telefonu")]
        public string NrTelefonu { get; set; }

        [Range(10, 80, ErrorMessage = "Wiek muis sie miescic miedzy 10 a 80")]
        public int Wiek {  get; set; }

        public string Miasto { get; set; }
        public enum Kategorie { A = 1, B =2 , C = 3, D = 4, E = 5 }

    }
}
