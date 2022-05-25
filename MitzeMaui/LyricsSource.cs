using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MitzeMaui
{
    internal class LyricsSource
    {
        public async Task<string> GetLyrics()
        {
            string xmlBody;
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("http://api.chartlyrics.com/apiv1.asmx/GetLyric?lyricId=410&lyricCheckSum=17f847bcfcd5901dbf867444e26f57b8"),
                };

                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    xmlBody = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception e)
            {
                return $"Error while getting lyrics xml: {e}";
            }

            try
            {
                var serializer = new XmlSerializer(typeof(GetLyricResult));
                var stringReader = new StringReader(xmlBody);
                var lyricResult = (GetLyricResult)serializer.Deserialize(stringReader);
                return lyricResult.Lyric;
            }
            catch (Exception e)
            {
                return $"Error while serializing xml: {e}";
            }
        }
    }
}
