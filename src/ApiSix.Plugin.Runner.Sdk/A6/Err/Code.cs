using FlatSharp.Attributes;

namespace ApiSix.Plugin.Runner.Sdk.A6.Err
{
    [FlatBufferEnum(typeof(byte))]
    public enum Code : byte
    {
        BAD_REQUEST = 0,
        SERVICE_UNAVAILABLE = 1,
        CONF_TOKEN_NOT_FOUND = 2,
    }
}
