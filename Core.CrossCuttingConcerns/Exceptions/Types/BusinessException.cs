using System;

namespace Core.CrossCuttingConcerns.Exceptions.Types
{
    public class BusinessException : Exception
    {
        // Ek bir veri taşıyabilecek özel bir alan
        public string? ErrorCode { get; private set; }

        // Varsayılan Constructor
        public BusinessException()
        {
        }

        // Mesaj ile birlikte Constructor
        public BusinessException(string? message) : base(message)
        {
        }

        // Mesaj ve iç hata ile Constructor
        public BusinessException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        // Mesaj ve özel bir hata kodu içeren Constructor
        public BusinessException(string? message, string? errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        // Mesaj, hata kodu ve iç hata ile Constructor
        public BusinessException(string? message, string? errorCode, Exception? innerException) : base(message, innerException)
        {
            ErrorCode = errorCode;
        }

        // Hata mesajını ve hata kodunu string olarak döndüren bir override
        //public override string ToString()
        //{
        //    return $"Error Code: {ErrorCode}, Message: {Message}";
        //}
    }
}
