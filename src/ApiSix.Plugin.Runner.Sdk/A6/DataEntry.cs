using FlatSharp;
using FlatSharp.Attributes;
using System.Collections.Generic;

namespace ApiSix.Plugin.Runner.Sdk.A6
{
    [FlatBufferTable()]
    public class DataEntry
    {

        [FlatBufferItem(0)]
        public virtual string Name { get; set; }

        [FlatBufferItem(1)]
        public virtual IList<byte> Value { get; set; }

    }
}
