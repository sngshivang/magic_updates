using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MagicUpdates
{
    class network
    {
        public initializer it;
        public async Task internetAsync_rst(int opt, Dictionary<string, string> dct)
        {
            try
            {
                HttpClient client = new HttpClient();
                var hclnt = new HttpClient();
                var url = "https://tuximages.xyz/magic_upd/core.php";
                var post = dct;
                var content = new FormUrlEncodedContent(post);
                var response = await client.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);
                //MessageBox.Show("Response from server", responseString, MessageBoxButtons.OK, MessageBoxIcon.Information);
                resp_action(opt, responseString);
            }
            catch(Exception e)
            {
                resp_action(1, "ERR");
            }
            /*var parameters = new Dictionary<string, string>();
            parameters["text"] = text;

            var response = await hclnt.PostAsync(BaseUri, new FormUrlEncodedContent(parameters));
            var contents = await response.Content.ReadAsStringAsync();*/

        }
        private void resp_action(int opt, string resp)
        {
            if (opt == 1)
            {
                it.retcall(opt, resp);
            }
        }
    }
}
