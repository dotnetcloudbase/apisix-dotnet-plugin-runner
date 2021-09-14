using FlatSharp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSix.Plugin.Runner.Sdk.Err
{
    [FlatBufferEnum(typeof(System.Byte))]
    public enum Code : System.Byte
    {
        BAD_REQUEST = (byte)(0),
        SERVICE_UNAVAILABLE = (byte)(1),
        CONF_TOKEN_NOT_FOUND = (byte)(2),
    }
}
