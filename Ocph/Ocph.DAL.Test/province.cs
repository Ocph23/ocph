using System;
using System.Collections.Generic;
using System.Text;

namespace Ocph.DAL.Test
{
    [TableName("provinces")]
    public class province
    {
        [PrimaryKey("Id")]
        [DbColumn("Id")]
        public int Id { get; set; }

        [DbColumn("province")]
        public string Province { get; set; }
    }
}
