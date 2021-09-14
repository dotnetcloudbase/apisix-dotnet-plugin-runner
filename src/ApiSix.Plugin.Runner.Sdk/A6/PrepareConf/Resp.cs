using FlatSharp;
using FlatSharp.Attributes;

namespace ApiSix.Plugin.Runner.Sdk.A6.PrepareConf
{
    [FlatBufferTable()]
    public partial class Resp
    {
        [FlatBufferItem(0)]
        public virtual uint Conf_token { get; set; }
    }
}
