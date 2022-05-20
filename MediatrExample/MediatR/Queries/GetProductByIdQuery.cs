using MediatR;

namespace MediatrExample.MediatR.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; }
    }
}
