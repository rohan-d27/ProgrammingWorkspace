// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;

//Console.WriteLine("Hello, World!");

//A dynamic collection of elements that raises events when
//elements are added to or removed from the collection.
//ObservableCollection<string> names = new();
//names.CollectionChanged += Names_CollectionChanged;
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Enter name: ");
//    var str = Console.ReadLine();
//    if (str != null)
//        names.Add(str);
//}

//void Names_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
//{
//    Console.WriteLine("Collection changed");
//}



//A
//collection of name/value pairs that is commonly used for
//storing and retrieving configuration settings and query
//parameters
NameValueCollection stateCapital = new();

stateCapital.Add("Maharashtra", "Mumbai");
stateCapital.Add("Madhya Pradesh", "Bhopal");
stateCapital.Add("Gujarat", "Gandhi Nagar");
stateCapital.Add("Telengana", "Hyderabad");
stateCapital.Add("Bihar", "Patana");

string?[] states = stateCapital.AllKeys;

if (states != null && states.Length > 0)
{
    foreach (string state in states)
    {
        Console.WriteLine($"{state} has capital {stateCapital[state]}");
    }
}
