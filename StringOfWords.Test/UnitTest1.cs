using FluentAssertions;

namespace StringOfWords.Test
{
    public class Tests
    {
        private StringOfWords stringOfWords;

        [SetUp]
        public void Setup()
        {
            stringOfWords = new();
        }

        [Test]
        public void given_a_string_of_two_words_shoud_return_array_with_two_rows()
        {
            stringOfWords.readString("good morning").Length.Should().Be(2);
        }
        [Test]
        public void given_a_string_good_morning_shoud_return_array_sorted_by_last_letter()
        {
            stringOfWords.readString("good morning")[0].Should().Be("good");
            stringOfWords.readString("good morning")[1].Should().Be("morning");
        }

        [Test]
        public void given_a_string_roman_numeral_shoud_return_array_sorted_by_last_letter()
        {
            stringOfWords.readString("roman numeral")[0].Should().Be("numeral");
            stringOfWords.readString("roman numeral")[1].Should().Be("roman");
        }

        [Test]
        public void given_a_string_shoud_return_array_sorted_by_last_letter()
        {
            stringOfWords.readString("good morning to everybady enjoy your day")[0].Should().Be("good");
            stringOfWords.readString("good morning to everybady enjoy your day")[1].Should().Be("morning");
            stringOfWords.readString("good morning to everybady enjoy your day")[2].Should().Be("to");
            stringOfWords.readString("good morning to everybady enjoy your day")[3].Should().Be("your");
            stringOfWords.readString("good morning to everybady enjoy your day")[4].Should().Be("everybady");
            stringOfWords.readString("good morning to everybady enjoy your day")[5].Should().Be("enjoy");
            stringOfWords.readString("good morning to everybady enjoy your day")[6].Should().Be("day");
        }
    }
}