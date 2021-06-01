using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebGoogleTranslate.Models
{
    public class TranslateModel
    {
        [Key]
        public int Id { get; set; }

        public string SelectedSourceLg { get; set; }

        public string SelectedTargetLg { get; set; }

        public List<SelectListItem> Langs { get; set; }

        public string Origin { get; set; }

        public string Result { get; set; }
    }
}
