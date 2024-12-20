using API_CRUD.Models;
using API_CRUD.Services.Company;
using API_CRUD.Services.Company.UseCompanyGetId;
using Microsoft.AspNetCore.Mvc;
using API_CRUD.Services.Company.CreateCompanyUseCase;
using API_CRUD.Services;
using API_CRUD.Services.Company.DeleteCompany;
using API_CRUD.DTOs.Company;

namespace API_CRUD.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
    [HttpDelete("{id}")]
    public IActionResult DeleteCompany(
    [FromBody] CompanyDeleteDTO company, // DTO para receber o ID da empresa
    [FromServices] ICompanyDelete useCase) // Serviço para deletar a empresa
    {
        var result = useCase.DeleteCompany(company.Id); // Chama o caso de uso para deletar

        if (!result)
            return NotFound("Empresa não encontrada."); // Retorna 404 se não encontrar a empresa

        return NoContent(); // Retorna 204 se a exclusão for bem-sucedida
    }

    // Ação para obter uma empresa pelo ID
    [HttpGet("{id}")]
    public IActionResult GetId(
        [FromRoute] int id,  // O ID vem pela URL (via [FromRoute])
        [FromServices] IGetIdCompany useCase)  // Serviço para obter a empresa pelo ID
    {
        var company = useCase.GetIdCompanYY(id);
        if (company == null)
        {
            return NotFound();  // Caso a empresa não seja encontrada
        }
        return Ok(company);
    }

    // Ação para obter todas as empresas
    [HttpGet]
    public IActionResult GetAll(
        [FromServices] IGetAllCompany useCase)  // Serviço para obter todas as empresas
    {
        var companies = useCase.GetAllCompanies();
        return Ok(companies);
    }

    // Ação para criar uma empresa
    [HttpPost]
    public IActionResult CompanyAdd
        (
        [FromBody] CompanyModel company,  // Modelo de dados da empresa a ser criada
        [FromServices] ICreateCompany useCase)  // Serviço para criar a empresa
    {
        var response = useCase.CompanyAdd(company);  // Método que cria a empresa
        return Created(string.Empty, response);
    }
}
