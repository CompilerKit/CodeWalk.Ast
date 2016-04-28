﻿//2016, EngineKit

// 
// BinaryOperatorExpression.cs
//
// Author:
//       Mike Krüger <mkrueger@novell.com>
// 
// Copyright (c) 2009 Novell, Inc (http://www.novell.com)
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
    /// <summary>
    /// Left Operator Right
    /// </summary>
    public interface BinaryOperatorExpression : Expression
    {
        BinaryOperatorType Operator { get; set; }
        Expression Left { get; set; }
        Expression Right { get; set; } 
    }

    public enum BinaryOperatorType
    {
        /// <summary>
        /// Any binary operator (used in pattern matching)
        /// </summary>
        Any,

        // We avoid 'logical or' on purpose, because it's not clear if that refers to the bitwise
        // or to the short-circuiting (conditional) operator:
        // MCS and old NRefactory used bitwise='|', logical='||'
        // but the C# spec uses logical='|', conditional='||'
        /// <summary>left &amp; right</summary>
        BitwiseAnd,
        /// <summary>left | right</summary>
        BitwiseOr,
        /// <summary>left &amp;&amp; right</summary>
        ConditionalAnd,
        /// <summary>left || right</summary>
        ConditionalOr,
        /// <summary>left ^ right</summary>
        ExclusiveOr,

        /// <summary>left &gt; right</summary>
        GreaterThan,
        /// <summary>left &gt;= right</summary>
        GreaterThanOrEqual,
        /// <summary>left == right</summary>
        Equality,
        /// <summary>left != right</summary>
        InEquality,
        /// <summary>left &lt; right</summary>
        LessThan,
        /// <summary>left &lt;= right</summary>
        LessThanOrEqual,

        /// <summary>left + right</summary>
        Add,
        /// <summary>left - right</summary>
        Subtract,
        /// <summary>left * right</summary>
        Multiply,
        /// <summary>left / right</summary>
        Divide,
        /// <summary>left % right</summary>
        Modulus,

        /// <summary>left &lt;&lt; right</summary>
        ShiftLeft,
        /// <summary>left &gt;&gt; right</summary>
        ShiftRight,

        /// <summary>left ?? right</summary>
        NullCoalescing
    }
}
