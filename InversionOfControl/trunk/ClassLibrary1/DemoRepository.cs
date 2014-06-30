using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepository
{
    public class ClassRepo : IClassRepo
    {
        public int add(int a, int b)
        {
            return a + b;
        }
    }
    public interface IClassRepo
    {
        int add(int a, int b);
    }
}
