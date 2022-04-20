using Project.Model;
using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Interface
{
    public interface IAgreementCategory
    {
        public List<AgreementCategoryDTO> GetAllAgreementCategorys();
        public AgreementCategoryDTO GetAgreementCategory(int id);
        public void Insert(AgreementCategoryDTO agreement);
        public void Update(AgreementCategoryDTO agreement);
        public void delete(int id);
    }
}
