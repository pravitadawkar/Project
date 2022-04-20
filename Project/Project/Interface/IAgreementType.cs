using Project.Model;
using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Interface
{
   public interface IAgreementType
    {
        public List<AgreementTypeDTO> GetAllAgreementTypes();
        public AgreementTypeDTO GetAgreementType(int id);
        public void Insert(AgreementTypeDTO agreement);
        public void Update(AgreementTypeDTO agreement);
        public void delete(int id);

    }
}
