// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Edge.Agent.Edgelet.GeneratedCode
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Globalization;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

#pragma warning disable // Disable all warnings

    [GeneratedCode("NSwag", "11.17.12.0 (NJsonSchema v9.10.50.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class EdgeletHttpClient
    {
        private string _baseUrl = "http://";
        private HttpClient _httpClient;
        private Lazy<JsonSerializerSettings> _settings;

        public EdgeletHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _settings = new Lazy<JsonSerializerSettings>(
                () =>
                {
                    var settings = new JsonSerializerSettings();
                    UpdateJsonSerializerSettings(settings);
                    return settings;
                });
        }

        public string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }

        protected JsonSerializerSettings JsonSerializerSettings
        {
            get { return _settings.Value; }
        }

        /// <summary>List modules.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <returns>Ok</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<ModuleList> ListModulesAsync(string api_version)
        {
            return ListModulesAsync(api_version, CancellationToken.None);
        }

        /// <summary>List modules.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <returns>Ok</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task<ModuleList> ListModulesAsync(string api_version, CancellationToken cancellationToken)
        {
            if (api_version == null)
                throw new ArgumentNullException("api_version");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/modules?");
            urlBuilder_.Append("api-version=").Append(WebUtility.UrlEncode(ConvertToString(api_version, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ModuleList);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ModuleList>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Error", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Return host system information.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <returns>Ok</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<SystemInfo> GetSystemInfoAsync(string api_version)
        {
            return GetSystemInfoAsync(api_version, CancellationToken.None);
        }

        /// <summary>Return host system information.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <returns>Ok</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task<SystemInfo> GetSystemInfoAsync(string api_version, CancellationToken cancellationToken)
        {
            if (api_version == null)
                throw new ArgumentNullException("api_version");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/systeminfo?");
            urlBuilder_.Append("api-version=").Append(WebUtility.UrlEncode(ConvertToString(api_version, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(SystemInfo);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<SystemInfo>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Error", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Create module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="module"></param>
        /// <returns>Created</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<ModuleDetails> CreateModuleAsync(string api_version, ModuleSpec module)
        {
            return CreateModuleAsync(api_version, module, CancellationToken.None);
        }

        /// <summary>Create module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <returns>Created</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="module"></param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task<ModuleDetails> CreateModuleAsync(string api_version, ModuleSpec module, CancellationToken cancellationToken)
        {
            if (api_version == null)
                throw new ArgumentNullException("api_version");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/modules?");
            urlBuilder_.Append("api-version=").Append(WebUtility.UrlEncode(ConvertToString(api_version, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(module, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ModuleDetails);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ModuleDetails>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else if (status_ == "409")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Conflict. Returned if module already exists.", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Error", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Get a module's status.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to get. (urlencoded)</param>
        /// <returns>Ok</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<ModuleDetails> GetModuleAsync(string api_version, string name)
        {
            return GetModuleAsync(api_version, name, CancellationToken.None);
        }

        /// <summary>Get a module's status.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to get. (urlencoded)</param>
        /// <returns>Ok</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task<ModuleDetails> GetModuleAsync(string api_version, string name, CancellationToken cancellationToken)
        {
            if (name == null)
                throw new ArgumentNullException("name");

            if (api_version == null)
                throw new ArgumentNullException("api_version");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/modules/{name}?");
            urlBuilder_.Replace("{name}", WebUtility.UrlEncode(ConvertToString(name, CultureInfo.InvariantCulture)));
            urlBuilder_.Append("api-version=").Append(WebUtility.UrlEncode(ConvertToString(api_version, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ModuleDetails);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ModuleDetails>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else if (status_ == "404")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Not Found", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Error", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Update a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to update. (urlencoded)</param>
        /// <param name="start">Flag indicating whether module should be started after updating.</param>
        /// <param name="module"></param>
        /// <returns>Ok</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<ModuleDetails> UpdateModuleAsync(string api_version, string name, bool? start, ModuleSpec module)
        {
            return UpdateModuleAsync(api_version, name, start, module, CancellationToken.None);
        }

        /// <summary>Update a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to update. (urlencoded)</param>
        /// <param name="start">Flag indicating whether module should be started after updating.</param>
        /// <returns>Ok</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="module"></param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task<ModuleDetails> UpdateModuleAsync(string api_version, string name, bool? start, ModuleSpec module, CancellationToken cancellationToken)
        {
            if (name == null)
                throw new ArgumentNullException("name");

            if (api_version == null)
                throw new ArgumentNullException("api_version");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/modules/{name}?");
            urlBuilder_.Replace("{name}", WebUtility.UrlEncode(ConvertToString(name, CultureInfo.InvariantCulture)));
            urlBuilder_.Append("api-version=").Append(WebUtility.UrlEncode(ConvertToString(api_version, CultureInfo.InvariantCulture))).Append("&");
            if (start != null) urlBuilder_.Append("start=").Append(WebUtility.UrlEncode(ConvertToString(start, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(module, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ModuleDetails);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ModuleDetails>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else if (status_ == "404")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Not Found", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Error", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Delete a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to delete. (urlencoded)</param>
        /// <returns>No Content</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task DeleteModuleAsync(string api_version, string name)
        {
            return DeleteModuleAsync(api_version, name, CancellationToken.None);
        }

        /// <summary>Delete a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to delete. (urlencoded)</param>
        /// <returns>No Content</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task DeleteModuleAsync(string api_version, string name, CancellationToken cancellationToken)
        {
            if (name == null)
                throw new ArgumentNullException("name");

            if (api_version == null)
                throw new ArgumentNullException("api_version");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/modules/{name}?");
            urlBuilder_.Replace("{name}", WebUtility.UrlEncode(ConvertToString(name, CultureInfo.InvariantCulture)));
            urlBuilder_.Append("api-version=").Append(WebUtility.UrlEncode(ConvertToString(api_version, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200" || status_ == "204")
                        {
                            return;
                        }
                        else if (status_ == "404")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Not Found", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Error", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Start a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to start. (urlencoded)</param>
        /// <returns>No Content</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task StartModuleAsync(string api_version, string name)
        {
            return StartModuleAsync(api_version, name, CancellationToken.None);
        }

        /// <summary>Start a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to start. (urlencoded)</param>
        /// <returns>No Content</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task StartModuleAsync(string api_version, string name, CancellationToken cancellationToken)
        {
            if (name == null)
                throw new ArgumentNullException("name");

            if (api_version == null)
                throw new ArgumentNullException("api_version");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/modules/{name}/start?");
            urlBuilder_.Replace("{name}", WebUtility.UrlEncode(ConvertToString(name, CultureInfo.InvariantCulture)));
            urlBuilder_.Append("api-version=").Append(WebUtility.UrlEncode(ConvertToString(api_version, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200" || status_ == "204")
                        {
                            return;
                        }
                        else if (status_ == "304")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("Not Modified", (int)response_.StatusCode, responseData_, headers_, null);
                        }
                        else if (status_ == "404")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Not Found", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Error", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Stop a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to stop. (urlencoded)</param>
        /// <returns>No Content</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task StopModuleAsync(string api_version, string name)
        {
            return StopModuleAsync(api_version, name, CancellationToken.None);
        }

        /// <summary>Stop a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to stop. (urlencoded)</param>
        /// <returns>No Content</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task StopModuleAsync(string api_version, string name, CancellationToken cancellationToken)
        {
            if (name == null)
                throw new ArgumentNullException("name");

            if (api_version == null)
                throw new ArgumentNullException("api_version");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/modules/{name}/stop?");
            urlBuilder_.Replace("{name}", WebUtility.UrlEncode(ConvertToString(name, CultureInfo.InvariantCulture)));
            urlBuilder_.Append("api-version=").Append(WebUtility.UrlEncode(ConvertToString(api_version, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200" || status_ == "204")
                        {
                            return;
                        }
                        else if (status_ == "304")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("Not Modified", (int)response_.StatusCode, responseData_, headers_, null);
                        }
                        else if (status_ == "404")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Not Found", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Error", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Restart a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to restart. (urlencoded)</param>
        /// <returns>No Content</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task RestartModuleAsync(string api_version, string name)
        {
            return RestartModuleAsync(api_version, name, CancellationToken.None);
        }

        /// <summary>Restart a module.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the module to restart. (urlencoded)</param>
        /// <returns>No Content</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task RestartModuleAsync(string api_version, string name, CancellationToken cancellationToken)
        {
            if (name == null)
                throw new ArgumentNullException("name");

            if (api_version == null)
                throw new ArgumentNullException("api_version");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/modules/{name}/restart?");
            urlBuilder_.Replace("{name}", WebUtility.UrlEncode(ConvertToString(name, CultureInfo.InvariantCulture)));
            urlBuilder_.Append("api-version=").Append(WebUtility.UrlEncode(ConvertToString(api_version, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200" || status_ == "204")
                        {
                            return;
                        }
                        else if (status_ == "304")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("Not Modified", (int)response_.StatusCode, responseData_, headers_, null);
                        }
                        else if (status_ == "404")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Not Found", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Error", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>List identities.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <returns>Ok</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<IdentityList> ListIdentitiesAsync(string api_version)
        {
            return ListIdentitiesAsync(api_version, CancellationToken.None);
        }

        /// <summary>List identities.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <returns>Ok</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task<IdentityList> ListIdentitiesAsync(string api_version, CancellationToken cancellationToken)
        {
            if (api_version == null)
                throw new ArgumentNullException("api_version");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/identities/?");
            urlBuilder_.Append("api-version=").Append(WebUtility.UrlEncode(ConvertToString(api_version, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200" || status_ == "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(IdentityList);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<IdentityList>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Error", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Create an identity.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="identity"></param>
        /// <returns>Created</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<Identity> CreateIdentityAsync(string api_version, IdentitySpec identity)
        {
            return CreateIdentityAsync(api_version, identity, CancellationToken.None);
        }

        /// <summary>Create an identity.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <returns>Created</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="identity"></param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task<Identity> CreateIdentityAsync(string api_version, IdentitySpec identity, CancellationToken cancellationToken)
        {
            if (api_version == null)
                throw new ArgumentNullException("api_version");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/identities/?");
            urlBuilder_.Append("api-version=").Append(WebUtility.UrlEncode(ConvertToString(api_version, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(identity, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(Identity);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<Identity>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Error", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Update an identity.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the identity to update. (urlencoded)</param>
        /// <param name="updateinfo"></param>
        /// <returns>Updated</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<Identity> UpdateIdentityAsync(string api_version, string name, UpdateIdentity updateinfo)
        {
            return UpdateIdentityAsync(api_version, name, updateinfo, CancellationToken.None);
        }

        /// <summary>Update an identity.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the identity to update. (urlencoded)</param>
        /// <returns>Updated</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="updateinfo"></param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task<Identity> UpdateIdentityAsync(string api_version, string name, UpdateIdentity updateinfo, CancellationToken cancellationToken)
        {
            if (name == null)
                throw new ArgumentNullException("name");

            if (api_version == null)
                throw new ArgumentNullException("api_version");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/identities/{name}?");
            urlBuilder_.Replace("{name}", WebUtility.UrlEncode(ConvertToString(name, CultureInfo.InvariantCulture)));
            urlBuilder_.Append("api-version=").Append(WebUtility.UrlEncode(ConvertToString(api_version, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(updateinfo, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(Identity);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<Identity>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Error", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Delete an identity.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the identity to delete. (urlencoded)</param>
        /// <returns>Ok</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task DeleteIdentityAsync(string api_version, string name)
        {
            return DeleteIdentityAsync(api_version, name, CancellationToken.None);
        }

        /// <summary>Delete an identity.</summary>
        /// <param name="api_version">The version of the API.</param>
        /// <param name="name">The name of the identity to delete. (urlencoded)</param>
        /// <returns>Ok</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task DeleteIdentityAsync(string api_version, string name, CancellationToken cancellationToken)
        {
            if (name == null)
                throw new ArgumentNullException("name");

            if (api_version == null)
                throw new ArgumentNullException("api_version");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/identities/{name}?");
            urlBuilder_.Replace("{name}", WebUtility.UrlEncode(ConvertToString(name, CultureInfo.InvariantCulture)));
            urlBuilder_.Append("api-version=").Append(WebUtility.UrlEncode(ConvertToString(api_version, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200" || status_ == "204")
                        {
                            return;
                        }
                        else if (status_ == "404")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Not Found", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            }
                            catch (Exception exception_)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }

                            throw new SwaggerException<ErrorResponse>("Error", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        partial void UpdateJsonSerializerSettings(JsonSerializerSettings settings);

        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url);

        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, StringBuilder urlBuilder);

        partial void ProcessResponse(HttpClient client, HttpResponseMessage response);

        private string ConvertToString(object value, CultureInfo cultureInfo)
        {
            if (value is Enum)
            {
                string name = Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = CustomAttributeExtensions.GetCustomAttribute(field, typeof(EnumMemberAttribute))
                            as EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value;
                        }
                    }
                }
            }
            else if (value is byte[])
            {
                return Convert.ToBase64String((byte[])value);
            }
            else if (value.GetType().IsArray)
            {
                var array = Enumerable.OfType<object>((Array)value);
                return string.Join(",", Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }

            return Convert.ToString(value, cultureInfo);
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SystemInfo : INotifyPropertyChanged
    {
        private string _osType;
        private string _architecture;
        private string _version;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("architecture", Required = Required.Always)]
        public string Architecture
        {
            get { return _architecture; }
            set
            {
                if (_architecture != value)
                {
                    _architecture = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("osType", Required = Required.Always)]
        public string OsType
        {
            get { return _osType; }
            set
            {
                if (_osType != value)
                {
                    _osType = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("version", Required = Required.DisallowNull)]
        public string Version
        {
            get { return _version; }
            set
            {
                if (_version != value)
                {
                    _version = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static SystemInfo FromJson(string data)
        {
            return JsonConvert.DeserializeObject<SystemInfo>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ModuleList : INotifyPropertyChanged
    {
        private ObservableCollection<ModuleDetails> _modules = new ObservableCollection<ModuleDetails>();

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("modules", Required = Required.Always)]
        public ObservableCollection<ModuleDetails> Modules
        {
            get { return _modules; }
            set
            {
                if (_modules != value)
                {
                    _modules = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static ModuleList FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ModuleList>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ModuleDetails : INotifyPropertyChanged
    {
        private string _id;
        private string _name;
        private string _type;
        private Config _config = new Config();
        private Status _status = new Status();

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("config", Required = Required.Always)]
        public Config Config
        {
            get { return _config; }
            set
            {
                if (_config != value)
                {
                    _config = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>System generated unique identitier.</summary>
        [JsonProperty("id", Required = Required.Always)]
        public string Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the module.</summary>
        [JsonProperty("name", Required = Required.Always)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("status", Required = Required.Always)]
        public Status Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The type of a module.</summary>
        [JsonProperty("type", Required = Required.Always)]
        public string Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static ModuleDetails FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ModuleDetails>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ModuleSpec : INotifyPropertyChanged
    {
        private string _name;
        private string _type;
        private Config _config = new Config();

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("config", Required = Required.Always)]
        public Config Config
        {
            get { return _config; }
            set
            {
                if (_config != value)
                {
                    _config = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of a the module.</summary>
        [JsonProperty("name", Required = Required.Always)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("type", Required = Required.Always)]
        public string Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static ModuleSpec FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ModuleSpec>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Config : INotifyPropertyChanged
    {
        private object _settings = new object();
        private ObservableCollection<EnvVar> _env;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("env", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<EnvVar> Env
        {
            get { return _env; }
            set
            {
                if (_env != value)
                {
                    _env = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("settings", Required = Required.Always)]
        public object Settings
        {
            get { return _settings; }
            set
            {
                if (_settings != value)
                {
                    _settings = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static Config FromJson(string data)
        {
            return JsonConvert.DeserializeObject<Config>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Status : INotifyPropertyChanged
    {
        private DateTime? _startTime;
        private ExitStatus _exitStatus;
        private RuntimeStatus _runtimeStatus = new RuntimeStatus();

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("exitStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExitStatus ExitStatus
        {
            get { return _exitStatus; }
            set
            {
                if (_exitStatus != value)
                {
                    _exitStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("runtimeStatus", Required = Required.Always)]
        public RuntimeStatus RuntimeStatus
        {
            get { return _runtimeStatus; }
            set
            {
                if (_runtimeStatus != value)
                {
                    _runtimeStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("startTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartTime
        {
            get { return _startTime; }
            set
            {
                if (_startTime != value)
                {
                    _startTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static Status FromJson(string data)
        {
            return JsonConvert.DeserializeObject<Status>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class EnvVar : INotifyPropertyChanged
    {
        private string _key;
        private string _value;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("key", Required = Required.Always)]
        public string Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    _key = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("value", Required = Required.Always)]
        public string Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static EnvVar FromJson(string data)
        {
            return JsonConvert.DeserializeObject<EnvVar>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ExitStatus : INotifyPropertyChanged
    {
        private DateTime _exitTime;
        private string _statusCode;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("exitTime", Required = Required.Always)]
        public DateTime ExitTime
        {
            get { return _exitTime; }
            set
            {
                if (_exitTime != value)
                {
                    _exitTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("statusCode", Required = Required.Always)]
        public string StatusCode
        {
            get { return _statusCode; }
            set
            {
                if (_statusCode != value)
                {
                    _statusCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static ExitStatus FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ExitStatus>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class RuntimeStatus : INotifyPropertyChanged
    {
        private string _status;
        private string _description;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("status", Required = Required.Always)]
        public string Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static RuntimeStatus FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RuntimeStatus>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class IdentityList : INotifyPropertyChanged
    {
        private ObservableCollection<Identity> _identities = new ObservableCollection<Identity>();

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("identities", Required = Required.Always)]
        public ObservableCollection<Identity> Identities
        {
            get { return _identities; }
            set
            {
                if (_identities != value)
                {
                    _identities = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static IdentityList FromJson(string data)
        {
            return JsonConvert.DeserializeObject<IdentityList>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class IdentitySpec : INotifyPropertyChanged
    {
        private string _moduleId;
        private string _managedBy;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("managedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedBy
        {
            get { return _managedBy; }
            set
            {
                if (_managedBy != value)
                {
                    _managedBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("moduleId", Required = Required.Always)]
        public string ModuleId
        {
            get { return _moduleId; }
            set
            {
                if (_moduleId != value)
                {
                    _moduleId = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static IdentitySpec FromJson(string data)
        {
            return JsonConvert.DeserializeObject<IdentitySpec>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class UpdateIdentity : INotifyPropertyChanged
    {
        private string _generationId;
        private string _managedBy;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("generationId", Required = Required.Always)]

        public string GenerationId
        {
            get { return _generationId; }
            set
            {
                if (_generationId != value)
                {
                    _generationId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("managedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedBy
        {
            get { return _managedBy; }
            set
            {
                if (_managedBy != value)
                {
                    _managedBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static UpdateIdentity FromJson(string data)
        {
            return JsonConvert.DeserializeObject<UpdateIdentity>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Identity : INotifyPropertyChanged
    {
        private string _moduleId;
        private string _managedBy;
        private string _generationId;
        private IdentityAuthType _authType;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("authType", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public IdentityAuthType AuthType
        {
            get { return _authType; }
            set
            {
                if (_authType != value)
                {
                    _authType = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("generationId", Required = Required.Always)]
        public string GenerationId
        {
            get { return _generationId; }
            set
            {
                if (_generationId != value)
                {
                    _generationId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("managedBy", Required = Required.Always)]
        public string ManagedBy
        {
            get { return _managedBy; }
            set
            {
                if (_managedBy != value)
                {
                    _managedBy = value;
                    RaisePropertyChanged();
                }
            }
        }

        [JsonProperty("moduleId", Required = Required.Always)]
        public string ModuleId
        {
            get { return _moduleId; }
            set
            {
                if (_moduleId != value)
                {
                    _moduleId = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static Identity FromJson(string data)
        {
            return JsonConvert.DeserializeObject<Identity>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ErrorResponse : INotifyPropertyChanged
    {
        private string _message;

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty("message", Required = Required.Always)]
        public string Message
        {
            get { return _message; }
            set
            {
                if (_message != value)
                {
                    _message = value;
                    RaisePropertyChanged();
                }
            }
        }

        public static ErrorResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ErrorResponse>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NJsonSchema", "9.10.50.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum IdentityAuthType
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Sas")]
        Sas = 1,

        [EnumMember(Value = "X509")]
        X509 = 2,
    }

    [GeneratedCode("NSwag", "11.17.12.0 (NJsonSchema v9.10.50.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class SwaggerException : Exception
    {
        public SwaggerException(string message, int statusCode, string response, Dictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        public string Response { get; private set; }

        public int StatusCode { get; private set; }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [GeneratedCode("NSwag", "11.17.12.0 (NJsonSchema v9.10.50.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class SwaggerException<TResult> : SwaggerException
    {
        public SwaggerException(string message, int statusCode, string response, Dictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }

        public TResult Result { get; private set; }
    }
}
