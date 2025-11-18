using APIpostagems.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace APIpostagems
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BuscarBtn_Clicked(object sender, EventArgs e)
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
                IdUsuaLbl.Text = postagens[0].UserId.ToString();
                IdLbl.Text = postagens[0].Id.ToString();
                TituloLbl.Text = postagens[0].Title;
                CorpoLbl.Text = postagens[0].Body;

                
            }
        }
    }

}
