using System.Collections.Generic;
using ListBoxIssue.Objects;
using ReactiveUI;

namespace ListBoxIssue.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public Dictionary<string, SomeClass> SomeDictionary { get; set; }= new()
        {
            ["One"] = new SomeClass(),
            ["Two"] = new SomeClass() {SomeNumber = 2},
            ["Three"] = new SomeClass() {SomeNumber = 3}
        };
    }
}
