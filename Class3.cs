using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Handlers;
using System.Net.Http.Headers;

namespace tamrin_8_._try
{ public class Class4
    {  public static async Task<Class2> GetAPI()
        { 
            string API = "https://api.kucoin.com/api/v1/market/stats?symbol=ETH-USDT";
            using (HttpResponseMessage message = await Class.http.GetAsync(API))
            {
                if (message.IsSuccessStatusCode)
                {
                    Class25 class25 = await message.Content.ReadAsAsync<Class25>();

                    return class25.data;
                }
                else
                {
                    throw new Exception(message.ReasonPhrase);
                }



            }
        
        
        
        
        
        
        }
         
    
    
    
    }
      
 }
   
            


       
               
                
                       


