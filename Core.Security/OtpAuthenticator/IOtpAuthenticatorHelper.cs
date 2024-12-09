namespace Core.Security.OtpAuthenticator;

public interface IOtpAuthenticatorHelper
{
    public Task<byte[]> GenerateSecretKey();
    public Task<string> ConvertSecretKeyToString(byte[] secretkey);
    public Task<bool> VerifyCode(byte[] secretKey,string code);
}
