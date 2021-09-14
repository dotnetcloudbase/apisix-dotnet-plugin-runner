using ApiSix.Plugin.Runner.Sdk.A6;
using FlatSharp;
using FlatSharp.Attributes;
using System.Collections.Generic;

namespace ApiSix.Plugin.Runner.Sdk.HTTPReqCall
{
    [FlatBufferTable()]
    public  class Req
    {
        [FlatBufferItem(0)]
        public virtual uint Id { get; set; }

        [FlatBufferItem(1)]
        public virtual IList<byte> Src_ip { get; set; }

        [FlatBufferItem(2)]
        public virtual Method Method { get; set; }

        [FlatBufferItem(3)]
        public virtual string Path { get; set; }

        [FlatBufferItem(4)]
        public virtual IList<TextEntry> Args { get; set; }

        [FlatBufferItem(5)]
        public virtual IList<TextEntry> Headers { get; set; }

        [FlatBufferItem(6)]
        public virtual uint Conf_token { get; set; }

    }

}
