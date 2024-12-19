using API_CRUD.DTOs.Company;
using API_CRUD.Models;

namespace API_CRUD.Services.Company.CreateCompanyUseCase
{
    public interface ICreateCompany
    {
        CompanyCreateDTO CompanyAdd(CompanyModel company);
    }
}
