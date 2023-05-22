using MDR_FuiPortal.Shared;

namespace MDR_FuiPortal.Server;

public class TreeRepo : ITreeRepo
{ 
    public async Task<List<SourceItem>?> FetchTreeItems(string TreeName)
    {
        if (TreeName.ToLower() == "about")
        {
            return FetchAboutTreeItems();
        }
        if (TreeName.ToLower() == "guide")
        {
            return FetchGuideTreeItems();
        }
        return null;
    }


    private List<SourceItem>? FetchAboutTreeItems()
    {
        // designed to mimic a call to the database
        // seeking About Tree items from a table;

        List<SourceItem> SourceItems = new();
        SourceItems.Add(new SourceItem { Level = 0, Id = "0", Title = "About the MDR", IsParent = true, IsClosed = false });
        SourceItems.Add(new SourceItem { Level = 1, Id = "1", Title = "The Project", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 2, Id = "1.1", Title = "Project History", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "1.2", Title = "Integration with other systems", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "1.3", Title = "Data Sources", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 1, Id = "2", Title = "Metadata Schemas", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 2, Id = "2.1", Title = "Summary Tables", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "2.2", Title = "Schema Description", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "2.3", Title = "Study schema JSON", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "2.4", Title = "Object schema JSON", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "2.5", Title = "Previous Metadata Versions", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.1", Title = "Changes, Version 6-7", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.2", Title = "Study schema JSON v6", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.3", Title = "Object schema JSON v6", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.4", Title = "Changes, Version 5-6", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.5", Title = "Study schema JSON v5", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.6", Title = "Object schema JSON v5", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.7", Title = "Changes, Version 4-5", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.8", Title = "Study schema JSON v4", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.9", Title = "Object schema JSON v4", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.10", Title = "Changes, Version 3-4", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.11", Title = "Study schema JSON v3", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.12", Title = "Object schema JSON v3", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.13", Title = "Changes, Version 2-3", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.14", Title = "Study schema JSON v2", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.15", Title = "Object schema JSON v2", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.16", Title = "Changes, Version 1-2", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.17", Title = "Study schema JSON v2", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "2.5.18", Title = "Object schema JSON v1", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 1, Id = "3", Title = "The Data", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 2, Id = "3.1", Title = "MDR Data", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.1.1", Title = "The MDR Databases", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.1.2", Title = "MDR Data Structures", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "3.2", Title = "Source Data", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.2.1", Title = "ClinicalTrials.gov Data", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.2.2", Title = "WHO Data", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.2.3", Title = "EU CTR Data", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.2.4", Title = "PubMed Data", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.2.5", Title = "ISRCTN Data", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "3.3", Title = "Contextual Data", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.3.1", Title = "Organisational Data", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.3.2", Title = "Geographical Data", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.3.3", Title = "Publisher Data", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.3.4", Title = "Condition Data", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.3.5", Title = "Topic Data", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "3.4", Title = "Lookup Data", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.1", Title = "Contribution Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.2", Title = "Dataset Consent Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.3", Title = "Dataset De-identification Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.4", Title = "Dataset RecordKey Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.5", Title = "Description Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.6", Title = "DOI Status Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.7", Title = "Identifier Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.8", Title = "IEC Level Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.9", Title = "Language Codes", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.10", Title = "Language Usage Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.11", Title = "Object Access Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.12", Title = "Object Classes", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.13", Title = "Object Filter Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.14", Title = "Object Instance Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.15", Title = "Object Relationship Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.16", Title = "Object Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.17", Title = "Resource Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.18", Title = "Study Feature Categories", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.19", Title = "Study Feature Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.20", Title = "Study Gender Eligibility", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.21", Title = "Study Statuses", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.22", Title = "Study Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.23", Title = "Study Relationship Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.24", Title = "Title Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.25", Title = "Topic Types", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.26", Title = "Topic Vocabularies", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "3.4.27", Title = "Units (for Size and Time)", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 1, Id = "4", Title = "Data Extraction", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 2, Id = "4.1", Title = "Overview", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 3, Id = "4.1.1", Title = "Tracking Extraction", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "4.1.2", Title = "Logging and Error Reporting", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "4.2", Title = "Downloading Data", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 3, Id = "4.2.1", Title = "Downloading Options", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "4.3", Title = "Harvesting Data", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 3, Id = "4.3.1", Title = "Harvesting IEC Data", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "4.4", Title = "Importing Data", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "4.5", Title = "Aggregating Data", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 3, Id = "4.5.1", Title = "Preferred Data Sources", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "4.5.2", Title = "Study-study links", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "4.5.3", Title = "Allocating PIDs", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "4.6", Title = "Maintenance Tasks", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 3, Id = "4.6.1", Title = "Scheduling", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "4.6.2", Title = "Backing up Data", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "4.7", Title = "Testing Extraction", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 3, Id = "4.7.1", Title = "Testing Source Processing", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "4.7.2", Title = "Testing Aggregation", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 1, Id = "5", Title = "The Portal", IsParent = true, IsClosed = true });
        SourceItems.Add(new SourceItem { Level = 2, Id = "5.1", Title = "Functionality", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "5.2", Title = "Technologies", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "5.3", Title = "Indexing the Data", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "5.4", Title = "The API", IsParent = false });
        return SourceItems;

    }

    private List<SourceItem>? FetchGuideTreeItems()
    {
        // designed to mimic a call to the database
        // seeking About Tree items from a table;

        List<SourceItem> SourceItems = new();
        SourceItems.Add(new SourceItem { Level = 0, Id = "0", Title = "MDR User Guide", IsParent = true, IsClosed = false });
        SourceItems.Add(new SourceItem { Level = 1, Id = "1", Title = "Searching for Studies", IsParent = true, IsClosed = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "1.1", Title = "Basic search types", IsParent = false});
        SourceItems.Add(new SourceItem { Level = 2, Id = "1.2", Title = "Boolean combinations in search", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "1.3", Title = "Filtering search results", IsParent = true, IsClosed = false });
        SourceItems.Add(new SourceItem { Level = 3, Id = "1.3.1", Title = "Object types in filtering", IsParent = false, });
        SourceItems.Add(new SourceItem { Level = 2, Id = "1.4", Title = "Searching using Conditions", IsParent = false, });
        SourceItems.Add(new SourceItem { Level = 2, Id = "1.5", Title = "Search tips", IsParent = false, });
        SourceItems.Add(new SourceItem { Level = 1, Id = "2", Title = "Saving searches", IsParent = true, IsClosed = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "2.1", Title = "Aggregating searches", IsParent = false, });
        SourceItems.Add(new SourceItem { Level = 2, Id = "2.2", Title = "Saving searches", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "2.3", Title = "Restoring searches", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 1, Id = "3", Title = "Saving and exporting results", IsParent = true, IsClosed = false });
        SourceItems.Add(new SourceItem { Level = 2, Id = "3.1", Title = "Printing results", IsParent = false, });
        SourceItems.Add(new SourceItem { Level = 2, Id = "3.2", Title = "Saving results to file", IsParent = false });
        SourceItems.Add(new SourceItem { Level = 1, Id = "4", Title = "Reporting inaccuracies", IsParent = false });
        return SourceItems;
    }

}
