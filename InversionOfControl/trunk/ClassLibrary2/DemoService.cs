using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoRepository;

namespace DemoService
{
    public class ClassSer : IClassSer
    {
        private IClassRepo _iclassrepo;

        public ClassSer(IClassRepo iclassrepo)
        {
            _iclassrepo = iclassrepo;
        }

        public int add(int a, int b)
        {
            return this._iclassrepo.add(a, b);
        }
    }

    public interface IClassSer
    {
        int add(int a, int b);
    }
}
