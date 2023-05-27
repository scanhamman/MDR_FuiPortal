namespace MDR_FuiPortal.Shared;

public class StudySummary
{
    int Id { get; set; }
    string? Name { get; set; }
    string? Description { get; set; }
    int TypeId { get; set; }
    int StatusId { get; set; }
    int StartYear { get; set; }
    int StartMonth { get; set; }
    string? Provenance { get; set; }
    string? HasObjectBitString { get; set; }

    List<string>? Conditions { get; set; }
    List<string>? Countries { get; set; }
    List<ObjectSummary>? DataObjects{ get; set; }
}


public class ObjectSummary
{
    int Id { get; set; }
    int Type { get; set; }
    string? Name { get; set; }
    string? Url { get; set; }
    int? PublishedType { get; set; }
    string? Provenance { get; set; }
    int access_type { get; set; }
}


public class StudyDetails
{
    int Id { get; set; }
    string? Name { get; set; }
    string? Description { get; set; }
    string? DataSharingStatement { get; set; }
    int TypeId { get; set; }
    int StatusId { get; set; }
    int StartYear { get; set; }
    int StartMonth { get; set; }
    string? MinAge { get; set; }
    string? MaxAge { get; set; }
    string? GenderEligibility { get; set; }
    string? Provenance { get; set; }

    List<string>? StudyIdentifiers { get; set; }
    List<string>? Titles { get; set; }
    List<string>? Conditions { get; set; }
    List<string>? Topics { get; set; }
    List<string>? Features { get; set; }
    List<string>? Countries { get; set; }
    List<string>? StudyPeople { get; set; }
    List<string>? StudyOrganisations { get; set; }
    List<string>? StudyRelationships { get; set; }
    List<ObjectSummary>? ObjectDetails { get; set; }

    // Inclusion / exclusion criteria - availabe as button
}


public class ObjectDetails
{
    int Id { get; set; }
    int Type { get; set; }
    string? Name { get; set; }
    string? Url { get; set; }
    string? AccessDetails { get; set; }
    string? ManagingOrganisation { get; set; }
    string? ResourceSystem { get; set; }
    string? ResourceDetails { get; set; }
    int? PublishedType { get; set; }
    string? Provenance { get; set; }
    int access_type { get; set; }

    List<string>? Dates { get; set; }
    List<string>? ObjectIdentifiers { get; set; }
    List<string>? ObjectPeople { get; set; }
    List<string>? ObjectOrganisations { get; set; }
}
