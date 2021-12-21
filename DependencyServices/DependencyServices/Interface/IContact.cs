using DependencyServices.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DependencyServices.Interface
{
    public interface IContact
    {
        ObservableCollection<Contact> GetContact();
        void Call(string number);
    }
}
