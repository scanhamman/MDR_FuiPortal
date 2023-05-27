using MDR_FuiPortal.Shared;
using Npgsql;
using Dapper.Contrib;
using Dapper;

namespace MDR_FuiPortal.Server;
/*
   
public async Task<bool> OrgExists(int id)
{
    string sqlString = $@"select exists (select 1 from lup.organisations
                              where id = {id.ToString()})";
    await using var conn = new NpgsqlConnection(_dbRmsConnString);
    return await conn.ExecuteScalarAsync<bool>(sqlString);
}



// All organisations (id, name from relevant org names)
public async Task<IEnumerable<OrgTableDataInDb>> GetOrgsTableData()
{
    var sqlString = $@"Select id, default_name from lup.organisations
                           order by default_name";
    await using var conn = new NpgsqlConnection(_dbRmsConnString);
    return await conn.QueryAsync<OrgTableDataInDb>(sqlString);
}
*/

public class LookUpRepo : ILookUpRepo
{
    private readonly string _dbConnString;

    public LookUpRepo(ICreds creds)
    {
        _dbConnString = creds.GetConnectionString("context");
    }

    public async Task<IEnumerable<Country>?> FetchCountries()
    {
        var sqlString = @"select geoname_id, country_name
                           from ctx.countries
                           where rank = 1";
        using var conn = new NpgsqlConnection(_dbConnString);

        try
        {
            var res = await conn.QueryAsync<Country>(sqlString);
            return res;
        }
        catch(Exception e)
        {
            string s = e.Message;
            return null;
        }

        

        /*
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
        */
        //return countries;

    }
}

