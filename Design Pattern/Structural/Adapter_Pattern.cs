using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Design_Pattern.Structural
{
    internal class Adapter_Pattern
    {

        public interface WebRequester
        {
            public int request(object oj);
        }

        class WebAdapter : WebRequester
        {
            private WebService _server;
            public void Connect(WebService webserver)
            {
                _server = webserver;

            }

            public int request(object oj)
            {
                JsonContent json = tojson(oj);

                if (json != null)
                {
                    return 200;
                }
                else return 404;
            }

            private tojson(object ob)
            {


            }
        }


        public class WebClient
        {
            private WebRequester webRequester;
            public WebClient(WebRequester webRequester)
            {
                this.webRequester = webRequester;
            }
            private object makeObject()
            {
                object obj = new object();
                return obj;
            }
            public void doWork()
            {
                object objec = makeObject();
                int status = webRequester.request(objec);
                if (status == 200)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Not OK");
                }
                return;
            }
        }


        class WebService
        {
            public int request(object oj)
            {
                if (oj != null) return 200;
                return 404;
            }
        }


    }
}
