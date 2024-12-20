using API_CRUD.DataAcess;

namespace API_CRUD.Services.Company.DeleteCompany;

public class CompanyDelete : ICompanyDelete
{
    private readonly AppDbContext _context;

    public CompanyDelete(AppDbContext context)
    {
        _context = context;
    }

    public bool DeleteCompany(int id)
    {
        // Busca a empresa pelo ID. Retorna null se não for encontrada.
        var company = _context.Companies.FirstOrDefault(c => c.Id == id);

        if (company == null)
            return false;

        // Remove a empresa encontrada
        _context.Companies.Remove(company);
        _context.SaveChanges();

        return true;
    }
}
