#region Header

/**
 * IJsonWrapper.cs
 *   Interface that represents a type capable of handling all kinds of JSON
 *   data. This is mainly used when mapping objects through JsonMapper, and
 *   it's implemented by JsonData.
 *
 * The authors disclaim copyright to this source code. For more details, see
 * the COPYING file included with this distribution.
 **/

#endregion


using System.Collections;
using System.Collections.Specialized;


namespace GameFrameX.LitJSON.Runtime
{
    /// <summary>
    /// JSON 数据类型枚举，用于标识 JsonData 当前持有的数据类型。
    /// </summary>
    /// <remarks>
    /// Enumeration of JSON data types, used to identify the type of data
    /// currently held by a JsonData instance.
    /// </remarks>
    public enum JsonType
    {
        /// <summary>未初始化 / Not initialized.</summary>
        None,

        /// <summary>对象类型 / Object type.</summary>
        Object,

        /// <summary>数组类型 / Array type.</summary>
        Array,

        /// <summary>字符串类型 / String type.</summary>
        String,

        /// <summary>32 位整数 / 32-bit integer.</summary>
        Int,

        /// <summary>64 位长整数 / 64-bit long integer.</summary>
        Long,

        /// <summary>双精度浮点数 / Double-precision floating point.</summary>
        Double,

        /// <summary>布尔值 / Boolean value.</summary>
        Boolean,
    }

    /// <summary>
    /// 表示能处理各种 JSON 数据的类型的接口，主要由 JsonData 实现，
    /// 用于在 JsonMapper 中作为对象映射的目标类型。
    /// </summary>
    /// <remarks>
    /// Interface that represents a type capable of handling all kinds of JSON
    /// data. This is mainly used when mapping objects through JsonMapper, and
    /// it's implemented by JsonData.
    /// </remarks>
    public interface IJsonWrapper : IList, IOrderedDictionary
    {
        /// <summary>获取当前实例是否为数组 / Gets whether this instance holds an array.</summary>
        /// <value>如果为数组则为 true；否则为 false / true if this instance holds an array; otherwise, false.</value>
        bool IsArray { get; }

        /// <summary>获取当前实例是否为布尔值 / Gets whether this instance holds a boolean.</summary>
        /// <value>如果为布尔值则为 true；否则为 false / true if this instance holds a boolean; otherwise, false.</value>
        bool IsBoolean { get; }

        /// <summary>获取当前实例是否为双精度浮点数 / Gets whether this instance holds a double.</summary>
        /// <value>如果为双精度浮点数则为 true；否则为 false / true if this instance holds a double; otherwise, false.</value>
        bool IsDouble { get; }

        /// <summary>获取当前实例是否为 32 位整数 / Gets whether this instance holds an int.</summary>
        /// <value>如果为 32 位整数则为 true；否则为 false / true if this instance holds an int; otherwise, false.</value>
        bool IsInt { get; }

        /// <summary>获取当前实例是否为 64 位长整数 / Gets whether this instance holds a long.</summary>
        /// <value>如果为 64 位长整数则为 true；否则为 false / true if this instance holds a long; otherwise, false.</value>
        bool IsLong { get; }

        /// <summary>获取当前实例是否为对象 / Gets whether this instance holds an object.</summary>
        /// <value>如果为对象则为 true；否则为 false / true if this instance holds an object; otherwise, false.</value>
        bool IsObject { get; }

        /// <summary>获取当前实例是否为字符串 / Gets whether this instance holds a string.</summary>
        /// <value>如果为字符串则为 true；否则为 false / true if this instance holds a string; otherwise, false.</value>
        bool IsString { get; }

        /// <summary>获取当前实例的布尔值 / Gets the boolean value held by this instance.</summary>
        /// <returns>当前实例的布尔值 / The boolean value of this instance.</returns>
        bool GetBoolean();

        /// <summary>获取当前实例的双精度浮点数 / Gets the double value held by this instance.</summary>
        /// <returns>当前实例的双精度浮点数 / The double value of this instance.</returns>
        double GetDouble();

        /// <summary>获取当前实例的 32 位整数 / Gets the int value held by this instance.</summary>
        /// <returns>当前实例的 32 位整数 / The int value of this instance.</returns>
        int GetInt();

        /// <summary>获取当前实例的 JSON 数据类型 / Gets the JSON data type of this instance.</summary>
        /// <returns>当前实例的 JSON 数据类型 / The JSON data type of this instance.</returns>
        JsonType GetJsonType();

        /// <summary>获取当前实例的 64 位长整数 / Gets the long value held by this instance.</summary>
        /// <returns>当前实例的 64 位长整数 / The long value of this instance.</returns>
        long GetLong();

        /// <summary>获取当前实例的字符串 / Gets the string value held by this instance.</summary>
        /// <returns>当前实例的字符串 / The string value of this instance.</returns>
        string GetString();

        /// <summary>设置当前实例的布尔值 / Sets the boolean value of this instance.</summary>
        /// <param name="val">要设置的布尔值 / The boolean value to set.</param>
        void SetBoolean(bool val);

        /// <summary>设置当前实例的双精度浮点数 / Sets the double value of this instance.</summary>
        /// <param name="val">要设置的双精度浮点数 / The double value to set.</param>
        void SetDouble(double val);

        /// <summary>设置当前实例的 32 位整数 / Sets the int value of this instance.</summary>
        /// <param name="val">要设置的 32 位整数 / The int value to set.</param>
        void SetInt(int val);

        /// <summary>设置当前实例的 JSON 数据类型 / Sets the JSON data type of this instance.</summary>
        /// <param name="type">要设置的 JSON 数据类型 / The JSON data type to set.</param>
        void SetJsonType(JsonType type);

        /// <summary>设置当前实例的 64 位长整数 / Sets the long value of this instance.</summary>
        /// <param name="val">要设置的 64 位长整数 / The long value to set.</param>
        void SetLong(long val);

        /// <summary>设置当前实例的字符串 / Sets the string value of this instance.</summary>
        /// <param name="val">要设置的字符串 / The string value to set.</param>
        void SetString(string val);

        /// <summary>将当前实例序列化为 JSON 字符串 / Serializes this instance into a JSON string.</summary>
        /// <returns>序列化后的 JSON 字符串 / The serialized JSON string.</returns>
        string ToJson();

        /// <summary>将当前实例序列化到指定的 JsonWriter / Serializes this instance into the specified JsonWriter.</summary>
        /// <param name="writer">接收序列化结果的 JsonWriter / The JsonWriter that receives the serialization result.</param>
        void ToJson(JsonWriter writer);
    }
}