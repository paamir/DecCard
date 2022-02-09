using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json.Serialization;

namespace DevCard.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3, ErrorMessage = "حداقل طول 3 می تواند باشد")]
        [MaxLength(25)]
        public string Name { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Email { get; set; }
        public int Status  { get; set; }
        [NotNull]
        public string Text { get; set; }

        public SelectList Services { get; set; }

    }
}
