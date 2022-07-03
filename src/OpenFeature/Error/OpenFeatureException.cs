using System;
using OpenFeature.Constant;
using OpenFeature.Extention;

namespace OpenFeature.Error
{
    public class OpenFeatureException : Exception
    {
        public ErrorType ErrorType { get; }
        public string ErrorTypeDescription { get; }
        
        public OpenFeatureException(ErrorType errorType, Exception innerException)
            : base(null, innerException)
        {
            ErrorType = errorType;
            ErrorTypeDescription = errorType.GetDescription();
        }
    }
}