using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace stefanb.git.extensions.http
{
    public static class HttpExtension
    {
        public static T GetObjectFromHttpResult<T>(this HttpWebResponse response)
        {
            string result = "";
            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.Default))
            {
                result = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
