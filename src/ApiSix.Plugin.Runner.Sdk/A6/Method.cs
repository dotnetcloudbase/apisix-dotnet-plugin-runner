using FlatSharp.Attributes;

namespace ApiSix.Plugin.Runner.Sdk.A6
{
    [FlatBufferEnum(typeof(byte))]
    public enum Method : byte
    {
        GET = (byte)(0),
        HEAD = (byte)(1),
        POST = (byte)(2),
        PUT = (byte)(3),
        DELETE = (byte)(4),
        MKCOL = (byte)(5),
        COPY = (byte)(6),
        MOVE = (byte)(7),
        OPTIONS = (byte)(8),
        PROPFIND = (byte)(9),
        PROPPATCH = (byte)(10),
        LOCK = (byte)(11),
        UNLOCK = (byte)(12),
        PATCH = (byte)(13),
        TRACE = (byte)(14),
    }
}
