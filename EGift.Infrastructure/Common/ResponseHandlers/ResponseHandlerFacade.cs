namespace EGift.Infrastructure.Common.ResponseHandlers
{
    public class ResponseHandlerFacade : IResponseHandlerFacade
    {
        private readonly EmptyResultHandler<Response> emptyResult;
        private readonly OkResultHandler<Response> okResult;

        public ResponseHandlerFacade()
        {
            emptyResult = new EmptyResultHandler<Response>();
            okResult = new OkResultHandler<Response>();
            emptyResult.SetNextHandler(okResult);
        }

        public int Handle(Response toHandle)
        {
            return emptyResult.Handle(toHandle);
        }
    }
}
