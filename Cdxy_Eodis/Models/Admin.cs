/****************************************************************************
*Copyright (c) 2017 Microsoft All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：MS-20170222UVAK
*公司名称：Microsoft
*命名空间：Cdxy_Eodis.Models
*文件名：  Admin
*版本号：  V1.0.0.0
*唯一标识：bbe60305-4d91-4990-9dfd-531dab1020c2
*当前的用户域：MS-20170222UVAK
*创建人：  Administrator
*电子邮箱：1534688571@qq.com
*创建时间：2017/8/24 下午 2:58:42

*描述：
*
*=====================================================================
*修改标记
*修改时间：2017/8/24 下午 2:58:42
*修改人： Administrator
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cdxy_Eodis.Models
{
    public class Admin
    {
        public int ID { get; set; }
        public string Uid { get; set; }
        public string Pwd { get; set; }

    }
}