using FlatSharp;
using FlatSharp.Attributes;
using System.Collections.Generic;

namespace ApiSix.Plugin.Runner.Sdk.A6.HTTPReqCall
{
    [FlatBufferTable()]
    public class Stop
    {

        [FlatBufferItem(0)]
        public virtual ushort Status { get; set; }

        [FlatBufferItem(1)]
        public virtual IList<TextEntry> Headers { get; set; }

        [FlatBufferItem(2)]
        public virtual IList<byte> Body { get; set; }

    }

}
