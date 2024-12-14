using API_CRUD.DTOs.Company;
using API_CRUD.Models;
using API_CRUD.Services;
using API_CRUD.Services.Company;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        // Endpoint para obter todas as empresas
        [HttpGet]
        public ActionResult<List<CompanyDTO>> GetAll()
        {
            var companies = _companyService.GetAllCompanies();
            return Ok(companies);  // Retorna a lista de empresas
        }

        // Endpoint para criar uma nova empresa
        [HttpPost]
        public ActionResult CreateCompany([FromBody] CompanyModel company)
        {
            _companyService.CreateCompany(company);
            return CreatedAtAction(nameof(GetAll), new { id = company.Id }, company);  // Retorna um código 201 (Created)
        }
    }
}
