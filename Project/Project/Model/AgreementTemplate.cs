﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Model
{
    public class AgreementTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TypeId { get; set; }
        public bool Status { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<AgreementType> Agreementtype { get; set; }
        public virtual AgreementCategory AgreementCategory { get; set; }

    }
}
