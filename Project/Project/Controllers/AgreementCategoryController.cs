using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Interface;
using Project.Model;
using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgreementCategoryController : ControllerBase
    {
        IAgreementCategory _data;
        public AgreementCategoryController(IAgreementCategory data)
        {
            _data = data;
        }
        [HttpGet]
        [Route("GetAgreementCategorys")]
        public IActionResult GetAgreementCategory()
        {
            var result = _data.GetAllAgreementCategorys();
            return Ok(result);
        }
        [HttpGet]
        [Route("GetAgreementCategory")]
        public IActionResult GetAgreementCategory(int id)
        {
            var result = _data.GetAgreementCategory(id);
            return Ok(result);
        }
        [HttpPost]
        [Route("AddAgreementCategory")]
        public IActionResult AddAgreementCategory(AgreementCategoryDTO agreement)
        {
            _data.Insert(agreement);
            return Ok();
        }
        [HttpPost]
        [Route("UpdateAgreementCategory")]
        public IActionResult UpdateAgreementCategory(AgreementCategoryDTO agreement)
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
        [Route("DeleteAgreementCategory")]
        public IActionResult DeleteAgreementCategory(int id)
        {
            _data.delete(id);
            return Ok();
        }
    }
}
