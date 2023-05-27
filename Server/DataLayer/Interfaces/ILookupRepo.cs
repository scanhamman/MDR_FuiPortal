using MDR_FuiPortal.Shared;

namespace MDR_FuiPortal.Server;

public interface ILookUpRepo
{
    public List<Country>? FetchCountries();
}
