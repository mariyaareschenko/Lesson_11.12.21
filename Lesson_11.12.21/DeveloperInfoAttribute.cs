using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11._12._21
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct, AllowMultiple =true )]
    
    class DeveloperInfoAttribute : System.Attribute
    {
        private string developer_name;
        private string date_created;
        public DeveloperInfoAttribute(string developer_name)
        {
            this.developer_name = developer_name;
        }
        public string Developer { get { return developer_name; } }
        public string Date { get { return date_created; } set { date_created = value; } }
    }
}
