using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PubtracSSPoc.Data
{
    public class ManualToCopyHolder
    {
        public int Id { get; set; }
        //public string UserId { get; set; }
        //public string ManualNo { get; set; }
        public string CopyNo { get; set; }
        public DateTime? IssueDate { get; set; }
        [ForeignKey("ManualId")]
        public virtual Manuals TheManual { get; set; }
        [ForeignKey("CopyholderId")]
        public virtual Copyholder Copyholder { get; set; }
    }
}
