using System.Security.Cryptography;
using System.Text; 

namespace Core.Security.Hashing;

public static class HashingHelper
{
    // Şifreyi hash'lemek ve salt oluşturmak için bir metot.
    public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        // HMACSHA512 nesnesi oluşturuluyor, bu sınıf bir hash fonksiyonu kullanarak veri güvenliği sağlar.
        using HMACSHA512 hmac = new();

        // Salt değeri, HMACSHA512'nin otomatik oluşturduğu anahtar olarak atanıyor.
        passwordSalt = hmac.Key;

        // Şifre UTF8 olarak byte dizisine dönüştürülüp hash'leniyor.
        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }

    // Verilen şifrenin hash'lenmiş haliyle eşleşip eşleşmediğini doğrulamak için bir metot.
    public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        // HMACSHA512 nesnesi, verilen salt anahtarı kullanılarak yeniden oluşturuluyor.
        using HMACSHA512 hmac = new(passwordSalt);

        // Girilen şifre UTF8 olarak byte dizisine dönüştürülüp hash'leniyor.
        byte[] computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        // Hesaplanan hash ile verilen hash karşılaştırılıyor ve eşitse `true`, değilse `false` döner.
        return computedHash.SequenceEqual(passwordHash);
    }
}
