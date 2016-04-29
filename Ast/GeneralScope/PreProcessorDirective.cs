//2016, EngineKit

// 
// PreProcessorDirective.cs
//  
// Author:
//       Mike Krüger <mkrueger@xamarin.com>
// 
// Copyright (c) 2011 Xamarin Inc.
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
    public enum PreProcessorDirectiveType : byte
    {
        Invalid = 0,
        Region = 1,
        Endregion = 2,

        If = 3,
        Endif = 4,
        Elif = 5,
        Else = 6,

        Define = 7,
        Undef = 8,
        Error = 9,
        Warning = 10,
        Pragma = 11,
        Line = 12
    }

    public interface LinePreprocessorDirective : PreProcessorDirective
    {

    }

    public interface PragmaWarningPreprocessorDirective : PreProcessorDirective
    {
        bool Disable { get; }
    }

    public interface PreProcessorDirective : AstNode
    {

        PreProcessorDirectiveType Type { get; }
        string Argument { get; }

        /// <summary>
        /// For an '#if' directive, specifies whether the condition evaluated to true.
        /// </summary>
        bool Take { get; }
    }
}

