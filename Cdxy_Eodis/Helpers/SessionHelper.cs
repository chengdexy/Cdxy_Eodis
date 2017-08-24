/****************************************************************************
*Copyright (c) 2017 Microsoft All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：MS-20170222UVAK
*公司名称：Microsoft
*命名空间：Cdxy_Eodis.Helpers
*文件名：  SessionHelper
*版本号：  V1.0.0.0
*唯一标识：46d1368b-7d06-453a-8b13-16ed3656e95a
*当前的用户域：MS-20170222UVAK
*创建人：  Administrator
*电子邮箱：1534688571@qq.com
*创建时间：2017/8/24 上午 9:44:12

*描述：
*
*=====================================================================
*修改标记
*修改时间：2017/8/24 上午 9:44:12
*修改人： Administrator
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cdxy_Eodis.Helpers
{
    public static class SessionHelper
    {
        public static bool UserHasLogged(HttpSessionStateBase s)
        {
            bool result = Convert.ToBoolean(s["UserLoggedIn"]);
            return result;
        }
    }
}