using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatrExample.Med.Commands;
using MediatrExample.Med.Quries;

namespace MediatrExample.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IMediator mediator;

		public ProductController(IMediator mediator)
		{
			this.mediator = mediator;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> Get(Guid id)
		{
			var result = new GetProductQuery() {Id = id};
			return Ok(await mediator.Send(result));
		}
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var result = new GetAllProduct();
			return Ok(await mediator.Send(result));
		}
		[HttpPost]
		public async Task<IActionResult> Post(CreateProductCommand productCommand)
		{
			return Ok(await mediator.Send(productCommand));
		}

	}
}
