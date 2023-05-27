using MDR_FuiPortal.Shared;
using Microsoft.Fast.Components.FluentUI;

namespace MDR_FuiPortal.Server;

public class LookUpRepo : ILookUpRepo
{
    public List<Country>? FetchCountries()
    {
        // designed to mimic a call to the database
        // seeking About Tree items from a table;

        List<Country> countries = new();

        countries.Add(new Country(1, "France" ));
        countries.Add(new Country(2, "Germany"));
        countries.Add(new Country(3, "United Kingdom"));
        countries.Add(new Country(4, "United States"));
        countries.Add(new Country(5, "Spain"));
        countries.Add(new Country(6, "Portugal"));
        countries.Add(new Country(7, "Italy"));
        countries.Add(new Country(8, "Belgium"));
        countries.Add(new Country(9, "Netherlands"));
        countries.Add(new Country(10, "Canada"));
        countries.Add(new Country(11, "Finland"));
        countries.Add(new Country(12, "Sweden"));
        countries.Add(new Country(13, "Norway"));
        countries.Add(new Country(14, "Denmark"));
        countries.Add(new Country(15, "Poland"));
        countries.Add(new Country(16, "Hungary"));
        countries.Add(new Country(17, "Romania"));
        countries.Add(new Country(18, "Slovenia"));
        countries.Add(new Country(19, "Latvia"));

        return countries;

    }
}

