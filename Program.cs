void PrintStr (string[] str){
    Console.Write("[");
    for (int i=0; i <  str.Length; i++){
        if (i == str.Length-1){
           Console.Write("\""+str[i]+"\"");
        }
        else Console.Write("\""+str[i]+"\", ");
    }
    Console.WriteLine("]");
}

string[] StringFilter (string[] str){
    int count = 0;
    
    for (int i=0; i < str.Length; i++){
        if (str[i].Length <= 3) count++;
    }
    
    string[] result = new string[count];

    int j = 0;
    for (int i=0; i < str.Length; i++){
        if (str[i].Length <= 3){
            result[j]=str[i];
            j++;
        }
    }

    return result;
}

int n = 5;
string[] str = new string[n];
Console.Write("Введите массив строк из "+ n +" элементов: ");

for(int i=0; i<n; i++){
    str[i] = Console.ReadLine();
}

Console.Write("Массив до обработки: ");
PrintStr(str);
Console.Write("Массив после обработки: ");
PrintStr(StringFilter(str));