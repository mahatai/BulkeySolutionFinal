using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkeyModels.Models.ViewModels
{
    public class EditCatagoryRequest
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
