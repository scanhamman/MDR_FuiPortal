using MDR_FuiPortal.Server.Controllers;
using MDR_FuiPortal.Shared;
using Microsoft.AspNetCore.Mvc;
namespace MDR_FuiPortal.Server;

[Route("api/[controller]")]
public class LookUpController : BaseApiController
{
    private readonly ILookUpRepo _lookUpRepo;

    public LookUpController(ILookUpRepo lookUpRepo)
    {
        _lookUpRepo = lookUpRepo ?? throw new ArgumentNullException(nameof(lookUpRepo));
    }

    [HttpGet("countryList")]
    public async Task<List<Country>?> GetCountryList()
    {
        var countryList = _lookUpRepo.FetchCountries();
        
        return countryList;
    }

    
}
