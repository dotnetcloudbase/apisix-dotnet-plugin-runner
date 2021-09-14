using FlatSharp;
using FlatSharp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSix.Plugin.Runner.Sdk.ExtraInfo
{
    [FlatBufferTable()]
    public partial class Resp
     : object
    {
        public Resp()
        {
            checked
            {
                this.OnInitialized(null);
            }
        }

#pragma warning disable CS8618
        protected Resp(FlatBufferDeserializationContext context)
        {
            checked
            {
            }
        }

#pragma warning restore CS8618
        public Resp(Resp source)
        {
            checked
            {
                this.OnInitialized(null);
            }
        }

        partial void OnInitialized(FlatBufferDeserializationContext? context);

        protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext? context) => this.OnInitialized(context);

        [FlatBufferItem(0)]
        public virtual IList<System.Byte> result { get; set; }

    }
}