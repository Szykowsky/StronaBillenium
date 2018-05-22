using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BilleniumProjekt.ViewModels
{
    public class FormViewModel
    {
        public int ContactDataId { get; set; }

        [Required(ErrorMessage = "Wprowadź Imię")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Wprowadź Nazwisko")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Napisz Komentarz")]
        public string Comment { get; set; }
    }
}