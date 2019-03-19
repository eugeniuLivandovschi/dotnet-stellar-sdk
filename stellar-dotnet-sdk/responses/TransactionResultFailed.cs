using System.Collections.Generic;
using stellar_dotnet_sdk.responses.results;

namespace stellar_dotnet_sdk.responses
{
    public class TransactionResultFailed : TransactionResult
    {
        public override bool IsSuccess => false;

        public ICollection<OperationResult> Results { get; set; }
    }
}