using Android.App;
using Android.Content;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DependencyServices.Droid;
using DependencyServices.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(ContactHelper))]
namespace DependencyServices.Droid
{
    public class ContactHelper : Interface.IContact
    {
        public void Call(string number)
        {
            Intent callIntent = new Intent(Intent.ActionCall);
            callIntent.SetData(Android.Net.Uri.Parse("tel:" + number));
            Forms.Context.StartActivity(callIntent);
        }

        [Obsolete]
        public ObservableCollection<Contact> GetContact()
        {
            Contact contact = new Contact();
            ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
            var uri = Android.Provider.ContactsContract.CommonDataKinds.Phone.ContentUri;
            string[] projection = { Android.Provider.ContactsContract.Contacts.InterfaceConsts.Id, ContactsContract.Contacts.InterfaceConsts.DisplayName, ContactsContract.CommonDataKinds.Phone.Number };
            var cursor = Forms.Context.ContentResolver.Query(uri, projection, null, null, null);
            if (cursor.MoveToFirst())
            {
                do
                {
                     contacts.Add(new Contact()
                    {
                        NameContact = cursor.GetString(cursor.GetColumnIndex(projection[1])),
                        NumberContact = cursor.GetString(cursor.GetColumnIndex(projection[2]))
                    });
                } while (cursor.MoveToNext());
            }
            return contacts;
        }
    }
}