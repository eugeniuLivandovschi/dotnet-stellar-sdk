using System;

namespace stellar_dotnet_sdk.responses.results
{
    public class OperationResult
    {
        public static OperationResult FromXdr(xdr.OperationResult result)
        {
            switch (result.Discriminant.InnerValue)
            {
                case xdr.OperationResultCode.OperationResultCodeEnum.opBAD_AUTH:
                    return new OperationResultBadAuth();
                case xdr.OperationResultCode.OperationResultCodeEnum.opNO_ACCOUNT:
                    return new OperationResultNoAccount();
                case xdr.OperationResultCode.OperationResultCodeEnum.opNOT_SUPPORTED:
                    return new OperationResultNotSupported();
                case xdr.OperationResultCode.OperationResultCodeEnum.opINNER:
                    return InnerOperationResultFromXdr(result.Tr);
                default:
                    throw new SystemException("Unknown OperationResult type");
            }
        }

        private static OperationResult InnerOperationResultFromXdr(xdr.OperationResult.OperationResultTr result)
        {
            switch (result.Discriminant.InnerValue)
            {
                case xdr.OperationType.OperationTypeEnum.CREATE_ACCOUNT:
                    return CreateAccountResult.FromXdr(result.CreateAccountResult);
                default:
                    throw new SystemException("Unknown OperationType");
            }
        }
    }
}