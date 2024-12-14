using API_CRUD.DataAcess;
using API_CRUD.DTOs.Company;
using API_CRUD.Models;

namespace API_CRUD.Services.Company
{
    public class CompanyService : ICompanyService
    {
        private readonly AppDbContext _context;

        public CompanyService(AppDbContext context)
        {
            _context = context;
        }

        
        public List<CompanyDTO> GetAllCompanies()
        {
            var companies = _context.Companies.ToList();

            return companies.Select(company => new CompanyDTO
            {
                Id = company.Id,
                Name = company.Name,
                Email = company.CNPJ
            }).ToList();
        }

  
        public void CreateCompany(CompanyModel company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }
    }
}
