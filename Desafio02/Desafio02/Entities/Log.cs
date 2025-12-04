using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02.Entities
{
    public class Log
    {
        private int _id;
        private string _logDescription;
        private DateTime _created;

        public Log(int id, string logDescription, DateTime created)
        {
            _id = id;
            _logDescription = logDescription;
            _created = created;
        }

    }
}
