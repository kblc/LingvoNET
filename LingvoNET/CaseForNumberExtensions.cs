using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LingvoNET
{
    /// <summary>
    /// Расширение для поиска падежа по числу
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static class CaseForNumberExtensions
    {
        /// <summary>
        /// Получить Падеж и Число для склонения в соответствии с числом
        /// </summary>
        /// <param name="sourceValue">Число</param>
        /// <returns>Падеж и Число для него</returns>
        public static Tuple<Case,Number> GetCase(this int sourceValue)
        {
            var value = Math.Abs(sourceValue);

            if (value > 10)
            {
                var lastNumbers = int.Parse(new string(sourceValue.ToString().Reverse().Take(2).Reverse().ToArray()));
                if (lastNumbers >= 11 && lastNumbers <= 14)
                    return new Tuple<Case, Number>(Case.Genitive, Number.Plural);
            }

            var lastNumber = int.Parse(sourceValue.ToString().Last().ToString());
            switch (lastNumber)
            {
                case 1:
                    return new Tuple<Case, Number>(Case.Nominative, Number.Singular);
                case 2:
                case 3:
                case 4:
                    return new Tuple<Case, Number>(Case.Genitive, Number.Singular);
                default:
                    return new Tuple<Case, Number>(Case.Genitive, Number.Plural);
            }
        }
    }
}
