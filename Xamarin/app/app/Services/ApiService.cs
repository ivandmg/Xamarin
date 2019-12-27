
using System;
using System.Collections.Generic;
using System.Text;

namespace app.Services
{
    
        using System;
        using System.Collections.Generic;
        using System.Net.Http;
        using System.Net.Http.Headers;
        using System.Text;
        using System.Threading.Tasks;
        using Newtonsoft.Json;
        using Plugin.Connectivity;
        using Models;
        public class ApiService
        {
            public async Task<Response> CheckConnection()
            {
                if (!CrossConnectivity.Current.IsConnected)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = "Please turn on your internet settings.",
                    };
                }
            }

        internal Task GetList<T>(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
    }
