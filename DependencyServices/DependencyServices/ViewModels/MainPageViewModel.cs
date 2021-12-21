using DependencyServices.Interface;
using DependencyServices.Models;
using MUAHO.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using static Xamarin.Essentials.Permissions;

namespace DependencyServices.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<Models.Contact> Contacts { get; set; }
        public MainPageViewModel()
        {
            GetContactAsync();
            Call = new Command((x) =>
            {
                var item = x as Models.Contact;
                CallCommand(item.NumberContact);
            });
        }
        public async Task<PermissionStatus> CheckAndRequestPermissionAsync<T>(T permission)
            where T : BasePermission
        {
            var status = await permission.CheckStatusAsync();
            if (status != PermissionStatus.Granted)
            {
                status = await permission.RequestAsync();
            }

            return status;
        }
        public async Task GetContactAsync()
        {
            var status = await CheckAndRequestPermissionAsync(new Permissions.ContactsRead());
            if (status != PermissionStatus.Granted)
            {
                // Notify user permission was denied
                return;
            }
            else
            {
                Contacts = DependencyService.Get<IContact>().GetContact();
            }
            Contacts = DependencyService.Get<IContact>().GetContact();
        }
        public async Task CallCommand(string number)
        {
            var status = await CheckAndRequestPermissionAsync(new Permissions.Phone());
            if (status != PermissionStatus.Granted)
            {
                // Notify user permission was denied
                return;
            }
            DependencyService.Get<IContact>().Call(number);
        }
        public Command Call { get; }
    }

}
