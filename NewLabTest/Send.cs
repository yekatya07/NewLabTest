using NewLabTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface ISend
    {
        void SendInfo(triangleInfo triangle);
    }
    public class Send : ISend
    {
        public void SendInfo(triangleInfo triangle)
        {
            Console.WriteLine($"Отправка данных: {triangle.first} {triangle.second} {triangle.third} {triangle.type}");
        }
    }
}
