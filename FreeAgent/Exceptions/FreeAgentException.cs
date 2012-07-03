﻿using System;
using RestSharp;
using System.Net;

namespace FreeAgent.Exceptions
{
    public class FreeAgentException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }
        /// <summary>
        /// The response of the error call (for Debugging use)
        /// </summary>
        public IRestResponse Response { get; private set; }

        public FreeAgentException()
        {
        }

        public FreeAgentException(string message)
            : base(message)
        {

        }

        public FreeAgentException(IRestResponse r)
        {
            Response = r;
            StatusCode = r.StatusCode;

        }

        public override string ToString()
        {
            return string.Format("[FreeAgentException: StatusCode={0}, Response={1}, Content={2}]", StatusCode, Response, Response.Content);
        }

    }
}
