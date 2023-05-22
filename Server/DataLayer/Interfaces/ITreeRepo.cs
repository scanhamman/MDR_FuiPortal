namespace MDR_FuiPortal.Server;
using MDR_FuiPortal.Shared;

public interface ITreeRepo 
{
    public Task<List<SourceItem>?> FetchTreeItems(string TreeName);
}
