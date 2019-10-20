using System;
using System.Collections.Generic;
using System.Text;

namespace ex_average
{
    public class Average<T>
    {
        private List<T> data;

        public Average()
        {
            data = new List<T>();
        }

        public void add(T value)
        {
            if (typeof(T).Name == "String")
                throw new System.ArgumentException("Parameter must be a numeric");

            data.Add(value);
        }

        public void reset()
        {
            data.Clear();
        }

        public T calculate()
        {
            if(typeof(T).Name == "String")
                throw new System.Exception("Return type must be a numeric");
            

            dynamic result = 0;

            foreach(dynamic item in data)
            {
                result = result + item;
            }
            result = result / data.Count;

            return result;
        }
    }
}
