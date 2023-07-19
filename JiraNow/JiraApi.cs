using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JiraNow
{
    internal class JiraApi
    {
        public string BaseUri { get; private set; }
        public string Cookies { get; private set; }

        public string IssueUri => BaseUri + "/issue";

        public JiraApi(string baseUri, string cookies)
        {
            BaseUri = baseUri;
            Cookies = cookies;
        }

        CookieCollection ParseCookieString(string cookieString)
        {
            CookieCollection cookieCollection = new CookieCollection();
            string[] items = cookieString.Split(';');
            foreach(string item in items)
            {
                string[] part = item.Trim().Split('=');
                string key = part[0];
                string value = part[1];
                Cookie cookie = new Cookie(key, value);
                cookieCollection.Add(cookie);
            }
            return cookieCollection;
        }

        public async Task<string> GetIssueByIdAsync(string issueId)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = new System.Net.CookieContainer();
            handler.CookieContainer.Add(new Uri(BaseUri), ParseCookieString(Cookies));


            using (HttpClient client = new HttpClient(handler))
            {
                try
                {
                    //client.DefaultRequestHeaders.Add("Accept-Encoding", "br");
                    //client.DefaultRequestHeaders.Add("Accept-Language", "zh-CN,zh;q=0.9,en-US;q=0.8,en;q=0.7");
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    //client.DefaultRequestHeaders.Add("Cookie", Cookies);
                    //client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82");

                    HttpResponseMessage response = await client.GetAsync(IssueUri+"/"+issueId);

                    response.EnsureSuccessStatusCode();

                    string json = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(json);
                    return json;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return string.Empty;
        }
    }
}
