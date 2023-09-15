using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkeyModels.Models.ViewModels
{
    public class AddCatagoryRequest
    {
        [Required(ErrorMessage = "Catagory Name Required ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Display Order required")]
        public int DisplayOrder { get; set; }
    }
}
