using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatrExample.Med.Quries
{
	public class GetAllProduct:IRequest<List<GetProductViewModels>>
	{
		public class GetAllProductHandler : IRequestHandler<GetAllProduct,List<GetProductViewModels>>
		{
			public Task<List<GetProductViewModels>> Handle(GetAllProduct request, CancellationToken cancellationToken)
			{
				var model = new GetProductViewModels()
				{
					Id = Guid.NewGuid(),
					Name = "Book"
				};
				var model2 = new GetProductViewModels()
				{
					Id = Guid.NewGuid(),
					Name = "Monitor"
				};
				return Task.FromResult(new List<GetProductViewModels>() {model2, model});

			}
		}
	}
}
