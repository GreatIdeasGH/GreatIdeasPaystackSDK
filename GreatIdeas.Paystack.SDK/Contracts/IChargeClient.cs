using System.CodeDom.Compiler;
using GreatIdeas.Paystack.SDK.Models;
using GreatIdeas.Paystack.SDK.Models.Charges;

namespace GreatIdeas.Paystack.SDK.Contracts;

[GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IChargeClient
{
    /// <summary>
    /// Create Charge
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> CreateAsync(Body body);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Create Charge
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> CreateAsync(Body body, CancellationToken cancellationToken);

    /// <summary>
    /// Submit PIN
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> SubmitPinAsync(ChargeSubmitPin body);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Submit PIN
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> SubmitPinAsync(ChargeSubmitPin body, CancellationToken cancellationToken);

    /// <summary>
    /// Submit OTP
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> SubmitOtpAsync(ChargeSubmitOTP body);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Submit OTP
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> SubmitOtpAsync(ChargeSubmitOTP body, CancellationToken cancellationToken);

    /// <summary>
    /// Submit Phone
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> SubmitPhoneAsync(ChargeSubmitPhone body);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Submit Phone
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> SubmitPhoneAsync(ChargeSubmitPhone body, CancellationToken cancellationToken);

    /// <summary>
    /// Submit Birthday
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> SubmitBirthdayAsync(ChargeSubmitBirthday body);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Submit Birthday
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> SubmitBirthdayAsync(ChargeSubmitBirthday body, CancellationToken cancellationToken);

    /// <summary>
    /// Submit Address
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> SubmitAddressAsync(ChargeSubmitAddress body);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Submit Address
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> SubmitAddressAsync(ChargeSubmitAddress body, CancellationToken cancellationToken);

    /// <summary>
    /// Check pending charge
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> CheckAsync(string reference);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Check pending charge
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> CheckAsync(string reference, CancellationToken cancellationToken);

}