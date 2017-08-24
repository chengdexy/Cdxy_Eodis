/****************************************************************************
*Copyright (c) 2017 Microsoft All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：MS-20170222UVAK
*公司名称：Microsoft
*命名空间：Cdxy_Eodis.Helpers
*文件名：  DbHelper
*版本号：  V1.0.0.0
*唯一标识：9ed77dd8-3cf4-46a9-8b48-ba3399de39cb
*当前的用户域：MS-20170222UVAK
*创建人：  Administrator
*电子邮箱：1534688571@qq.com
*创建时间：2017/8/24 上午 10:06:05

*描述：
*
*=====================================================================
*修改标记
*修改时间：2017/8/24 上午 10:06:05
*修改人： Administrator
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/

using Cdxy_Eodis.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cdxy_Eodis.Helpers
{
    public static class DbHelper
    {
        private static MainContext _db = new MainContext();

        internal static bool CheckUidPwd(string uid, string pwd)
        {
            if (_db.Users.Where(u => u.Uid == uid && u.Pwd == pwd).Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}