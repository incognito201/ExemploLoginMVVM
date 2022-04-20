using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploLoginMVVM.WPF.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public MainViewModel()
        {
            LoginCommand = new DelegateCommand(Login);
        }

        public string Email { get; set; }

        public string Senha { get; set; }

        public DelegateCommand LoginCommand { get; set; }

        public void Login()
        {

        }
    }
}
