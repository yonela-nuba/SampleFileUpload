using System.ComponentModel.DataAnnotations;

namespace SampleFileUpload.Models
{
    public class FileCreation
    {
        public int Id { get; set; }

        [Display(Name = "File Name")]
        public string FileName { get; set; }

        [Display(Name = "File Type")]
        public string FileType { get; set; }

        [Display(Name = "File Extension")]
        public string Extension { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Uploaded By")]
        public string UploadedBy { get; set; }

        [Display(Name = "Uploaded On")]
        public DateTime UploadedOn { get; set;}

        [Display(Name = "File Path")]
        public string FilePath { get; set; }
    }
}
