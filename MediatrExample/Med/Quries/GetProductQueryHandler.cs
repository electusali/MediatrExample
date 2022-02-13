using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatrExample.Med.Quries
{
	public class GetProductQueryHandler:IRequestHandler<GetProductQuery,GetProductViewModels>
	{
		public  Task<GetProductViewModels> Handle(GetProductQuery request, CancellationToken cancellationToken)
		{
			var product = new GetProductViewModels()
			{
				Id = Guid.NewGuid(),
				Name = "Ali"
			};
			return Task.FromResult<GetProductViewModels>(product); 
		}
	}
}
