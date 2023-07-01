using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Arrange, Act, Assert
//expectd and actual
namespace TestProjectCalulator
{
    public class CalculatorTests
    {

       
        public class TestsForCalculator
        {
            [Fact]
            public void Add_WhenCalled_ReturnsSumOfTwoNumbers()
            {
                //int actual = 0;
                //int expected = 0;
                // Arrange
                Calculator calculator = new Calculator();

                // Act
                int result = calculator.Add(2, 3);

                // Assert
                Assert.Equal(5, result);
            }

            [Fact]
            public void Subtract_WhenCalled_ReturnsDifferenceOfTwoNumbers()
            {
                // Arrange
                Calculator calculator = new Calculator();

                // Act
                int result = calculator.Subtract(5, 3);

                // Assert
                Assert.Equal(2, result);
            }

            [Fact]
            public void Divide_WhenCalled_ReturnsDivisionOfTwoNumbers()
            {
                // Arrange
                Calculator calculator = new Calculator();

                // Act
                float result = calculator.Divide(4, 2);

                // Assert
                Assert.Equal(2, result);
            }


            [Fact]
            public void Multiply_WhenCalled_ReturnsMultiplicationOfTwoNumbers()
            {
                // Arrange
                Calculator calculator = new Calculator();

                // Act
                double result = calculator.Multiply(4, 2);

                // Assert
                Assert.Equal(8, result);
            }
        }
    }
}
