using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSub.Model
{
    public class Repository
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public List<SubModule> SubModules { get; set; }
    }
}
