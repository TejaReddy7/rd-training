using System;

namespace OperationsLibrary
{
    #region OperationsClass

    /// <summary>
    /// The main Operations class.
    /// <para>Contains all methods for performing basic math operations.</para>
    /// </summary>
    /// <remarks>
    /// <para>This class can add, subtract, multiply and divide.</para>
    /// <para>These operations can be performed on doubles.</para>
    /// </remarks>
    public class Operations : IOperations
    {
        #region Addition

        /// <summary>
        /// Adds two numbers and returns the result.
        /// <para>See <see cref="Operations.Add(double, double)"/> to add doubles.</para>
        /// </summary>
        /// <returns>
        /// The sum of two integers.
        /// </returns>
        /// <example>
        /// <code>
        /// double c = Operations.Add(4, 5);
        /// if (c > 10)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>
        /// <param name="value1">A double precision number.</param>
        /// <param name="value2">A double precision number.</param>
        public double Add(double value1, double value2)
        {
            double result = value1 + value2;
            return result;
        }

        #endregion

        #region Subtraction

        /// <summary>
        /// Subtracts two numbers and returns the result.
        /// <para>See <see cref="Operations.Sub(double, double)"/> to add doubles.</para>
        /// </summary>
        /// <returns>
        /// The subtraction of two integers.
        /// </returns>
        /// <param name="value1">A double precision number</param>
        /// <param name="value2">A double precision number</param>
        public double Sub(double value1, double value2)
        {
            double result = value1 - value2;
            return result;
        }

        #endregion

        #region Multiplication

        /// <summary>
        /// Multiplies two numbers and returns the result.
        /// <para>See <see cref="Operations.Add(double, double)"/> to add doubles.</para>
        /// </summary>
        /// <returns>
        /// The multiplication of two integers.
        /// </returns>
        public double Multiply(double value1, double value2)
        {
            double result = 0;


            result = value1 * value2;
            if (result > double.MaxValue)
            {
                throw new OverflowException("Overflow Exception raised.");
            }

            return result;

        }

        #endregion

        #region Division

        /// <summary>
        /// Divides two numbers and returns the result.
        /// <para>See <see cref="Operations.Add(double, double)"/> to add doubles.</para>
        /// </summary>
        /// <returns>
        /// The Division of two integers.
        /// </returns>
        public double Div(double value1, double value2)
        {
            double result = 0;

            result = value1 / value2;

            if (result.Equals(Double.PositiveInfinity))
                throw new DivideByZeroException("Divide By Zero Error raised. ");

            return result;
        }

        #endregion
    }


    #endregion

    #region Extensions

    /// <summary>
    /// The is Extensions class.
    /// <para>Contains a method for converting double to float.</para>
    /// </summary>
    /// <returns>
    /// converts double to float
    /// </returns>
    public static class Extensions
    {
        /// <summary>
        /// The is DoubleToFloat Method.
        /// <para>Converts a double to float.</para>
        /// </summary>
        /// <returns>
        /// converts double to float
        /// </returns>
        public static float DoubleToFloat(this Double d, double f)
        {
            return (float)f;
        }

    }

    #endregion
}
