using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRentCarWrapper
    {
        IUserRepository User { get; }
        ICarsRepository Cars { get; }
        IRentsRepository Rents { get; }
    }
}
