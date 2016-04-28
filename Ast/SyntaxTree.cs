//2016, EngineKit

// 
// SyntaxTree.cs
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

using System.Collections.Generic;

namespace CodeWalk.Ast.CSharp
{

    public interface SyntaxTree : AstNode
    {

        /// <summary>
        /// Gets/Sets the file name of this syntax tree.
        /// </summary>
        string FileName { get; set; }
        AstNodeCollection<AstNode> Members { get; set; }
        List<Error> Errors { get; }
        /// <summary>
        /// Gets the conditional symbols used to parse the source file. Note that this list contains
        /// the conditional symbols at the start of the first token in the file - including the ones defined
        /// in the source file.
        /// </summary>
        IList<string> ConditionalSymbols { get; set; }
        /// <summary>
        /// Gets the expression that was on top of the parse stack.
        /// This is the only way to get an expression that isn't part of a statment.
        /// (eg. when an error follows an expression).
        /// 
        /// This is used for code completion to 'get the expression before a token - like ., &lt;, ('.
        /// </summary>
        AstNode TopExpression { get; set; }
        IEnumerable<AstNode> GetChildIter();
    }
    public interface Error
    {
        int Code { get; set; }
        string Message { get; set; }
    }

}
