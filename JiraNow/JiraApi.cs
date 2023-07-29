using JiraNow.Entities;
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
        public string SearchUri => BaseUri + "/search";

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
                if (part.Length == 2)
                {
                    string key = part[0];
                    string value = part[1];
                    Cookie cookie = new Cookie(key, value);
                    cookieCollection.Add(cookie);
                }
            }
            return cookieCollection;
        }

        public HttpClient JiraHttpClient()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = new System.Net.CookieContainer();
            handler.CookieContainer.Add(new Uri(BaseUri), ParseCookieString(Cookies));
            HttpClient client = new HttpClient(handler);
            //client.DefaultRequestHeaders.Add("Accept-Encoding", "br");
            //client.DefaultRequestHeaders.Add("Accept-Language", "zh-CN,zh;q=0.9,en-US;q=0.8,en;q=0.7");
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            //client.DefaultRequestHeaders.Add("Cookie", Cookies);
            //client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82");
            return client;
        }

        public async Task<JiraMessage> GetIssueByIdAsync(string issueId)
        {
            JiraMessage message = new JiraMessage();
            using (HttpClient client = JiraHttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(IssueUri+"/"+issueId);

                    message.isSuccess = response.IsSuccessStatusCode;
                    message.httpStatusCode = response.StatusCode;
                    message.jsonMessage = await response.Content.ReadAsStringAsync();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return message;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jql">for example: parent=SAM-1</param>
        /// <returns></returns>
        public async Task<JiraMessage> SearchIssue(string jql)
        {
            JiraMessage message = new JiraMessage();
            if (string.IsNullOrWhiteSpace(jql)) return message;
            using (HttpClient client = JiraHttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(SearchUri + "?jql=" + jql);

                    message.isSuccess = response.IsSuccessStatusCode;
                    message.httpStatusCode = response.StatusCode;
                    message.jsonMessage = await response.Content.ReadAsStringAsync();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return message;
        }

        public async Task<JiraMessage> CreateIssue(JiraIssue1 issue)
        {
            string json = "";//todo
            JiraMessage message = new JiraMessage();
            using (HttpClient client = JiraHttpClient())
            {
                try
                {
                    //HttpResponseMessage response = await client.PostAsync(IssueUri, json);

                    //message.isSuccess = response.IsSuccessStatusCode;
                    //message.httpStatusCode = response.StatusCode;
                    //message.jsonMessage = await response.Content.ReadAsStringAsync();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return message;
        }
    }
}
