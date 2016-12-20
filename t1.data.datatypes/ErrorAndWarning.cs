using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace t1.data.datatypes
{
    [Table("ErrorAndWarning")]
    public class ErrorAndWarning
    {
        // By specifying the name ID, entity framework will know this should be an auto-incrementing PK
        public int ID { get; set; }

        [StringLength(50)]
        public string VehicleName { get; set; }

        public string Message { get; set; }

        public DateTime CreatedDateTime { get; set; }
    }
}
