using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Interface
{
    public interface IAgreementTemplate
    {
        public List<AgreementTemplateDTO> GetAllAgreementTemplates();
        public AgreementTemplateDTO GetAgreementTemplate(int id);
        public void Insert(AgreementTemplateDTO agreement);
        public void Update(AgreementTemplateDTO agreement);
        public void delete(int id);
    }
}
