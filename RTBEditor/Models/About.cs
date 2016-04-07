using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace RTBEditor.Models
{
    public class About
    {
        [Required]
        public int UserID { get; set; }

        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        [Display(Name = "About")]
        public string AboutMe { get; set; }
    }
}