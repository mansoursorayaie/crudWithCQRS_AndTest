using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCrud.Infrastructure.Validations.Models
{
    public class ErrorModel
    {
        public string FieldName { get; set; }
        public string Message { get; set; }
    }
}
