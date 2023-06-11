using Dapper;
using MDR_FuiPortal.Shared;
using Microsoft.AspNetCore.Components;
using Npgsql;
using System.Text;

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

        using var conn = new NpgsqlConnection(_dbConnString);
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


    public async Task<string?> GetPageContent(string tree_id)
    {
        var sql_string = $@"select content 
                            from core.tree_text tt
	                        where tree_page_id = '{tree_id}'
	                        order by tt.sequence";

        using var conn = new NpgsqlConnection(_dbConnString);
        try
        {
            var res = await conn.QueryAsync<string>(sql_string);
            if (res?.Any() == true)
            {
                List<string> res_list = res.ToList();
                if (res_list.Count == 1)
                {
                    return res_list[0];
                }
                else
                {
                    StringBuilder sb = new();
                    foreach(string s in res_list)
                    {
                        sb.Append(s);
                    }
                    return sb.ToString();
                }
            }
            else
            {
                return null;
            }
        }
        catch (Exception e)
        {
            string s = e.Message;
            return null;
        }
    }

    private string? htmlencode(string v)
    {
        throw new NotImplementedException();
    }
}
