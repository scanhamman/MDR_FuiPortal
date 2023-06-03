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
    public async Task<List<SourceItem>?> GetTreeItems(string treename)
    {
        var allItems = await _treeRepo.FetchTreeItems(treename);
        return allItems;

    }
}




