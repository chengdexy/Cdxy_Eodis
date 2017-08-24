/****************************************************************************
*Copyright (c) 2017 Microsoft All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：MS-20170222UVAK
*公司名称：Microsoft
*命名空间：Cdxy_Eodis.Models
*文件名：  User
*版本号：  V1.0.0.0
*唯一标识：dea38af1-fd2c-4870-b00e-155b02826661
*当前的用户域：MS-20170222UVAK
*创建人：  Administrator
*电子邮箱：1534688571@qq.com
*创建时间：2017/8/24 上午 8:41:55

*描述：
*   User类, 表示一般用户
*
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cdxy_Eodis.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Uid { get; set; }
        public string Pwd { get; set; }
    }
}