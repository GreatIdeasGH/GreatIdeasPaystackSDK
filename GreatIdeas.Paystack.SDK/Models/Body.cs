using GreatIdeas.Paystack.SDK.Models.Charges;
using GreatIdeas.Paystack.SDK.Models.Miscellaneous;

namespace GreatIdeas.Paystack.SDK.Models;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class Body : ChargeCreate
{
    [Newtonsoft.Json.JsonProperty("bank", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public Bank Bank { get; set; }

    [Newtonsoft.Json.JsonProperty("mobile_money", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public MobileMoney Mobile_money { get; set; }

    [Newtonsoft.Json.JsonProperty("ussd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public USSD Ussd { get; set; }

    [Newtonsoft.Json.JsonProperty("eft", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public EFT Eft { get; set; }

}