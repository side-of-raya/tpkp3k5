namespace tpkp3k5.Models
{
    using System.ComponentModel.DataAnnotations;
    public partial class Event
    {

        [Key]
        public int ID { get; set; }
        // [Required]
        [Display(Name = "When")]
        public System.DateTime Date { get; set; }

        [Required]
        [Display(Name = "Discipline ID")]
        public int DisciplineID { get; set; }

        [Required]
        [Display(Name = "Team one")]
        public string TeamOne { get; set; }

        [Required]
        [Display(Name = "Team two")]
        public string TeamTwo { get; set; }

        [Display(Name = "x")]
        [Range(1, int.MaxValue)]
        public double DrawK { get; set; }

        [Display(Name = "Team one k")]
        [Range(1, int.MaxValue)]
        public double TeamOneK { get; set; }

        [Display(Name = "Team two k")]
        [Range(1, int.MaxValue)]
        public double TeamTwoK { get; set; }
    }
}