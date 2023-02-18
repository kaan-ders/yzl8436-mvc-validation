using System.ComponentModel.DataAnnotations;

namespace MvcValidation.Models
{
    public class Musteri
    {
        [Required(ErrorMessage = "Adı alanı zorunludur ve max 25 karakter olmalı")]
        [StringLength(25)]
        public string Adi { get; set; }
                
        public string? Adresi { get; set; }
        public string Ulke { get; set; }

        [Required(ErrorMessage = "Email alanı zorunludur ve geçerli bir adres olmalıdır")]
        [EmailAddress]
        public string Email { get; set; }
        
        public DateTime? KayitTarihi { get; set; }
        public int? SiparisSayisi { get; set; }
    }
}
