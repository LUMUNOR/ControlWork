Программа Program.cs принимает из консоли массив строк(по умолчанию из 5-ти элементов) и возвращает массив строк состоящий из из строк принятого массива длина которых меньше или равна 3 символам.

Метод PrintStr (string[] str) осуществляет вывод передаемого ему массива строк в консоль.

Метод StringFilter (string[] str) возвращает массив строк состоящий из из строк принятого массива длина которых меньше или равна 3 символам. 
Метод посчитывает количество строк удовлетворяющих условию.
Затем создает новый массив строк нужной длины и помещает в него строки удовлетворяющие условию, затем возвращает данный массив.

Пример работы программы:

    PS C:\LEI\С#Контрольная> dotnet run
    Введите массив строк из 5 элементов: три
    3
    арбуз
    программа
    66
    Массив до обработки: ["три", "3", "арбуз", "программа", "66"]
    Массив после обработки: ["три", "3", "66"]
