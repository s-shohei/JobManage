//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobManage.DatabaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_TASK_DETAIL
    {
        public long SEQ { get; set; }
        public long REGION_ID { get; set; }
        public long PROKECT_ID { get; set; }
        public long TASK_ID { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }
        public string TASK_TIME { get; set; }
        public string REMARKS { get; set; }
        public Nullable<long> DEL_FLG { get; set; }
    }
}
