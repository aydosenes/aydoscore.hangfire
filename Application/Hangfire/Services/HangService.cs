using Application.Features.Request.Commands;
using Application.Hangfire.Configurations;
using Application.Results;
using Domain.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Hangfire.Services
{
    public class HangService : IHangService
    {
        private readonly IMediator _mediator;
        private static int testNo = 0;
        public HangService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task Fire()
        {
            var jobId = Guid.NewGuid().ToString();
            testNo =+ 1;
            await Task.Run(() => _mediator.AddOrUpdate(jobId, new AddTestCommand
            {
                JobId = jobId,
                TestNo = testNo,
                TestName = "hangfire-test-" + testNo.ToString()
            }, CronExpressions.EveryMinutesOf(1))
            );
        }
    }
}
