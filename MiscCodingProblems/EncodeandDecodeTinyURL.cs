using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 535. Encode and Decode TinyURL
    /// </summary>
    public class EncodeandDecodeTinyURL
    {
        public Dictionary<string, string> Encoded { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> Decoded { get; set; } = new Dictionary<string, string>();

        public const string baseUrl = @"www.tinyurl.com\";
        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            if (Encoded.ContainsKey(longUrl)) return Encoded[longUrl];
            var shortUrl = baseUrl + Encoded.Keys.Count + 1;
            Encoded[longUrl] = shortUrl;
            Decoded[shortUrl] = longUrl;
            return shortUrl;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            return Decoded[shortUrl];
        }
    }
}
