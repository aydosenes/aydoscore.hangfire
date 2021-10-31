﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Results
{
    public class DataResult<T> : BaseResult, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
