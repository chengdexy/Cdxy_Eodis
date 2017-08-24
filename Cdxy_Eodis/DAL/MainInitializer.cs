/****************************************************************************
*Copyright (c) 2017 Microsoft All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：MS-20170222UVAK
*公司名称：Microsoft
*命名空间：Cdxy_Eodis.DAL
*文件名：  MainInitializer
*版本号：  V1.0.0.0
*唯一标识：f25ece79-8537-412b-9fe0-7a2c81922ed9
*当前的用户域：MS-20170222UVAK
*创建人：  Administrator
*电子邮箱：1534688571@qq.com
*创建时间：2017/8/24 下午 3:01:07

*描述：
*
*=====================================================================
*修改标记
*修改时间：2017/8/24 下午 3:01:07
*修改人： Administrator
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/

using Cdxy_Eodis.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cdxy_Eodis.DAL
{
    public class MainInitializer : DropCreateDatabaseIfModelChanges<MainContext>
    {
        protected override void Seed(MainContext context)
        {
            var admins = new List<Admin>
            {
                new Admin
                {
                    Uid="admin",
                    Pwd="admin"
                },

                new Admin
                {
                    Uid="chengdexy",
                    Pwd="darkmoon1"
                }
            };
            admins.ForEach(a => context.Admins.Add(a));
            context.SaveChanges();

            var users = new List<User>
            {
                new User
                {
                    Uid="user1",
                    Pwd="user1"
                },

                new User
                {
                    Uid="user2",
                    Pwd="user2"
                }
            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}