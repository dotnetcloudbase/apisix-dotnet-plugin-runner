using FlatSharp.Attributes;

namespace ApiSix.Plugin.Runner.Sdk.A6
{
    [FlatBufferTable()]
    public class TextEntry
    {

        [FlatBufferItem(0)]
        public virtual string Name { get; set; }

        [FlatBufferItem(1)]
        public virtual string Value { get; set; }

    }
}
