/****************************************************************************
*Copyright (c) 2017 Microsoft All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：MS-20170222UVAK
*公司名称：Microsoft
*命名空间：Cdxy_Eodis.DAL
*文件名：  MainContext
*版本号：  V1.0.0.0
*唯一标识：a5efb584-30fe-4db7-a8c5-c41a272a1200
*当前的用户域：MS-20170222UVAK
*创建人：  Administrator
*电子邮箱：1534688571@qq.com
*创建时间：2017/8/24 下午 2:51:47

*描述：
*
*=====================================================================
*修改标记
*修改时间：2017/8/24 下午 2:51:47
*修改人： Administrator
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/

using Cdxy_Eodis.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Cdxy_Eodis.DAL
{
    public class MainContext : DbContext
    {
        public MainContext() : base("MainContext")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}