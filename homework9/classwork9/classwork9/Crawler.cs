﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;

namespace classwork9
{
    class Crawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        public string limit;
        public List<Uri> RightUrl { get; set; }
        public List<Uri> WrongUrl { get; set; }
        public Crawler(string startUrl)
        {
            LoadURL(startUrl);
            urls.Add(startUrl, false);
            RightUrl = new List<Uri>();
            WrongUrl = new List<Uri>();
        }

        private void LoadURL(string startURL)
        {
            string baseUrl = Regex.Match(startURL, @"(http|https)://[a-z]+[.][a-zA-Z0-9]+[.][a-zA-Z0-9]+").Value;
            Regex regex = new Regex(@"(http|https)://[a-zA-Z0-9]+[.]");
            limit = regex.Replace(baseUrl, "");
        }
        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                if (Regex.IsMatch(current, @limit))
                {
                    RightUrl.Add(new Uri(current));
                    string html = DownLoad(current); 
                    urls[current] = true;
                    count++;
                    Parse(html, current);
                }
                else
                {
                    WrongUrl.Add(new Uri(current));
                }
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html, string root)
        {
            string strRef = @"(href|HREF)\s*=\s*[""']([^""']+\.(?:html|htm|aspx|jsp))";
            string strAbs = @"(^http|https)";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (!Regex.IsMatch(strRef, strAbs))
                {
                    if (strRef.StartsWith("//"))
                    {
                        strRef = "https:" + strRef;
                    }
                    else
                    {
                        Regex regex = new Regex(@"/$");
                        strRef = regex.Replace(root, "") + strRef;
                    }
                }
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null)
                {
                    urls[strRef] = false;
                }
            }
        }

    }
}

