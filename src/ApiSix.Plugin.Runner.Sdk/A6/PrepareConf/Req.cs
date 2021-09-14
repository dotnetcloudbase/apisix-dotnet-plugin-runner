using FlatSharp;
using FlatSharp.Attributes;
using System.Collections.Generic;

namespace ApiSix.Plugin.Runner.Sdk.A6.PrepareConf
{
    [FlatBufferTable()]
    public class Req
    {
        [FlatBufferItem(0)]
        public virtual IList<TextEntry> Conf { get; set; }

        [FlatBufferItem(1)]
        public virtual string Key { get; set; }

    }
}
