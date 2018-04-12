using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionDatabase.Domain.Models;

namespace ConnectionDatabase.Domain.Services
{
    public interface IConnectionTestService
    {
        string LastErrorSbo { get; set; }

        bool IsConnectedDatabase(Settings settings);

        bool IsConnectedSbo(Settings settings);
    }
}
