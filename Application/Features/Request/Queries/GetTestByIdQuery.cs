using Application.Dtos;
using Application.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Request.Queries
{
    public class GetTestByIdQuery : IRequest<IDataResult<TestDto>>
    {
        public int Id { get; set; }
    }
}
