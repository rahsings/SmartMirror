using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SmartMirror.Dataaccess.Entries.Traffic;

namespace SmartMirror.Dataaccess.Repository
{
    public interface ITrafficRepository
    {
        Task<Traffic_Entity> _getTrafficEntityAsync(string source, string destination);
    }
}
