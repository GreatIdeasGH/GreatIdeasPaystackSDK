using GreatIdeas.Paystack.SDK.Responses.Transactions;

namespace GreatIdeas.Paystack.SDK.Resources.Transactions;

public class PagingParams
{
    /// <summary>
    /// The section to retrieve
    /// </summary>
    public int? Page { get; set; }
    
    /// <summary>
    /// Number of records to fetch per page
    /// </summary>
    public int? PerPage { get; set; }
    
    /// <summary>
    /// The start date
    /// </summary>
    public DateTime? From { get; set; }
    
    /// <summary>
    /// The end date
    /// </summary>
    public DateTime? To { get; set; }

}