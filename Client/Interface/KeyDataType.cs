using System;

namespace Client.Interface
{
    /// <summary>
    ///     Data type of a key (only long integer and string keys are suported). Other .NET types shoud be convertible
    ///     to long int or string. <see cref="DateTime" /> conversion to long int is automtically supported
    /// </summary>
    public enum KeyDataType
    {
        /// <summary>
        ///     internal use only
        /// </summary>
        Unknown,

        /// <summary>
        ///     long integer key
        /// </summary>
        IntKey,

        /// <summary>
        ///     string key
        /// </summary>
        StringKey //
    }
}