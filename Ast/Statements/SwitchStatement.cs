//2016, EngineKit

// 
// SwitchStatement.cs
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
    /// switch (Expression) { SwitchSections }
    /// </summary>
    public interface SwitchStatement : Statement
    {
        /// <summary>
        /// switch expression
        /// </summary>
        Expression Expression { get; }
        AstNodeCollection<SwitchSection> SwitchSections { get; }
    }

    public interface SwitchSection : AstNode
    {
        AstNodeCollection<CaseLabel> CaseLabels { get; }
        AstNodeCollection<Statement> Statements { get; }
    }

    public interface CaseLabel : AstNode
    {
        /// <summary>
        /// Gets or sets the expression. The expression can be null - if the expression is null, it's the default switch section.
        /// </summary>
        Expression Expression { get; set; }
    }
}
