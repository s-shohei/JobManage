﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JobManageEntities : DbContext
    {
        public JobManageEntities()
            : base("name=JobManageEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<M_USER> M_USER { get; set; }
    }
}
