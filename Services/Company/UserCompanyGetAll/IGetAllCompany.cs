using API_CRUD.DTOs.Company;
using API_CRUD.Models;

namespace API_CRUD.Services;

public interface IGetAllCompany
{
    List<CompanyDTO> GetAllCompanies();
}
