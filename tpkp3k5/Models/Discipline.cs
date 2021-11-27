namespace tpkp3k5.Models
{
    using System.ComponentModel.DataAnnotations;
    public partial class Discipline
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}