using NewLabTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class DB
    {
        public static triangleEntities dB = new triangleEntities();
        public static triangleInfo SearchInfo(string f, string s, string t)
        {
            return dB.triangleInfo.FirstOrDefault(u => u.first == f && u.second == s && u.third == t);
        }

        public static triangleInfo AddInfo(string f, string s, string t)
        {
            var triangle = Triangle.GoTriangle(f, s, t);
            triangleInfo tr = new triangleInfo();
            tr.first = f;
            tr.second = s;
            tr.third = t;
            tr.type = triangle.Item1;
            tr.exception = triangle.Item5;
            dB.triangleInfo.Add(tr);
            dB.SaveChanges();

            return tr;
        }

        public static void DeleteInfo(string f, string s, string t)
        {
            triangleInfo triangle = dB.triangleInfo.FirstOrDefault(u => u.first == f && u.second == s && u.third == t);
            dB.triangleInfo.Remove(triangle);
            dB.SaveChanges();
        }
    }                             
}
