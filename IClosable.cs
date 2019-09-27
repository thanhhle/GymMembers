using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMembers
{
    /// <summary>
    /// An interface that lets objects be closed.
    /// </summary>
    public interface IClosable
    {
        /// <summary>
        /// Closes this object.
        /// </summary>
        void Close();
    }
}
