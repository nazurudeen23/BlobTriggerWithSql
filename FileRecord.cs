using System;
using System.Collections.Generic;
using System.Text;

namespace BlobWithSql.Models
{
    public class FileRecords
    {
        public Guid Id { get; set; } = System.Guid.NewGuid();
        public string FileName { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
    }
}
