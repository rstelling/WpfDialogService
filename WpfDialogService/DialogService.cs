using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDialogService
{
    public class DialogService : IDialogService
    {
        public void ShowDialogModal(DialogViewModelBase vm)
        {
            DialogView v = new DialogView();
            v.Owner = vm.Owner;
            v.DataContext = vm;
             vm.Modal = true;
            v.ShowDialog();
            v.Owner = null;
        }

        public void ShowDialogModeless(DialogViewModelBase vm)
        {
            DialogView v = new DialogView();
            v.Owner = vm.Owner;
            v.DataContext = vm;
            vm.Modal = false;
            v.Show();
            v.Owner = null;
        }

    }
}
