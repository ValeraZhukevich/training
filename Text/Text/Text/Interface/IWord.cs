using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public interface IWord
    {
        string Content { get; }
        char FirstLetter { get; }
    }
}
