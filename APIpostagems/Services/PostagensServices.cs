using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIpostagems.Models;
using Newtonsoft.Json;

namespace APIpostagems.Services
{
    internal class PostagensServices
    {
        public async Task<Postagem> GetAllPostagem()
            {
                Postagem minhaPostagem = new Postagem();
                string URI = "https://jsonplaceholder.typicode.com/posts";
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage responseMessage = await httpClient.GetAsync(URI);

            List<Postagem> postagens = new List<Postagem>();

                if (responseMessage.IsSuccessStatusCode)
                {
                    string conteudo = await responseMessage.Content.ReadAsStringAsync();

                    postagens = JsonConvert.DeserializeObject<List<Postagem>>(conteudo);
                    


                }
            return postagens[0];
             }
    }
}
