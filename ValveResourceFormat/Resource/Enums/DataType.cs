﻿namespace ValveResourceFormat
{
    public enum DataType
    {
#pragma warning disable 1591
        Struct = 1,
        Enum = 2, // TODO: not verified with resourceinfo
        ExternalReference = 3,
        String4 = 4, // TODO: not verified with resourceinfo
        SByte = 10,
        Byte = 11,
        Int16 = 12,
        UInt16 = 13,
        Int32 = 14,
        UInt32 = 15,
        Int64 = 16, // TODO: not verified with resourceinfo
        UInt64 = 17,
        Float = 18,
        Vector = 22,
        Vector4D = 23,
        Quaternion = 25,
        Fltx4 = 27,
        Color = 28, // TODO: not verified with resourceinfo
        Boolean = 30,
        String = 31,
        Matrix3x4 = 33,
        Matrix3x4a = 36,
        CTransform = 40,
#pragma warning restore 1591
    }
}
