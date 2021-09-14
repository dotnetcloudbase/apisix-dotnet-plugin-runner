using FlatSharp.Attributes;

namespace ApiSix.Plugin.Runner.Sdk.A6.ExtraInfo
{
    [FlatBufferTable()]
    public class Req
    {
        [FlatBufferItem(0)]
        public virtual Info Info { get; set; }

    }
}
