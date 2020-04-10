﻿using System;
using System.Net.Http.Headers;
using System.Reflection;

namespace System.Net.Http
{
    internal static class HttpRequestMessageExtensions
    {
        public static bool HasHeaders(this HttpRequestMessage request)
        {
            string headersFieldName = "_headers";
            FieldInfo headersField = typeof(HttpRequestMessage).GetField(headersFieldName, BindingFlags.Instance | BindingFlags.NonPublic);
            HttpRequestHeaders headers = (HttpRequestHeaders)headersField.GetValue(request);
            return headers != null;
        }
    }
}
