using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinder.Models
{
    public class SendMessageViewModel
    {
        [Required(ErrorMessage ="Lütfen Adınızı Boş Geçmeyin")]
        [StringLength(30,ErrorMessage ="Lütfen en fazla 30 karakter veri girişi yapınız.")]

        public string  NameSurname{ get; set; }

        [Required(ErrorMessage = "Lütfen Emailinizi Boş Geçmeyin")]
        [StringLength(50, ErrorMessage = "Lütfen en fazla 50 karakter veri girişi yapınız.")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir mail adresi girişi yapınız.")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen Konu Boş Geçmeyin")]
        [StringLength(50, ErrorMessage = "Lütfen en fazla 50 karakter veri girişi yapınız.")]
        [MinLength(5, ErrorMessage = "Lütfen en az 5 karakter veri girişi yapınız.")]

        public string Subject { get; set; }


        [Required(ErrorMessage = "Lütfen Mesaj Kısmını Boş Geçmeyin")]
        [StringLength(1000, ErrorMessage = "Lütfen daha az karakter veri girişi yapınız.")]
        

        public string Message { get; set; }

    }

}