using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9._4
{
    public class PhotoBook
    {
        protected int _numPages;

        public PhotoBook(int numPages)
        {
            _numPages=numPages;
        }

        public int GetNumberPages()
        {
            return _numPages;
        }

        public PhotoBook()
        {
            _numPages=16;
        }
          
    }
}
