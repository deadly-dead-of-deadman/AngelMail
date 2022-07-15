using System.Collections.Generic;
using System.Collections.ObjectModel;
using Core.Data.Models;

namespace GUI.ViewModels;

public class MailListViewModel : ViewModelBase
{
    public MailListViewModel(IEnumerable<Message> messages)
    {
        Messages = new ObservableCollection<Message>(messages);
    }
    public ObservableCollection<Message> Messages { get; }
}