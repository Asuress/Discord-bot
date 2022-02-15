using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Discord_bot.Types.Web
{
    public class DiscordHttpClient
    {
        HttpClient httpClient;
        string mainUrl;

        public HttpClient HttpClient { get => httpClient; private set => httpClient = value; }
        public string MainUrl { get => mainUrl; private set => mainUrl = value; }

        public DiscordHttpClient(HttpClient httpClient, string mainUrl)
        {
            httpClient.BaseAddress = new Uri(mainUrl);
            this.httpClient = httpClient;
            this.mainUrl = mainUrl;
        }

        public async Task<HttpResponseMessage> PostAsync(string endpoint, string content, string[] parameters)
        {
            var strContent = new StringContent(content);
            strContent.Headers.ContentType.MediaType = "application/json";
            return await httpClient.PostAsync(BuildUrl(endpoint, parameters), strContent);
        }

        public async Task<HttpResponseMessage> PutAsync(string endpoint, string content, string[] parameters)
        {
            var strContent = new StringContent(content);
            strContent.Headers.ContentType.MediaType = "application/json";
            return await httpClient.PutAsync(BuildUrl($"{mainUrl}{endpoint}", parameters), strContent);
        }

        public async Task<HttpResponseMessage> PatchAsync(string endpoint, string content, string[] parameters)
        {
            var strContent = new StringContent(content);
            strContent.Headers.ContentType.MediaType = "application/json";
            return await httpClient.PatchAsync(BuildUrl($"{mainUrl}{endpoint}", parameters), strContent);
        }

        public async Task<HttpResponseMessage> GetAsync(string endpoint, string[] parameters)
        {
            return await httpClient.GetAsync(BuildUrl(endpoint, parameters));
        }

        public async Task<HttpResponseMessage> DeleteAsync(string endpoint, string[] parameters)
        {
            return await httpClient.DeleteAsync(BuildUrl(endpoint, parameters));
        }

        private Uri BuildUrl(string endpoint, string[] parameters)
        {
            UriBuilder builder = new UriBuilder($"{mainUrl}{endpoint}");
            foreach (var p in parameters)
            {
                if (builder.Query == string.Empty)
                {
                    builder.Query = p;
                }
                else
                {
                    builder.Query += "&" + p;
                }
            }
            Uri uri = builder.Uri;
            return uri;
        }

    }
}