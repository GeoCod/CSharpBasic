using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

static class Message
{
    //2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    //а) Вывести только те слова сообщения, которые содержат не более n букв.
    /// <summary>
    /// Вывод слов соответствующей длины
    /// </summary>
    /// <param name="str">Проверяемый текст</param>
    /// <param name="limit">Количество символов</param>
    /// <returns>Строка из соответствующих слов</returns>
    public static string LetterLimit(string str, int limit)
    {
        string[] words = SeparationString(str);
        var list = new List<string>();

        string pattern = @"\b(\w{" + Regex.Escape(limit.ToString()) + @"})\b";
        Regex regex = new Regex(pattern);
        for (int i = 0; i < words.Length; ++i)
        {
            if (regex.IsMatch(words[i])) list.Add(words[i]);
        }

        string strOut = "";
        foreach (string item in list)
        {
            strOut += item + " ";
        }
        return strOut;
    }

    /// <summary>
    /// б) Удаляет из сообщения все слова, которые заканчиваются на заданный символ
    /// </summary>
    /// <param name="str">Входная строка</param>
    /// <param name="sym">Искомый символ</param>
    public static string DeleteWord(string str, char sym)
    {
        string[] words = SeparationString(str);
        var list = new List<string>();
        string pattern = $@"\w *[{sym}]\b";
        Regex regex = new Regex(pattern);
        for (int i = 0; i < words.Length; ++i)
        {
            if (!regex.IsMatch(words[i])) list.Add(words[i]);
        }

        string strOut = "";
        foreach (string item in list)
        {
            strOut += item + " ";
        }
        return strOut;
    }

    //в) Найти самое длинное слово сообщения.
    /// <summary>
    /// Поиск самого длинного слова в строке
    /// </summary>
    public static string LongWord(string str)
    {
        string[] words = SeparationString(str);
        int maxLength = 0;
        string maxWord = "";
        foreach (string w in words)
        {
            if (w.Length >= maxLength)
            {
                maxLength = w.Length;
                maxWord = w;
            }
        }
        return maxWord;
    }

    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    /// <summary>
    /// Формирование строки из самых длинных слов
    /// </summary>
    /// <param name="str">Входная строка</param>
    /// <returns>Строка</returns>
    public static string stringFromLongWord(string str)
    {
        StringBuilder sb = new StringBuilder();
        string[] words = SeparationString(str);
        int maxLength = 0;
        foreach (string w in words)
            maxLength = w.Length >= maxLength ? w.Length : maxLength;

        foreach (string w in words)
            if (w.Length == maxLength)
                sb.Append(w + ", ");

        return sb.ToString();
    }

    /* д) *** Создать метод, который производит частотный анализ текста.
    //В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
    //Здесь требуется использовать класс Dictionary.
    */
    /// <summary>
    /// Частотный анализ текста
    /// </summary>
    /// <param name="words">Массив искомых слов</param>
    /// <param name="text">Проверяемый текст</param>
    /// <returns>Пары слово - количество</returns>
    public static string WordFrequency(string[] words, string text)
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        string[] wordsText = SeparationString(text);

        foreach (string w in words)
            wordCount.Add(w, 0);
        foreach (string w in wordsText)
            if (wordCount.ContainsKey(w))
                ++wordCount[w];

        string outText = "";
        foreach (var item in wordCount)
            outText += item.Key + " - " + item.Value + " | ";
        return outText;
    }

    /// <summary>
    /// Конвертация строки в массив строк
    /// </summary>
    /// <param name="str">Входная строка</param>
    /// <returns>Массив строк</returns>
    private static string[] SeparationString(string str)
    {
        char[] div = { ' ' };
        string[] word = str.Split(div);
        return word;
    }


    //3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
    /// <summary>
    /// Проверка на перестановку символов
    /// </summary>
    /// <param name="text1">первая строка</param>
    /// <param name="text2">вторая строка</param>
    /// <returns>true или false</returns>
    public static bool IsReverse(string text1, string text2)
    {
        bool check = false;
        if (text1 == null || text2 == null) return check;
        else if ((text1.Length != text2.Length) || (text1 != text2))
        {
            // переводим первую строку в массив символов и загоняем их в словарь с подсчетом количества
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in text1.ToCharArray())
                if (charCount.ContainsKey(c))
                    ++charCount[c];
                else
                    charCount.Add(c, 1);

            // перебираем символы второй строки и уменьшаем их количество в словаре
            foreach (char c2 in text2.ToCharArray())
                if (charCount.ContainsKey(c2))
                    --charCount[c2];
                else
                {
                    return check;
                }
            // если в словаре все ключи = 0, значит строки являются перестановками
            foreach (int i in charCount.Values)
                if (i == 0)
                    check = true;
                else
                {
                    return check;
                }
            return check;
        }
        else
            return check;

    }
}

