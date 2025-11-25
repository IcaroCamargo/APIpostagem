using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIpostagems.ViewModels
{
    public partial class PostagensViewModels : ObservableObject
    {
        [ObservableProperty]
        public int userId;
        [ObservableProperty]
        int id;
        [ObservableProperty]
        string title;
        [ObservableProperty]
        string body;
        

        //Método que busca as informações
        //"Exibir na tela"

    }
}
