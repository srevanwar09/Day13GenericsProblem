
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFindMaximum
    {
        public class GenericsMaximum<T> where T : IComparable
        {
            public T[] value;
            public GenericsMaximum(T[] value)//this constructor is used to initialize the value 
            {
                this.value = value;
            }
            public T[] Sort(T[] values)//this method is used to sort the values array
            {
                Array.Sort(values);
                return values;
            }
            public T MaxValue(params T[] values) // this method used to find the maximum value
            {
                var sorted_values = Sort(values);
                return sorted_values[sorted_values.Length - 1];
            }
            public void PrintMaxValue()// this method is used to print the maximum value received from MaxValue method
            {
                var max = MaxValue(this.value);
                Console.WriteLine("Maximum value is " + max);
            }
        }
    }
