using Project.Athentication;
using Project.Interface;
using Project.Model;
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
        public List<AgreementType> GetAllAgreementTypes()
        {
            return _context.AgreementTypes.ToList();
        }
        public AgreementType GetAgreementType(int id)
        {
            return _context.AgreementTypes.FirstOrDefault();

        }
        public void Insert(AgreementType agreement)
        {
            _context.Add(agreement);
            _context.SaveChanges();
        }
        public void Update(AgreementType agreement)
        {
            _context.Update(agreement);
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
