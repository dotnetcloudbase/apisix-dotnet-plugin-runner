using FlatSharp;
using FlatSharp.Attributes;
using System.Collections.Generic;

namespace ApiSix.Plugin.Runner.Sdk.A6.HTTPReqCall
{
    [FlatBufferTable()]
    public class Rewrite
    {
        [FlatBufferItem(0)]
        public virtual string Path { get; set; }

        [FlatBufferItem(1)]
        public virtual IList<TextEntry> Headers { get; set; }

        [FlatBufferItemAttribute(2)]
        public virtual IList<TextEntry> Args { get; set; }

    }

}
