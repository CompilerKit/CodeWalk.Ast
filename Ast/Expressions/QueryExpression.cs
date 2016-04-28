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
    public interface QueryExpression : Expression
    {
        AstNodeCollection<QueryClause> Clauses { get; }
    }

    public interface QueryClause : AstNode
    {

    }

    /// <summary>
    /// Represents a query continuation.
    /// "(from .. select ..) into Identifier" or "(from .. group .. by ..) into Identifier"
    /// Note that "join .. into .." is not a query continuation!
    /// 
    /// This is always the first(!!) clause in a query expression.
    /// The tree for "from a in b select c into d select e" looks like this:
    /// new QueryExpression {
    /// 	new QueryContinuationClause {
    /// 		PrecedingQuery = new QueryExpression {
    /// 			new QueryFromClause(a in b),
    /// 			new QuerySelectClause(c)
    /// 		},
    /// 		Identifier = d
    /// 	},
    /// 	new QuerySelectClause(e)
    /// }
    /// </summary>
    public interface QueryContinuationClause : QueryClause
    {
        //into...

        QueryExpression PrecedingQuery { get; set; }
        string Identifier { get; set; }
    }

    public interface QueryFromClause : QueryClause
    {
        AstType Type { get; set; }
        string Identifier { get; set; }
        Expression Expression { get; set; }

    }

    public interface QueryLetClause : QueryClause
    {
        string Identifier { get; set; }
        Expression Expression { get; set; }
    }


    public interface QueryWhereClause : QueryClause
    {
        Expression Condition { get; set; }
    }

    /// <summary>
    /// Represents a join or group join clause.
    /// </summary>
    public interface QueryJoinClause : QueryClause
    {
        bool IsGroupJoin { get; }
        AstType Type { get; set; }
        string JoinIdentifier { get; set; }
        Expression InExpression { get; set; }
        Expression OnExpression { get; set; }
        Expression EqualsExpression { get; set; }
        string IntoIdentifier { get; set; }
    }

    public interface QueryOrderClause : QueryClause
    {
        AstNodeCollection<QueryOrdering> Orderings { get; }
    }

    public interface QueryOrdering : AstNode
    {

        Expression Expression { get; set; }
        QueryOrderingDirection Direction { get; set; }
    }

    public enum QueryOrderingDirection
    {
        None,
        Ascending,
        Descending
    }

    public interface QuerySelectClause : QueryClause
    {
        Expression Expression { get; set; }
    }

    public interface QueryGroupClause : QueryClause
    {
        Expression Projection { get; set; }
        Expression Key { get; set; } 
    }
}