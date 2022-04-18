namespace GreatIdeas.Paystack.SDK.Models.Pages;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class PageProduct
{
    /// <summary>
    /// IDs of all products to add to a page
    /// </summary>
    [Newtonsoft.Json.JsonProperty("product", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public ICollection<string> Product { get; set; } = new System.Collections.ObjectModel.Collection<string>();

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}