using API_CRUD.DataAcess;
using API_CRUD.DTOs.Company;

namespace API_CRUD.Services.Company.UseCompanyGetId;

public class GetIdCompany : IGetIdCompany
{

    private readonly AppDbContext _context;

    public GetIdCompany(AppDbContext context)
    {
        _context = context;
    }
    public CompanyDTO GetIdCompanYY(int id)
    {
        var company = _context.Companies.FirstOrDefault(c => c.Id == id);
        return new CompanyDTO
        {
        Id = company.Id,
        Name = company.Name,
        Email = company.Email
        };
    }
}

