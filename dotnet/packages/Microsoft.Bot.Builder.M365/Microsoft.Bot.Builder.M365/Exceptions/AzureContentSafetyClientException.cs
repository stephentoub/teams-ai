﻿using System.Net;

namespace Microsoft.Bot.Builder.M365.Exceptions
{
    public class AzureContentSafetyClientException: Exception
    {
        public readonly HttpStatusCode? statusCode;

        public AzureContentSafetyClientException()
        {
        }

        public AzureContentSafetyClientException(string message, HttpStatusCode? httpStatusCode = null) : base(message)
        {
            statusCode = httpStatusCode;
        }

        public AzureContentSafetyClientException(string message, Exception innerException, HttpStatusCode? httpStatusCode = null) : base(message, innerException)
        {
            statusCode = httpStatusCode;
        }
    }
}