using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManage.Model
{
    public class TaskDetailModel
    {
        public int No { get; set; }
        public string ProjectName { get; set; }
        public string RegionName { get; set; }
        public string AnkenName { get; set; }
        public string TaskName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string TaskTime { get; set; }
        public string Remarks { get; set; }
    }
}
