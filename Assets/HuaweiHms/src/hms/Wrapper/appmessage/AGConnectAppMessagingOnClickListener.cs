using UnityEngine;
using System.Collections.Generic;

namespace HuaweiHms
{
    public class AGConnectAppMessagingOnClickListenerData : IHmsBaseListener
    {
        public string name => "com.huawei.agconnect.appmessaging.AGConnectAppMessagingOnClickListener";
        public string buildName => "";
    }
    public class AGConnectAppMessagingOnClickListener : HmsListener<AGConnectAppMessagingOnClickListenerData>
    {
    
        public virtual void onMessageClick(AppMessage arg0) { }
    
        public void onMessageClick(AndroidJavaObject arg0){
            onMessageClick(HmsUtil.GetHmsBase<AppMessage>(arg0));
        }
    }
}