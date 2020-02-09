using System;
using Xunit;
// if you are in the namespace you don't need using
namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]  // a piece of fact, xunit looks for these, a decorator
        public void BookCalculatesAnAverageGrade()
        {
            // 3 sections
            // arrange section
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);          

            // act section
            var result = book.GetStatistics();

            // assert section, triple "A"
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }
    }
}
