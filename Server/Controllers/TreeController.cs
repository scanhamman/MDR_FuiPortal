using MDR_FuiPortal.Server.Controllers;
using MDR_FuiPortal.Shared;
using Microsoft.AspNetCore.Mvc;

namespace MDR_FuiPortal.Server;

[Route("api/[controller]")]
public class TreeController : BaseApiController
{
    private readonly ITreeRepo _treeRepo;

    public TreeController(ITreeRepo treeRepo)
    {
        _treeRepo = treeRepo ?? throw new ArgumentNullException(nameof(treeRepo));
    }

    [HttpGet("items/{treename}")]
    public async Task<List<TreeLine>?> GetTreeItems(string treename)
    {
        var allItems = await _treeRepo.FetchTreeItems(treename);
        return allItems is not null ? allItems.ToList() : null;
    }


    [HttpGet("page/{tree_id}")]
    public async Task<PageContent?> GetPageContent(string tree_id)
    {
        string? p_content = await _treeRepo.GetPageContent(tree_id);
        return new PageContent(p_content);
    }
}




