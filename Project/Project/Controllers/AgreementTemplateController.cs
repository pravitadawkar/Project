using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Interface;
using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgreementTemplateController : ControllerBase
    {
        IAgreementTemplate _data;
        public AgreementTemplateController(IAgreementTemplate data)
        {
            _data = data;
        }
        [HttpGet]
        [Route("GetAgreementTemplates")]
        public IActionResult GetAgreementTemplates()
        {
            var result = _data.GetAllAgreementTemplates();
            return Ok(result);
        }
        [HttpGet]
        [Route("GetAgreementTemplate")]
        public IActionResult GetAgreementTemplate(int id)
        {
            var result = _data.GetAgreementTemplate(id);
            return Ok(result);
        }
        [HttpPost]
        [Route("AddAgreementTemplate")]
        public IActionResult AddAgreementTemplate(AgreementTemplateDTO agreement)
        {
            _data.Insert(agreement);
            return Ok();
        }
        [HttpPost]
        [Route("UpdateAgreementTemplate")]
        public IActionResult UpdateAgreementTemplate(AgreementTemplateDTO agreement)
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
        [Route("DeleteAgreementTemplate")]
        public IActionResult DeleteAgreementTemplate(int id)
        {
            _data.delete(id);
            return Ok();
        }
    }
}
