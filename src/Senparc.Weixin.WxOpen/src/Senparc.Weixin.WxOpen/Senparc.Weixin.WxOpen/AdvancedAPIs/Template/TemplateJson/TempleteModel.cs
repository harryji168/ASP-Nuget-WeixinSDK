#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2021 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2022 Senparc
    
    文件名：TemplateModel.cs
    文件功能描述：小程序模板消息接口需要的数据
    
    
    创建标识：Senparc - 20161112
    
    修改标识：Senparc - 20190906
    修改描述：v3.5.4 修正 UniformSendData 参数

    修改标识：Senparc - 20190906
    修改描述：v3.10.102 修正 UniformSendData.Mp_Template_Msg.Miniprogram  参数 pagepath -> page
                        反馈：https://weixin.senparc.com/QA-17333

----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senparc.Weixin.WxOpen.AdvancedAPIs.Template
{
    /// <summary>
    /// 模板消息Post数据
    /// </summary>
    public class TemplateModel
    {
        /// <summary>
        /// 目标用户OpenId
        /// </summary>
        public string touser { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        public string template_id { get; set; }

        /// <summary>
        /// 点击模板查看详情跳转页面，不填则模板无跳转（非必填）
        /// </summary>
        public string page { get; set; }

        /// <summary>
        /// 表单提交场景下，为 submit 事件带上的 formId；支付场景下，为本次支付的 prepay_id
        /// </summary>
        public string form_id { get; set; }


        /// <summary>
        /// 数据
        /// </summary>
        public object data { get; set; }

        /// <summary>
        /// 模板需要放大的关键词，不填则默认无放大（非必填）
        /// </summary>
        public string emphasis_keyword { get; set; }

        /// <summary>
        /// 模板内容字体的颜色，不填默认黑色（非必填）
        /// </summary>
        public string color { get; set; }



        public TemplateModel()
        {
        }
    }

    /// <summary>
    /// 下发小程序和公众号统一的服务消息
    /// </summary>
    public class UniformSendData
    {
        public string touser { get; set; }
        public Weapp_Template_Msg weapp_template_msg { get; set; }
        public Mp_Template_Msg mp_template_msg { get; set; }
    }

    public class Weapp_Template_Msg
    {
        public string template_id { get; set; }
        public string page { get; set; }
        public string form_id { get; set; }
        public object data { get; set; }
        public string emphasis_keyword { get; set; }
    }

    public class Mp_Template_Msg
    {
        public string appid { get; set; }
        public string template_id { get; set; }
        public string url { get; set; }
        public Miniprogram miniprogram { get; set; }
        public object data { get; set; }
    }

    public class Miniprogram
    {
        public string appid { get; set; }
        public string page { get; set; }
    }
}
