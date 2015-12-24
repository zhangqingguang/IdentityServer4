﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTests.Common
{
    public class FakeLogger<T> : ILogger<T>
    {
        class FakeDisposable : IDisposable
        {
            public void Dispose()
            {
            }
        }

        public IDisposable BeginScopeImpl(object state)
        {
            return new FakeDisposable();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log(LogLevel logLevel, int eventId, object state, Exception exception, Func<object, Exception, string> formatter)
        {
        }
    }
}
