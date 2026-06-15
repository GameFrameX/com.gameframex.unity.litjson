#region Header

/**
 * JsonException.cs
 *   Base class throwed by LitJSON when a parsing error occurs.
 *
 * The authors disclaim copyright to this source code. For more details, see
 * the COPYING file included with this distribution.
 **/

#endregion


using System;


namespace GameFrameX.LitJSON.Runtime
{
    /// <summary>
    /// JSON 解析错误时抛出的异常，是 LitJSON 中所有解析异常的基类。
    /// </summary>
    /// <remarks>
    /// Base class thrown by LitJSON when a parsing error occurs.
    /// </remarks>
    public class JsonException :
#if NETSTANDARD1_5
        Exception
#else
        ApplicationException
#endif
    {
        /// <summary>初始化 JsonException 类的新实例，使用默认错误消息 / Initializes a new instance of the JsonException class with a default error message.</summary>
        public JsonException() : base()
        {
        }

        internal JsonException(ParserToken token) :
            base(string.Format(
                     "Invalid token '{0}' in input string", token))
        {
        }

        internal JsonException(ParserToken token,
            Exception inner_exception) :
            base(string.Format(
                     "Invalid token '{0}' in input string", token),
                 inner_exception)
        {
        }

        internal JsonException(int c) :
            base(string.Format(
                     "Invalid character '{0}' in input string", (char)c))
        {
        }

        internal JsonException(int c, Exception inner_exception) :
            base(string.Format(
                     "Invalid character '{0}' in input string", (char)c),
                 inner_exception)
        {
        }


        /// <summary>使用指定的错误消息初始化 JsonException 类的新实例 / Initializes a new instance of the JsonException class with a specified error message.</summary>
        /// <param name="message">描述错误的消息 / The message that describes the error.</param>
        public JsonException(string message) : base(message)
        {
        }

        /// <summary>使用指定的错误消息和对导致此异常的内部异常的引用初始化 JsonException 类的新实例 / Initializes a new instance of the JsonException class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
        /// <param name="message">描述错误的消息 / The error message that explains the reason for the exception.</param>
        /// <param name="inner_exception">导致当前异常的内部异常引用 / The exception that is the cause of the current exception.</param>
        public JsonException(string message, Exception inner_exception) :
            base(message, inner_exception)
        {
        }
    }
}