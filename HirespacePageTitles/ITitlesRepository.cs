using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HirespacePageTitles
{
    public interface ITitlesRepository
    {
        IList<Page> Pages { get; set; }
    }
}
