using Application.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Hangfire.Services
{
    public interface IHangService
    {
        Task Fire();
    }
}
