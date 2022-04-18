namespace GreatIdeas.Paystack.SDK.Models.Transfers;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class TransferResendOTP
{
    /// <summary>
    /// The transfer code that requires an OTP validation
    /// </summary>
    [Newtonsoft.Json.JsonProperty("transfer_code", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Transfer_code { get; set; }

    /// <summary>
    /// Either resend_otp or transfer
    /// </summary>
    [Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Reason { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}