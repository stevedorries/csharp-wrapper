//----------------------------------------------------------------
// SimplyCastAPIConnector.cs
// Copyright SimplyCast 2014, Steve Dorries 2021
// This projected is licensed under the terms of the MIT license.
//  (see the attached LICENSE file).
//----------------------------------------------------------------

using System.Text;
using System.Text.Json;
using System.Net;
using SimplyCast.Common.Responses;
using System.Net.Http.Headers;

namespace SimplyCast
{
    /// <summary>
    /// SimplyCast REST API connector.
    /// See https://app.simplycast.com/?q=api/reference
    /// </summary>
    public class SimplyCastAPIConnector
    {
        #region Properties
        /// <summary>
        /// The public key, used to identify the user.
        /// </summary>
        private readonly string publicKey;

        /// <summary>
        /// The secret key, used in generating signatures.
        /// </summary>
        private readonly string secretKey;

        /// <summary>
        /// API URL, sans the resource endpoint.
        /// </summary>
        private string apiURL = "https://api.simplycast.com/";
        private readonly HttpClient webClient;
        #endregion

        public string URL
        {
            get { return apiURL; }
            set
            {
                apiURL = value;
                webClient.BaseAddress = new(apiURL);
            }
        }

        /// <summary>
        /// API constructor
        /// </summary>
        /// <param name="publicKey">The public key to make the request with.</param>
        /// <param name="secretKey">The secret key to make the request with.</param>
        public SimplyCastAPIConnector(string publicKey, string secretKey)
        {
            this.publicKey = publicKey;
            this.secretKey = secretKey;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            webClient = new HttpClient();
        }

        #region Utility Functions
        /// <summary>
        /// Main API calling function.
        /// </summary>
        /// <typeparam name="T">The entity response return type.</typeparam>
        /// <param name="method">The HTTP method (GET, POST, etc).</param>
        /// <param name="resource">The API resource (the part of the URL between the base URL and the query parameters.</param>
        /// <param name="queryParameters">A dictionary of request query parameters.</param>
        /// <param name="requestBody">A serializable object containing the request body.</param>
        /// <returns>A response entity.</returns>
        public T? Call<T>(string method, string resource, Dictionary<string, string>? queryParameters, object? requestBody)
        {
            StringContent data;
            string requestBodyHash = "";
            string url = apiURL.Trim('/') + '/' + resource.Trim('/');
            if (queryParameters != null && queryParameters.Count > 0)
            {
                url += "?";
                foreach (KeyValuePair<string, string> q in queryParameters)
                {
                    url += Uri.EscapeDataString(q.Key) + "=" + Uri.EscapeDataString(q.Value) + "&";
                }
                url = url.TrimEnd('&');
            }
            HttpMethod _method = HttpMethod.Get;
            switch (method)
            {
                case SimplyCastAPI.GET: _method = HttpMethod.Get; break;
                case SimplyCastAPI.POST: _method = HttpMethod.Post; break;
                case SimplyCastAPI.DELETE: _method = HttpMethod.Delete; break;
            }
            HttpRequestMessage req = new(_method, url);

            if (requestBody != null)
            {
                var requestBodyString = JsonSerializer.Serialize(requestBody);
                data = new StringContent(requestBodyString, Encoding.UTF8, "application/json");
                req.Content = data;
                requestBodyHash = Convert.ToBase64String(
                    Encoding.UTF8.GetBytes(BytesToHex(System.Security.Cryptography.MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(requestBodyString.Trim()))))
                );
                var bodyHashBytes = Encoding.UTF8.GetBytes(requestBodyHash);
                req.Content.Headers.ContentMD5 = bodyHashBytes;
            }

            string date = DateTime.UtcNow.ToString("r");

            string token = GenerateAuthToken(method, resource, date, requestBodyHash);

            req.Headers.Authorization = new AuthenticationHeaderValue("HMAC", token);
            req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            req.Headers.Add("X-Date", date);


            HttpResponseMessage? resp = webClient.Send(req);
            Stream? jsonStream = resp.Content.ReadAsStream();

