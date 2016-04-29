//2016, EngineKit

// Copyright (c) 2010-2013 AlphaSierraPapa for the SharpDevelop Team
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this
// software and associated documentation files (the "Software"), to deal in the Software
// without restriction, including without limitation the rights to use, copy, modify, merge,
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
// to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE. 

namespace CodeWalk.Ast.CSharp
{
    /// <summary>
    /// Represents a 'cref' reference in XML documentation.
    /// </summary>
    public interface DocumentationReference : AstNode
    {

        /// <summary>
        /// Gets/Sets the operator type.
        /// This property is only used when SymbolKind==Operator.
        /// </summary>
        OperatorType OperatorType { get; }

        /// <summary>
        /// Gets/Sets whether a parameter list was provided.
        /// </summary>
        bool HasParameterList { get; }

        /// <summary>
        /// Gets/Sets the declaring type.
        /// </summary>
        AstType DeclaringType { get; }
        /// <summary>
        /// Gets/sets the member name.
        /// This property is only used when SymbolKind==None.
        /// </summary>
        string MemberName { get; }
        /// <summary>
        /// Gets/Sets the return type of conversion operators.
        /// This property is only used when SymbolKind==Operator and OperatorType is explicit or implicit.
        /// </summary>
        AstType ConversionOperatorReturnType { get; }

        AstNodeCollection<AstType> TypeArguments { get; }

        AstNodeCollection<ParameterDeclaration> Parameters { get; }

    }
}
