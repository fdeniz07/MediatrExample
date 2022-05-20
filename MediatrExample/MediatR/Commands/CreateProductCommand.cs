using MediatR;

namespace MediatrExample.MediatR.Commands
{
    public class CreateProductCommand:IRequest<Guid>
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Value { get; set; }

        public class  CreateProductCommandHandler : IRequestHandler<CreateProductCommand,Guid>
        {
            #region Implementation of IRequestHandler<in CreateProductCommand,Guid>

            public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                return Task.FromResult(Guid.NewGuid());

                // repository araciligi ile veri veritabanina gönderilir.
            }

            #endregion
        }
    }
}
