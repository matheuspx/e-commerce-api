using API_CRUD.DataAcess;
using API_CRUD.DTOs.Company;
using API_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD.Services.Company.CreateCompanyUseCase;

public class CreateCompany : ICreateCompany
{
    private readonly AppDbContext _context;
    public CreateCompany(AppDbContext context)
    {
        _context = context;
    }
    public CompanyCreateDTO CompanyAdd(CompanyModel company)
    {
        _context.Companies.Add(company);
        _context.SaveChanges();
        return new CompanyCreateDTO
        {
            Id = company.Id
        };
    }

}