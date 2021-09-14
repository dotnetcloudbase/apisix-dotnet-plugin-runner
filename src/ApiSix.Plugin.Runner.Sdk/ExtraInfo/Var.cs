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
    public partial class Var
           : object
    {
        public Var()
        {
            checked
            {
                this.OnInitialized(null);
            }
        }

#pragma warning disable CS8618
        protected Var(FlatBufferDeserializationContext context)
        {
            checked
            {
            }
        }

#pragma warning restore CS8618
        public Var(Var source)
        {
            checked
            {
                this.OnInitialized(null);
            }
        }

        partial void OnInitialized(FlatBufferDeserializationContext? context);

        protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext? context) => this.OnInitialized(context);

        [FlatBufferItemAttribute(0)]
        public virtual System.String name { get; set; }

    }
}
