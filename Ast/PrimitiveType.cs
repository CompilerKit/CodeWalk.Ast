//2016, EngineKit

// 
// FullTypeName.cs
//
// Author:
//       Mike Krüger <mkrueger@novell.com>
// 
// Copyright (c) 2010 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE. 
 
namespace CodeWalk.Ast.CSharp
{
    public interface PrimitiveType : AstType
    {
        string Keyword { get; }
        KnownTypeCode KnownTypeCode { get; }
    }


    /// <summary>
    /// Represents some well-known types.
    /// </summary>
    public enum KnownTypeCode
    {
        // Note: DefaultResolvedTypeDefinition uses (KnownTypeCode)-1 as special value for "not yet calculated".
        // The order of type codes at the beginning must correspond to those in System.TypeCode.

        /// <summary>
        /// Not one of the known types.
        /// </summary>
        None,
        /// <summary><c>object</c> (System.Object)</summary>
        Object,
        /// <summary><c>System.DBNull</c></summary>
        DBNull,
        /// <summary><c>bool</c> (System.Boolean)</summary>
        Boolean,
        /// <summary><c>char</c> (System.Char)</summary>
        Char,
        /// <summary><c>sbyte</c> (System.SByte)</summary>
        SByte,
        /// <summary><c>byte</c> (System.Byte)</summary>
        Byte,
        /// <summary><c>short</c> (System.Int16)</summary>
        Int16,
        /// <summary><c>ushort</c> (System.UInt16)</summary>
        UInt16,
        /// <summary><c>int</c> (System.Int32)</summary>
        Int32,
        /// <summary><c>uint</c> (System.UInt32)</summary>
        UInt32,
        /// <summary><c>long</c> (System.Int64)</summary>
        Int64,
        /// <summary><c>ulong</c> (System.UInt64)</summary>
        UInt64,
        /// <summary><c>float</c> (System.Single)</summary>
        Single,
        /// <summary><c>double</c> (System.Double)</summary>
        Double,
        /// <summary><c>decimal</c> (System.Decimal)</summary>
        Decimal,
        /// <summary><c>System.DateTime</c></summary>
        DateTime,
        /// <summary><c>string</c> (System.String)</summary>
        String = 18,

        // String was the last element from System.TypeCode, now our additional known types start

        /// <summary><c>void</c> (System.Void)</summary>
        Void,
        /// <summary><c>System.Type</c></summary>
        Type,
        /// <summary><c>System.Array</c></summary>
        Array,
        /// <summary><c>System.Attribute</c></summary>
        Attribute,
        /// <summary><c>System.ValueType</c></summary>
        ValueType,
        /// <summary><c>System.Enum</c></summary>
        Enum,
        /// <summary><c>System.Delegate</c></summary>
        Delegate,
        /// <summary><c>System.MulticastDelegate</c></summary>
        MulticastDelegate,
        /// <summary><c>System.Exception</c></summary>
        Exception,
        /// <summary><c>System.IntPtr</c></summary>
        IntPtr,
        /// <summary><c>System.UIntPtr</c></summary>
        UIntPtr,
        /// <summary><c>System.Collections.IEnumerable</c></summary>
        IEnumerable,
        /// <summary><c>System.Collections.IEnumerator</c></summary>
        IEnumerator,
        /// <summary><c>System.Collections.Generic.IEnumerable{T}</c></summary>
        IEnumerableOfT,
        /// <summary><c>System.Collections.Generic.IEnumerator{T}</c></summary>
        IEnumeratorOfT,
        /// <summary><c>System.Collections.Generic.ICollection</c></summary>
        ICollection,
        /// <summary><c>System.Collections.Generic.ICollection{T}</c></summary>
        ICollectionOfT,
        /// <summary><c>System.Collections.Generic.IList</c></summary>
        IList,
        /// <summary><c>System.Collections.Generic.IList{T}</c></summary>
        IListOfT,
        /// <summary><c>System.Collections.Generic.IReadOnlyCollection{T}</c></summary>
        IReadOnlyCollectionOfT,
        /// <summary><c>System.Collections.Generic.IReadOnlyList{T}</c></summary>
        IReadOnlyListOfT,
        /// <summary><c>System.Threading.Tasks.Task</c></summary>
        Task,
        /// <summary><c>System.Threading.Tasks.Task{T}</c></summary>
        TaskOfT,
        /// <summary><c>System.Nullable{T}</c></summary>
        NullableOfT,
        /// <summary><c>System.IDisposable</c></summary>
        IDisposable,
        /// <summary><c>System.Runtime.CompilerServices.INotifyCompletion</c></summary>
        INotifyCompletion,
        /// <summary><c>System.Runtime.CompilerServices.ICriticalNotifyCompletion</c></summary>
        ICriticalNotifyCompletion,
    }
}

