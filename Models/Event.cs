using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EventManagerFunctional.Models
{
    [Table("EVENT", Schema = "RM554867")]
    public class Event
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Required]
        [Column("NAME")]
        public string Name { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Required]
        [Column("EVENT_DATE")]
        public DateTime EventDate { get; set; }

        [Required]
        [Column("LOCATION")]
        public string Location { get; set; }

        [Column("CREATED_AT")]
        public DateTime? CreatedAt { get; set; }

        [Column("DATE_EVENT")]
        public DateTime? DateEvent { get; set; }
    }
}
