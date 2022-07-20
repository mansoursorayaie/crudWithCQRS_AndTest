using System.Collections.Generic;

namespace TestCrud.Infrastructure.Validations.Models
{
    public class ErrorRespons
    {
        public ErrorRespons()
        {
            ErrorModels = new List<ErrorModel>();
        }

        public List<ErrorModel> ErrorModels { get; set; }
    }
}
