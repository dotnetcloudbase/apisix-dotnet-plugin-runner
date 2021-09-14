using FlatSharp;
using FlatSharp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSix.Plugin.Runner.Sdk.ExtraInfo
{
    [FlatBufferTableAttribute()]
    public partial class Req
    : object
    {
        public Req()
        {
            checked
            {
                this.OnInitialized(null);
            }
        }

#pragma warning disable CS8618
        protected Req(FlatBufferDeserializationContext context)
        {
            checked
            {
            }
        }

#pragma warning restore CS8618
        public Req(Req source)
        {
            checked
            {
                this.OnInitialized(null);
            }
        }

        partial void OnInitialized(FlatBufferDeserializationContext? context);

        protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext? context) => this.OnInitialized(context);

        [FlatBufferItemAttribute(0)]
        public virtual Info info { get; set; }

    }
}
