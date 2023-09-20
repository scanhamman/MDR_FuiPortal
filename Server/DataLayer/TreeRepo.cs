using Dapper;
using MDR_FuiPortal.Shared;
using Npgsql;

namespace MDR_FuiPortal.Server;

public class TreeRepo : ITreeRepo
{
    private readonly string _dbConnString;

    public TreeRepo(ICreds creds)
    {
        _dbConnString = creds.GetConnectionString("mdr");
    }

    public async Task<IEnumerable<TreeLine>?> FetchTreeItems(string TreeName)
    {
        var sql_string = $@"select level as Level, tree_id as Id, title as Title, 
                            is_parent as IsParent, is_closed as IsClosed 
                              from core.tree_pages 
                              where tree = '{TreeName}'
                              order by tree_seq";

        await using var conn = new NpgsqlConnection(_dbConnString);
        try
        {
            var res = await conn.QueryAsync<TreeLine>(sql_string);
            return res;

        }
        catch (Exception e)
        {
            string s = e.Message;
            return null;
        }
    }

    public async Task<page_info?> GetPageContent(string tree_id)
    {
        await using var conn = new NpgsqlConnection(_dbConnString);
        string sql_string = $@"select title, last_edited
                            from core.tree_text_headers 
	                        where tree_page_id = '{tree_id}'";
        page_info_header? header = await conn.QuerySingleOrDefaultAsync<page_info_header>(sql_string);

        if (header is null)
        {
            return null;
        }
        page_info pi = new(header.title, header.last_edited);

        sql_string = $@"select type, seq_num, markup
                        from core.tree_info tt
	                    where tree_page_id = '{tree_id}'
	                    order by tt.seq_num";

        List<info_component> res = (await conn.QueryAsync<info_component>(sql_string)).ToList();
        if (res.Any())
        {
            pi.info_dyncs = res.ToList();
            return pi;
        }
        return null; // as fallback
     }
}
