namespace GreatIdeas.Paystack.SDK.Models.TransfersRecipients;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class TransferRecipientBulk
{
    /// <summary>
    /// A list of transfer recipient object. Each object should contain type, name, and bank_code. 
    /// <br/>Any Create Transfer Recipient param can also be passed.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("batch", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public ICollection<TransferRecipientCreate> Batch { get; set; } = new System.Collections.ObjectModel.Collection<TransferRecipientCreate>();

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}