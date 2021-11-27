namespace tpkp3k5.Models
{
    using System.ComponentModel.DataAnnotations;
    public partial class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password Hash")]
        public string PasswordHash { get; set; }

        [Display(Name = "Is active")]
        public bool IsActive { get; set; }

        [Display(Name = "Is admin")]
        public bool IsAdmin { get; set; }

        [Display(Name = "Wallet balance")]
        public double WalletBalance { get; set; }
    }
}