using System.Runtime.CompilerServices;

namespace CarRental.Services.Infra
{
    public class OperationResult<TResult> : OperationDetails
    {
        public TResult Result { get; set; }

        public OperationResult([CallerMemberName] string opName = "") : base(opName)
        {
        }
    }
}
