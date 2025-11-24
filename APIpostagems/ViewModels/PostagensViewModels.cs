using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIpostagems.ViewModels
{
    public class PostagensViewModels : ObservableObject
    {
        [ObservableProperty]
        public int userId;
        int id;
        string title;
        string body;
        

    }
}
