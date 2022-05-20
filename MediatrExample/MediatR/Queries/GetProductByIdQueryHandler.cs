using MediatR;

namespace MediatrExample.MediatR.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        #region Implementation of IRequestHandler<in GetProductByIdQuery,GetProductByIdViewModel>

        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var viewModel = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };

            return Task.FromResult(viewModel);


            // Get product from repository
        }

        #endregion
    }
}
