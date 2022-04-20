using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Interface;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgreementTypeController : ControllerBase
    {
        IAgreementType _data;
        public AgreementTypeController(IAgreementType data)
        {
            _data = data;
        }
        [HttpGet]
        [Route("GetAgreementTypes")]
        public IActionResult GetAgreementTypes()
        {
            var result = _data.GetAllAgreementTypes();
            return Ok(result);
        }
        [HttpGet]
        [Route("GetSupplier")]
        public IActionResult GetSupplier(int id)
        {
            var result = _data.GetAgreementType(id);
            return Ok(result);
        }
        [HttpPost]
        [Route("AddSupplier")]
        public IActionResult AddSupplier(AgreementType agreement)
        {
            _data.Insert(agreement);
            return Ok();
        }
        [HttpPost]
        [Route("UpdateSupplier")]
        public IActionResult UpdateSupplier(AgreementType agreement)
        {
            try
            {
                _data.Update(agreement);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound();

            }
        }
        [HttpPost]
        [Route("DeleteSupplier")]
        public IActionResult DeleteSupplier(int id)
        {
            _data.delete(id);
            return Ok();
        }
    }
}
