string[] Array = { "apple", "dog", "cat", "sun", "car", "book", "a"};
string[] newArray = SortString(Array);

Console.WriteLine("Array:");
PrintArray(Array);

Console.WriteLine("\nArray after choosing elements with 3 and less symbols:");
PrintArray(newArray);

string[] SortString(string[] inputArray) {
    int count = 0;
    foreach (string str in inputArray) {
        if (str.Length <= 3) {
            count++;
        }
    }
        
    string[] sortedArray = new string[count];
    int index = 0;
    foreach (string str in inputArray) {
        if (str.Length <= 3) {
            sortedArray[index] = str;
            index++;
        }
    }
    return sortedArray;
}

void PrintArray(string[] array) {
    foreach (string element in array) {
        Console.WriteLine(element);
    }
}