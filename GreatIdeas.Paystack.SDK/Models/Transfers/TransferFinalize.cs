namespace GreatIdeas.Paystack.SDK.Models.Transfers;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class TransferFinalize
{
    /// <summary>
    /// The transfer code you want to finalize
    /// </summary>
    [Newtonsoft.Json.JsonProperty("transfer_code", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Transfer_code { get; set; }

    /// <summary>
    /// OTP sent to business phone to verify transfer
    /// </summary>
    [Newtonsoft.Json.JsonProperty("otp", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Otp { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}