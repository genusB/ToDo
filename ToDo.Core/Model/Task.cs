using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Core.Model
{
    public class Task
    {
        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }
        [MaxLength(60)]
        public string Title { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        public DateTime DeadlineTime { get; set; }
        public Color Color { get; set; }
        public bool IsCompleted { get; set; }
        public List<Tuple<string, bool>> SubtasksList;
    }
}
