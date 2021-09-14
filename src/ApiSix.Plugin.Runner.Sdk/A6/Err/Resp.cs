using FlatSharp;
using FlatSharp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSix.Plugin.Runner.Sdk.A6.Err
{
    [FlatBufferTable()]
    public class Resp           
    {
        [FlatBufferItem(0)]
        public virtual Code Code { get; set; }
    }
}
