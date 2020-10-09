using System.ComponentModel.DataAnnotations;
using System.IO;

namespace AUI.Shared.Classes.General
{
    public class Picture
    {
        public string Message { get; set; }

        public string FileName { get; set; }

        public string Focus { get; set; }

        public string ID { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Title too long (20 character limit).")]
        public string Title { get; set; }

        public string FormType { get; set; }

        public string AnimalType { get; set; }

        public string Mode { get; set; }

        public long AnimalID { get; set; }

        public Stream Stream { get; set; }
    }
}
