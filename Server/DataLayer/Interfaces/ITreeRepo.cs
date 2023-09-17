namespace MDR_FuiPortal.Server;
using MDR_FuiPortal.Shared;

public interface ITreeRepo 
{
    public Task<IEnumerable<TreeLine>?> FetchTreeItems(string TreeName);

    public Task<page_info?> GetPageContent(string tree_id);
}
