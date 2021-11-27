namespace tpkp3k5.Models
{
    using System.ComponentModel.DataAnnotations;
    public partial class Bet
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "K")]
        public double K { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public double Amount { get; set; }

        [Required]
        [Display(Name = "User ID")]
        public int UserID { get; set; }

        [Display(Name = "Event ID")]
        [Range(1, int.MaxValue)]
        public int EventID { get; set; }

        [Display(Name = "Is won")]
        public bool IsWon { get; set; }

        [Display(Name = "Is fulfilled")]
        public bool IsFulfilled { get; set; }

        [Display(Name = "Outcome")]
        public string Outcome { get; set; }
        public Event e { get; set; }
    }
}