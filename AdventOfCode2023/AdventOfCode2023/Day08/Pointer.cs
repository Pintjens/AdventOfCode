using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    internal class Pointer
    {
        public string Id;

        public Pointer Left;

        public Pointer Right;

        public bool LastIsZ
        {
            get
            {
                return this.Id.Last() == 'Z';
            }
        }
    }
}
