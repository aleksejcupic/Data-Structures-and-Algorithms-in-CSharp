using DSA;

var hashTable = new HashTable<int, string>(x => x.GetHashCode());

hashTable.Insert(new KeyValuePair<int, string>(1, "hello"));
hashTable.Insert(new KeyValuePair<int, string>(2, "world"));
var one = hashTable.Get(1);
Console.WriteLine(one);
var two = hashTable.Get(2);
Console.WriteLine(two);
var three = hashTable.Get(3);
Console.WriteLine(three ?? "3 is null");
