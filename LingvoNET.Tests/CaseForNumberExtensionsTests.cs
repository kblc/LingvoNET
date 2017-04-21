using System;
using Xunit;

namespace LingvoNET.Tests
{
    public class CaseForNumberExtensionsTests
    {
        [Theory, MemberData(nameof(SourceData))]
        public void ValidCaseAndNumberForSourceValue(int sourceNumber, Tuple<Case,Number> expected)
        {
            //Act
            var @case = sourceNumber.GetCase();

            //Assert
            Assert.Equal(expected, @case);
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public static object[] SourceData =
        {
            new object[] { 1, new Tuple<Case, Number>(Case.Nominative, Number.Singular) },
            new object[] { 2, new Tuple<Case, Number>(Case.Genitive, Number.Singular) },
            new object[] { 3, new Tuple<Case, Number>(Case.Genitive, Number.Singular) },
            new object[] { 4, new Tuple<Case, Number>(Case.Genitive, Number.Singular) },
            new object[] { 5, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 6, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 7, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 8, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 9, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 0, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 10, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 11, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 12, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 13, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 14, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 15, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 16, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 17, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 18, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 19, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 20, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 101, new Tuple<Case, Number>(Case.Nominative, Number.Singular) },
            new object[] { 102, new Tuple<Case, Number>(Case.Genitive, Number.Singular) },
            new object[] { 103, new Tuple<Case, Number>(Case.Genitive, Number.Singular) },
            new object[] { 104, new Tuple<Case, Number>(Case.Genitive, Number.Singular) },
            new object[] { 105, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 106, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 107, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 108, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 109, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 100, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 1011, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 1012, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 1013, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
            new object[] { 1014, new Tuple<Case, Number>(Case.Genitive, Number.Plural) },
        };
    }
}
