using MDR_FuiPortal.Shared;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
namespace MDR_FuiPortal.Server.Controllers;

[Route("api/[controller]")]

public class StudyController :  BaseApiController
{
    private readonly IStudyRepo _studyRepo;

    public StudyController(IStudyRepo studyRepo)
    {
        _studyRepo = studyRepo ?? throw new ArgumentNullException(nameof(studyRepo));
    }

    [HttpGet("BySearch/{search_scope:int}/{search_string}")]
    public async Task<List<string>?> GetStudiesBySearch(int search_scope, string search_string)
    {
        var res = await _studyRepo.FetchStudiesBySearch(search_scope, search_string);
        var listres = res is not null ? res.ToList() : null;
        return listres;

    }


    [HttpGet("ByRegId/{type_id:int}/{reg_id}")]
    public async Task<List<string>?> GetStudyByTypeAndId(int type_id, string reg_id)
    {
        var res =  await _studyRepo.FetchStudyByTypeAndId(type_id, reg_id);
        return res is not null ? new List<string>() { res } : null;
    }


    [HttpGet("ByPMID/{pmid:int}")]
    public async Task<IEnumerable<string>?> FetchStudiesByPMID(int pmid)
    {
        var res = await _studyRepo.FetchStudiesByPMID(pmid);
        return res is not null ? res.ToList() : null;
    }


    /*
    [HttpGet("{study_id:int}")]
    public async Task<List<StudyDetails>?> GetStudyDetails(int study_id)
    {
        var res = await _studyRepo.FetchStudyDetails(study_id);
        var listres = res is not null ? new List<StudyDetails>() { res } : null;
        return listres;
    }
    */

    // temp for early testing of the principle

    [HttpGet("{study_id:int}")]
    public async Task<List<string>?> GetStudyJsonById(int study_id)
    {
        var res = await _studyRepo.FetchStudyById(study_id);
        return res is not null ? new List<string>() { res } : null;
    }


    [HttpGet("/iec/{study_id:int}")]
    public async Task<List<IECLine>?> GetStudyIEC(int study_id)
    {
        var res = await _studyRepo.FetchStudyIEC(study_id);
        var listres = res is not null ? res.ToList() : null;
        return listres;
    }

}

