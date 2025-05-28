using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Пример использования функций
    }

    // 1. Удалить часть текста в скобках
    static string RemoveTextInBrackets(string input)
    {
        return Regex.Replace(input, @"\s*$$$.*?$$$", "");
    }

    // 2. Подсчитать вхождения слова
    static int CountWordOccurrences(string input, string word)
    {
        return input.Split(' ').Count(w => w.Equals(word, StringComparison.OrdinalIgnoreCase));
    }

    // 3. Вставить запятую между словами
    static string InsertCommaBetweenWords(string input)
    {
        return string.Join(", ", input.Split(' '));
    }

    // 4. Определить процент слов на букву К
    static double CalculatePercentageK(string input)
    {
        var words = input.Split(' ');
        int totalWords = words.Length;
        int kWords = words.Count(w => w.StartsWith("К", StringComparison.OrdinalIgnoreCase));
        return (double)kWords / totalWords * 100;
    }

    // 5. Исключить цифры
    static string RemoveDigits(string input)
    {
        return new string(input.Where(c => !char.IsDigit(c)).ToArray());
    }

    // 6. Проверить наличие недопустимых символов
    static bool ContainsInvalidCharacters(string input)
    {
        return input.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c));
    }

    // 7. Удалить буквы с кодами от 70 до 75
    static string RemoveLettersByAscii(string input)
    {
        return new string(input.Where(c => !(c >= 70 && c <= 75)).ToArray());
    }

    // 8. Проверить два подряд "4"
    static bool ContainsConsecutiveFours(string input)
    {
        return input.Contains("44");
    }

    // 9. Пробел после каждой цифры
    static string AddSpaceAfterDigits(string input)
    {
        return Regex.Replace(input, @"(\d)", "$1 ");
    }

    // 10. Увеличить цифры на 1
    static string IncrementDigits(string input)
    {
        return new string(input.Select(c => char.IsDigit(c) ? (char)((c - '0' + 1) % 10 + '0') : c).ToArray());
    }

    // 11. Сначала цифры, потом буквы
    static string SeparateDigitsAndLetters(string input)
    {
        var digits = new string(input.Where(char.IsDigit).ToArray());
        var letters = new string(input.Where(char.IsLetter).ToArray());
        return digits + letters;
    }

    // 12. Преобразовать маленькие буквы в большие
    static string ConvertToUppercase(string input)
    {
        return input.ToUpper();
    }

    // 13. Зашифровать слово смещением
    static string EncryptWord(string input)
    {
        return new string(input.Select(c => (char)(c + 1)).ToArray());
    }

    // 14. Цифры по 5 в строке
    static string FormatDigitsInGroups(string input)
    {
        return string.Join(Environment.NewLine, Enumerable.Range(0, (input.Length + 5 - 1) / 5)
            .Select(i => input.Substring(i * 5, Math.Min(5, input.Length - i * 5))));
    }

    // 15. Увеличить ASCII-коды букв на 3
    static string IncrementAsciiCodes(string input)
    {
        return new string(input.Select(c => (char)(c + 3)).ToArray());
    }

    // 16. Сумма цифр, кратных 3
    static int SumOfDigitsDivisibleBy3(string input)
    {
        return input.Where(char.IsDigit).Select(c => c - '0').Where(num => num % 3 == 0).Sum();
    }

    // 17. Сумма цифр в строках
    static int SumOfDigits(string input)
    {
        return input.Where(char.IsDigit).Select(c => c - '0').Sum();
    }

    // 18. Количество символов с ASCII >= 70
    static int CountCharactersWithAsciiAbove70(string input)
    {
        return input.Count(c => c >= 70);
    }

    // 19. Добавить символы справа
    static string AddCharactersToString(string input, string characters, int count)
    {
        return input + new string(characters.Take(count).ToArray());
    }

    // 20. Убрать пробелы
    static string RemoveSpaces(string input)
    {
        return input.Replace(" ", "");
    }

    // 21. Записать в зеркальном отображении
    static string ReverseString(string input)
    {
        return new string(input.Reverse().ToArray());
    }

    // 22. Разбить текст на строки по k символов
    static List<string> SplitIntoLines(string input, int k)
    {
        return Enumerable.Range(0, (input.Length + k - 1) / k)
                         .Select(i => input.Substring(i * k, Math.Min(k, input.Length - i * k)))
                         .ToList();
    }

    // 23. Вставить пробелы через каждые n символов
    static string InsertSpaces(string input, int n)
    {
        return string.Join(" ", Enumerable.Range(0, (input.Length + n - 1) / n)
                          .Select(i => input.Substring(i * n, Math.Min(n, input.Length - i * n))));
    }

    // 24. Заменить слово А1 на А2
    static string ReplaceWord(string input, string A1, string A2)
    {
        return input.Replace(A1, A2);
    }

    // 25. Заменить один символ другим
    static string ReplaceCharacter(string input, char oldChar, char newChar)
    {
        return input.Replace(oldChar, newChar);
    }

    // 26. Убрать лишние пробелы
    static string RemoveExtraSpaces(string input)
    {
        return Regex.Replace(input, @"\s+", " ").Trim();
    }

    // 27. Заменить буквы "с" на "о" в строках
    static string ReplaceCharacterInString(string input)
    {
        return input.Replace("с", "о");
    }

    // 28. Символ ‘!’ после каждой цифры
    static string AddExclamationAfterDigits(string input)
    {
        return Regex.Replace(input, @"(\d)", "$1!");
    }

    // 29. Заменить пробелы на "_"
    static string ReplaceSpacesWithUnderscore(string input)
    {
        return input.Replace(" ", "_");
    }

    // 30. Удалить буквы «р» и «с»
    static string RemoveCharacters(string input)
    {
        return input.Replace("р", "").Replace("с", "");
    }
}