            if (resp.StatusCode >= HttpStatusCode.BadRequest)
            {
                APIException exception;
                try
                {
                    Error? error = JsonSerializer.Deserialize<Error>(jsonStream);
                    exception = new APIException(error?.Message ?? "")
                    {
                        StatusCode = resp.StatusCode,
                        StatusDescription = resp.ReasonPhrase ?? ""
                    };
                }
                catch (Exception e)
                {
                    exception = new APIException("An error condition occurred from the API, but could not be deserialized.", e)
                    {
                        StatusCode = resp.StatusCode,
                        StatusDescription = resp.ReasonPhrase ?? ""
                    };
                }
                throw exception;
            }
            else if (resp.StatusCode == HttpStatusCode.NoContent)
            {
                return default;
            }



            var ret = JsonSerializer.Deserialize<T>(jsonStream);
            return ret;
        }

        public async Task<T?> CallAsync<T, U>(string method, string resource, Dictionary<string, string>? queryParameters, U? requestBody)
        {
            StringContent data;
            string requestBodyHash = "";
            string url = apiURL.Trim('/') + '/' + resource.Trim('/');
            if (queryParameters != null && queryParameters.Count > 0)
            {
                url += "?";
                foreach (KeyValuePair<string, string> q in queryParameters)
                {
                    url += Uri.EscapeDataString(q.Key) + "=" + Uri.EscapeDataString(q.Value) + "&";
                }
                url = url.TrimEnd('&');
            }
            HttpMethod _method = HttpMethod.Get;
            switch (method)
            {
                case SimplyCastAPI.GET: _method = HttpMethod.Get; break;
                case SimplyCastAPI.POST: _method = HttpMethod.Post; break;
                case SimplyCastAPI.DELETE: _method = HttpMethod.Delete; break;
            }
            HttpRequestMessage req = new(_method, url);

            if (requestBody != null)
            {
                var requestBodyString = JsonSerializer.Serialize(requestBody);
                data = new StringContent(requestBodyString, Encoding.UTF8, "application/json");
                req.Content = data;
                requestBodyHash = Convert.ToBase64String(
                    Encoding.UTF8.GetBytes(BytesToHex(System.Security.Cryptography.MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(requestBodyString.Trim()))))
                );
                var bodyHashBytes = Encoding.UTF8.GetBytes(requestBodyHash);
                req.Content.Headers.ContentMD5 = bodyHashBytes;
            }

            string date = DateTime.UtcNow.ToString("r");

            string token = GenerateAuthToken(method, resource, date, requestBodyHash);

            req.Headers.Authorization = new AuthenticationHeaderValue("HMAC", token);
            req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            req.Headers.Add("X-Date", date);


            HttpResponseMessage? resp = await webClient.SendAsync(req);
            Stream? jsonStream = await resp.Content.ReadAsStreamAsync();

            if (resp.StatusCode >= HttpStatusCode.BadRequest)
            {
                APIException exception;
                try
                {
                    Error? error = JsonSerializer.Deserialize<Error>(jsonStream);
                    exception = new APIException(error?.Message ?? "")
                    {
                        StatusCode = resp.StatusCode,
                        StatusDescription = resp.ReasonPhrase ?? ""
                    };
                }
                catch (Exception e)
                {
                    exception = new APIException("An error condition occurred from the API, but could not be deserialized.", e)
                    {
                        StatusCode = resp.StatusCode,
                        StatusDescription = resp.ReasonPhrase ?? ""
                    };
                }
                throw exception;
            }
            else if (resp.StatusCode == HttpStatusCode.NoContent)
            {
                return default;
            }



            var ret = await JsonSerializer.DeserializeAsync<T>(jsonStream);
            return ret;
        }

        private string GenerateAuthToken(string method, string resource, string date, string requestBodyHash)
        {
            string signature = (method + "\n" + date + "\n" + resource + "\n" + requestBodyHash).Trim();

            System.Security.Cryptography.HMACSHA1 hmac = new()
            {
                Key = Encoding.UTF8.GetBytes(secretKey)
            };

            var hmSig = hmac.ComputeHash(Encoding.UTF8.GetBytes(signature));

            string authStr = $"{publicKey}:{BytesToHex(hmSig)}";
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(authStr));
        }

        /// <summary>
        /// Given an array of bytes, convert it to a hex representation.
        /// </summary>
        /// <param name="bytes">The array of bytes to convert.</param>
        /// <returns>A hex string.</returns>
        public static string BytesToHex(byte[] bytes)
        {
            string str = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                str += bytes[i].ToString("x2");
            }
            return str;
        }

        #endregion
    }
}
