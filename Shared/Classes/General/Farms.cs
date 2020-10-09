using System;
using System.ComponentModel.DataAnnotations;


namespace AUI.Shared.Classes.General
{
     public class Farms
    {
        public int ID { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Name too long (20 character limit).")]
        public string Name { get; set; }
        [Required]
        [Range(1, 1000000000, ErrorMessage = "Length invalid (1-100000).")]
        public int Length { get; set; }
        [Required]
        [Range(1, 1000000000, ErrorMessage = "Width invalid (1-100000).")]
        public int Width { get; set; }
        [Range(0, 10000000000, ErrorMessage = " 0 for Inherited farms, but this value inacceptable(1-100000).")]
        public int? InitialCost { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "District too long (20 character limit).")]
        public string District { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "District too long (50 character limit).")]
        public string Owner { get; set; }
        [Required]
        public DateTime DoP { get; set; }
    }
}
