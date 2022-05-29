using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ExtensionMethods
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public TableAttribute (string name)
        {
            TableName = name;
        }

        public readonly string TableName;
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public ColumnAttribute (int id, ColumnDomain dataType, bool required)
        {
            ColumnId = id;
            DataType = dataType;

        }

        public readonly int ColumnId;
        public readonly ColumnDomain DataType;
        public bool Required;

        public enum ColumnDomain
        {
            Integer,
            Long,
            DateTime
        }
    }


}
