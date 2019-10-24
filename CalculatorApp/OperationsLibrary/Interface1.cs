using System;
using System.Collections.Generic;
using System.Text;

namespace OperationsLibrary
{
    
    public interface IOperations
    {
        /// <summary>
        /// It adds
        /// </summary>
        /// <param name="value1">A double value</param>
        /// <param name="value2"></param>
        /// <returns></returns>
        double Add(double value1, double value2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        double Sub(double value1, double value2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        double Multiply(double value1, double value2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        double Div(double value1, double value2);

    }
}
