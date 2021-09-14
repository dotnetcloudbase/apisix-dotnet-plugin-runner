using FlatSharp;
using FlatSharp.Attributes;

namespace ApiSix.Plugin.Runner.Sdk.A6.ExtraInfo
{
    [FlatBufferTable()]
    public  class Var
    {
        [FlatBufferItem(0)]
        public virtual string Name { get; set; }
    }
}
