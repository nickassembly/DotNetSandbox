

string address = "1640 Riverside Drive";
ReadOnlySpan<char> addressSpan = address;
ReadOnlySpan<char> houseNumberSpan = addressSpan.Slice(0, 4);
ReadOnlySpan<char> streeNameSpan = addressSpan.Slice(5, 9);
ReadOnlySpan<char> streetTypeSpan = addressSpan.Slice(15, 5);

string houseNumber = address.Substring(0, 4);
string streetName = address.Substring(5, 9);
string streetType = address.Substring(15, 5);

Console.WriteLine(address);
Console.WriteLine(houseNumber);
Console.WriteLine(streetName);
Console.WriteLine(streetType);
