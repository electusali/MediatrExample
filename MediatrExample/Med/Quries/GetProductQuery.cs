using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MediatrExample.Med.Quries
{
	public class GetProductQuery:IRequest<GetProductViewModels>
	{
		public Guid Id { get; set; }
	}
}
