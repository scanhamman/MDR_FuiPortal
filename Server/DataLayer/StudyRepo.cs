using Dapper;
using MDR_FuiPortal.Shared;
using Npgsql;

namespace MDR_FuiPortal.Server
{
    public class StudyRepo : IStudyRepo
    {
        private readonly string _dbConnString;

        public StudyRepo(ICreds creds)
        {
            _dbConnString = creds.GetConnectionString("mdr");
        }

        public async Task<string?> FetchStudyByTypeAndId(int type_id, string reg_Id)
        {
            var sqlString = $@"select study_json from core.search_idents
                              where ident_type = {type_id} and ident_value = '{reg_Id}'";
            using var conn = new NpgsqlConnection(_dbConnString);
            try
            {
                var res = await conn.QueryFirstOrDefaultAsync<string>(sqlString);
                return res;
            }
            catch (Exception e)
            {
                string s = e.Message;
                return null;
            }
        }
          

        public async Task<IEnumerable<string>?> FetchStudiesByPMID(int pmid)
        {
            var sqlString = $@"select study_json from core.search_pmids
                              where pmid = {pmid}";
            using var conn = new NpgsqlConnection(_dbConnString);
            try
            {
                var res = await conn.QueryAsync<string>(sqlString);
                return res;

            }
            catch (Exception e)
            {
                string s = e.Message;
                return null;
            }

        }


        public async Task<IEnumerable<string>?> FetchStudiesBySearch(int search_scope, string search_string)
        {
            string sqlString = "select study_json from core.search_lexemes ";
            if (search_scope == 1)
            { 
                 sqlString += $" where  tt_lex @@ to_tsquery('core.mdr_english_config', '{search_string}')";
            }
            else if (search_scope == 4)
            {
                sqlString += $" where  conditions_lex @@ to_tsquery('core.mdr_english_config', '{search_string}')";
            }
            else if (search_scope == 5)
            {
                sqlString += $@" where  tt_lex @@ to_tsquery('core.mdr_english_config', '{search_string}') 
                                 or conditions_lex @@ to_tsquery('core.mdr_english_config', '{search_string}')";
            }
            using var conn = new NpgsqlConnection(_dbConnString);
            try
            {
                var res = await conn.QueryAsync<string>(sqlString);
                return res;

            }
            catch (Exception e)
            {
                string s = e.Message;
                return null;
            }

        }
    }
}
