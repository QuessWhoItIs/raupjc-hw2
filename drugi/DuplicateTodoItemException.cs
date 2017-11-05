using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugi
{
    public class DuplicateTodoItemException : Exception
    {
        public DuplicateTodoItemException(Guid id)
            : base($"duplicate id: {id}")
        {
        }
    }
}
