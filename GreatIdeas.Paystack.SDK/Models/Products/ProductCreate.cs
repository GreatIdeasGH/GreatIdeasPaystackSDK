namespace GreatIdeas.Paystack.SDK.Models.Products;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class ProductCreate
{
    /// <summary>
    /// Name of product
    /// </summary>
    [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Name { get; set; }

    /// <summary>
    /// The description of the product
    /// </summary>
    [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Description { get; set; }

    /// <summary>
    /// Price should be in kobo if currency is NGN, pesewas, if currency is GHS, and cents, if currency is ZAR
    /// </summary>
    [Newtonsoft.Json.JsonProperty("price", Required = Newtonsoft.Json.Required.Always)]
    public int Price { get; set; }

    /// <summary>
    /// Currency in which price is set. Allowed values are: NGN, GHS, ZAR or USD
    /// </summary>
    [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Currency { get; set; }

    /// <summary>
    /// Set to true if the product has limited stock. Leave as false if the product has unlimited stock
    /// </summary>
    [Newtonsoft.Json.JsonProperty("limited", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool Limited { get; set; }

    /// <summary>
    /// Number of products in stock. Use if limited is true
    /// </summary>
    [Newtonsoft.Json.JsonProperty("quantity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int Quantity { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}