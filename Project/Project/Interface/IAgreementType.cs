using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Interface
{
   public interface IAgreementType
    {
        public List<AgreementType> GetAllAgreementTypes();
        public AgreementType GetAgreementType(int id);
        public void Insert(AgreementType agreement);
        public void Update(AgreementType agreement);
        public void delete(int id);

    }
}
