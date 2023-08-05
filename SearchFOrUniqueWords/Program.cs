
var uniqurWords = FindUniqueWords("w1", "w2", "w2", "w1", "w3", "w3");
PrintArray(uniqurWords);
// 2.Посчтитать количество вхождений уникальных слов в оригинальный  набор слов
// 3. Отсортировать массив по частоте  использования  и альфавиту 

static string[] FindUniqueWords(params string[] array)
{
    var uniqueWords = new string[array.Length];
    var currentUniqueWordsIndex = 0;

    foreach (var word in array)
    {
       
        if (! Contains(uniqueWords, word))
        {
            uniqueWords[currentUniqueWordsIndex] = word;
            currentUniqueWordsIndex++;

        }

    }
    var uniqueWordsRized = Resize(uniqueWords, currentUniqueWordsIndex);
    
    return uniqueWords;
}

static string[] Resize(string[] array, int newSize)
{
    string[] resizrArray = new string[newSize];

    for (int index = 0; index < newSize; index++)
    {
        var uniqueWords = array[index];
        resizrArray[index] = uniqueWords;
    }

    return resizrArray;
}

static bool Contains(string[] arrayWods, string word)
{
    foreach (var someword in arrayWods)
    {
        if (word == someword)
        {
            return true;
        }
    }
    return false;
}

static void PrintArray(string[] array)
{
    foreach (var s in array)
    {
        Console.WriteLine(s);
    }
}