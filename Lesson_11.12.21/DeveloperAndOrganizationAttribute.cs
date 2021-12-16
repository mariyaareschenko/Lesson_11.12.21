using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson_11._12._21
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct, AllowMultiple = true)]
    class DeveloperAndOrganizationAttribute : System.Attribute
    {
        private string developer_name;
        private string organization_name;
        public string Developer { get { return developer_name; } }
        public string Organization { get { return organization_name; } set { organization_name = value; } }
        public DeveloperAndOrganizationAttribute(string developer_name)
        {
            this.developer_name = developer_name;
        }
    }
}
