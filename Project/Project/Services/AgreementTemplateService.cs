using Project.Athentication;
using Project.Interface;
using Project.Model;
using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Services
{
    public class AgreementTemplateService:IAgreementTemplate
    {
        ApplicationDbContext _context;
        public AgreementTemplateService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<AgreementTemplateDTO> GetAllAgreementTemplates()
        {
            var reslt = (from e in _context.AgreementTemplates
                         join el in _context.AgreementTypes on e.TypeId equals el.Id
                         join eu in _context.AgreementCategorys on e.CategoryId equals eu.Id
                         select new AgreementTemplateDTO
                         {
                             Id = e.Id,
                             Name = e.Name,
                             Status = e.Status,
                             CreatedAt = e.CreatedAt,
                             CreatedBy = e.CreatedBy,
                             ModifiedAt = e.ModifiedAt,
                             ModifiedBy = e.ModifiedBy,
                             IsActive = e.IsActive,
                             CategoryId=eu.Id,
                             TypeId=el.Id,
                             EffectiveDate=e.EffectiveDate,
                             ExpiryDate=e.ExpiryDate
                         }).ToList();
            return reslt;
        }
        public AgreementTemplateDTO GetAgreementTemplate(int id)
        {
            var reslt = (from e in _context.AgreementTemplates.Where(e => e.Id == id)
                         join el in _context.AgreementTypes on e.TypeId equals el.Id
                         join eu in _context.AgreementCategorys on e.CategoryId equals eu.Id
                         select new AgreementTemplateDTO
                         {
                             Id = e.Id,
                             Name = e.Name,
                             Status = e.Status,
                             CreatedAt = e.CreatedAt,
                             CreatedBy = e.CreatedBy,
                             ModifiedAt = e.ModifiedAt,
                             ModifiedBy = e.ModifiedBy,
                             IsActive = e.IsActive,
                             CategoryId = eu.Id,
                             TypeId = el.Id,
                             EffectiveDate = e.EffectiveDate,
                             ExpiryDate = e.ExpiryDate
                         }).FirstOrDefault();
            return reslt;
        }
        public void Insert(AgreementTemplateDTO agreement)
        {
            AgreementTemplate agreementtemplate = new AgreementTemplate();
            agreementtemplate.Id = agreement.Id;
            agreementtemplate.Name = agreement.Name;
            agreementtemplate.Status = agreement.Status;
            agreementtemplate.CreatedAt = agreement.CreatedAt;
            agreementtemplate.CreatedBy = agreement.CreatedBy;
            agreementtemplate.ModifiedAt = agreement.ModifiedAt;
            agreementtemplate.ModifiedBy = agreement.ModifiedBy;
            agreementtemplate.IsActive = agreement.IsActive;
            agreementtemplate.ExpiryDate = agreement.ExpiryDate;
            agreementtemplate.EffectiveDate = agreement.EffectiveDate;
            agreementtemplate.CategoryId = agreement.CategoryId;
            agreementtemplate.TypeId = agreement.TypeId;


            _context.Add(agreementtemplate);
            _context.SaveChanges();
        }
        public void Update(AgreementTemplateDTO agreement)
        {
            AgreementTemplate agreementtemplate = new AgreementTemplate();
            agreementtemplate.Id = agreement.Id;
            agreementtemplate.Name = agreement.Name;
            agreementtemplate.Status = agreement.Status;
            agreementtemplate.CreatedAt = agreement.CreatedAt;
            agreementtemplate.CreatedBy = agreement.CreatedBy;
            agreementtemplate.ModifiedAt = agreement.ModifiedAt;
            agreementtemplate.ModifiedBy = agreement.ModifiedBy;
            agreementtemplate.IsActive = agreement.IsActive;
            agreementtemplate.ExpiryDate = agreement.ExpiryDate;
            agreementtemplate.EffectiveDate = agreement.EffectiveDate;
            agreementtemplate.CategoryId = agreement.CategoryId;
            agreementtemplate.TypeId = agreement.TypeId;
            _context.Update(agreementtemplate);
            _context.SaveChanges();
        }
        public void delete(int id)
        {
            var agreement = _context.AgreementTemplates.Where(s => s.Id == id).FirstOrDefault();

            if (agreement != null)
            {
                _context.Remove(agreement);
                _context.SaveChanges();
            }
        }
    }
}
