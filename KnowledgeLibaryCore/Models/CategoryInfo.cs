using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeLibraryCore.Models
{
    /// <summary>
    /// 分类
    /// </summary>
    public class CategoryInfo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Comment { get; set; }

        public int? SeqNo { get; set; }

        public int CreateId { get; set; }

        public long CreateTime { get; set; }

        public int UpdateId { get; set; }

        public long UpdateTime { get; set; }

        public int Level { get; set; }
    }
}
