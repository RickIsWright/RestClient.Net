﻿using System;

namespace RestClientDotNet.Abstractions
{
    public interface ITracer
    {
        void Trace(HttpVerb httpVerb, Uri requestUri, byte[] body, TraceType traceType, int? httpStatusCode, IRestHeadersCollection restHeadersCollection);
    }
}
