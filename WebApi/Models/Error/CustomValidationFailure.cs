namespace WebApi.Models.Error
{
    public class CustomValidationFailure
    {
        public CustomValidationFailure(string propertyName, string errorMessage)
        {
            PropertyName = propertyName;
            ErrorMesage = errorMessage;
        }

        public string PropertyName { get; set; }
        public string ErrorMesage { get; set; }
    }
}
