using System.CodeDom.Compiler;
using GreatIdeas.Paystack.SDK.Models;
using GreatIdeas.Paystack.SDK.Models.TransfersRecipients;

namespace GreatIdeas.Paystack.SDK.Contracts;

[GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IClient
{
    /// <summary>
    /// Update Transfer recipient
    /// </summary>
    /// <param name="code">Transfer recipient code</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> TransferRecipientPutAsync(TransferRecipientUpdate body, string code);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update Transfer recipient
    /// </summary>
    /// <param name="code">Transfer recipient code</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> TransferRecipientPutAsync(TransferRecipientUpdate body, string code, CancellationToken cancellationToken);

    /// <summary>
    /// Delete Transfer Recipient
    /// </summary>
    /// <param name="code">Transfer recipient code</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> TransferRecipientDeleteAsync(string code);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Delete Transfer Recipient
    /// </summary>
    /// <param name="code">Transfer recipient code</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> TransferRecipientDeleteAsync(string code, CancellationToken cancellationToken);

}