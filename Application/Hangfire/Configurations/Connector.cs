using Application.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Hangfire.Configurations
{
    public class Connector
    {
        private readonly IMediator _mediator;

        public Connector(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Send<T>(string jobId, IRequest<T> request) where T : class
        {
            var result = await _mediator.Send(request);
        }

    }
}
