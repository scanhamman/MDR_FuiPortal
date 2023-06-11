namespace MDR_FuiPortal.Shared;

public class InfoText
{
    public List<InfoDiv>? InfoDivs { get; set; }
}

public class InfoDiv
{
    public int Id { get; set; }
    public int SeqNum { get; set; }
    public string? Info { get; set; }

    public InfoDiv(int id, int seqNum, string? info)
    {
        Id = id;
        SeqNum = seqNum;
        Info = info;
    }
}


public class TreeLine
{
    public string? Id { get; set; }
    public string? Title { get; set; }
    public int Level { get; set; }
    public bool IsParent { get; set; }
    public bool? IsClosed { get; set; }
}


public class PageContent
{
    public string? Content { get; set; }

    public PageContent(string? _Content)
    {
        Content = _Content;
    }

    public PageContent()
    { }
}
