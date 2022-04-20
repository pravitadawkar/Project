﻿using Project.Athentication;
using Project.Interface;
using Project.Model;
using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Services
{
    public class AgreementTypeService:IAgreementType
    {
        ApplicationDbContext _context;
        public AgreementTypeService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<AgreementTypeDTO> GetAllAgreementTypes()
        {
            var reslt = (from e in _context.AgreementTypes
                         select new AgreementTypeDTO
                         {
                             Id = e.Id,
                             Name = e.Name,
                             Status = e.Status,
                             CreatedAt = e.CreatedAt,
                             CreatedBy = e.CreatedBy,
                             ModifiedAt = e.ModifiedAt,
                             ModifiedBy = e.ModifiedBy,
                             IsActive = e.IsActive,
                         }).ToList();
            return reslt;
        }
        public AgreementTypeDTO GetAgreementType(int id)
        {
            var reslt = (from e in _context.AgreementTypes.Where(e => e.Id == id)
                         select new AgreementTypeDTO
                         {
                             Id = e.Id,
                             Name = e.Name,
                             Status = e.Status,
                             CreatedAt = e.CreatedAt,
                             CreatedBy = e.CreatedBy,
                             ModifiedAt = e.ModifiedAt,
                             ModifiedBy = e.ModifiedBy,
                             IsActive = e.IsActive,
                         }).FirstOrDefault();
            return reslt;
        }
        public void Insert(AgreementTypeDTO agreement)
        {
            AgreementCategory agreementCategory = new AgreementCategory();
            agreementCategory.Id = agreement.Id;
            agreementCategory.Name = agreement.Name;
            agreementCategory.Status = agreement.Status;
            agreementCategory.CreatedAt = agreement.CreatedAt;
            agreementCategory.CreatedBy = agreement.CreatedBy;
            agreementCategory.ModifiedAt = agreement.ModifiedAt;
            agreementCategory.ModifiedBy = agreement.ModifiedBy;
            agreement.IsActive = agreement.IsActive;
            _context.Add(agreementCategory);
            _context.SaveChanges();
        }
        public void Update(AgreementTypeDTO agreement)
        {
            AgreementCategory agreementCategory = new AgreementCategory();
            agreementCategory.Id = agreement.Id;
            agreementCategory.Name = agreement.Name;
            agreementCategory.Status = agreement.Status;
            agreementCategory.CreatedAt = agreement.CreatedAt;
            agreementCategory.CreatedBy = agreement.CreatedBy;
            agreementCategory.ModifiedAt = agreement.ModifiedAt;
            agreementCategory.ModifiedBy = agreement.ModifiedBy;
            agreement.IsActive = agreement.IsActive;
            _context.Update(agreementCategory);
            _context.SaveChanges();
        }
        public void delete(int id)
        {
            var agreement = _context.AgreementTypes.Where(s => s.Id == id).FirstOrDefault();

            if (agreement != null)
            {
                _context.Remove(agreement);
                _context.SaveChanges();
            }
        }
    }
}
