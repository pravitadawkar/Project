using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Model
{
    public class AgreementType
    {
        public int Id { get; set; }
        public string Name { get; set; }
      public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsActive { get; set; }
        public virtual AgreementTemplate Agreementtemplate { get; set; }
        public virtual AgreementCategory AgreementCategory { get; set; }
    }
}
