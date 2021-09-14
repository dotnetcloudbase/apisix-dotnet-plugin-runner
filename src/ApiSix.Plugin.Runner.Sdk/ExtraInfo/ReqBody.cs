using FlatSharp;
using FlatSharp.Attributes;

namespace ApiSix.Plugin.Runner.Sdk.ExtraInfo
{
    [FlatBufferTable()]
    public partial class ReqBody
     : object
    {
        public ReqBody()
        {
            checked
            {
                this.OnInitialized(null);
            }
        }

#pragma warning disable CS8618
        protected ReqBody(FlatBufferDeserializationContext context)
        {
            checked
            {
            }
        }

#pragma warning restore CS8618
        public ReqBody(ReqBody source)
        {
            checked
            {
                this.OnInitialized(null);
            }
        }

        partial void OnInitialized(FlatBufferDeserializationContext? context);

        protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext? context) => this.OnInitialized(context);

    }
}
