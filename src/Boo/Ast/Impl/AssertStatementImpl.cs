#region license
// boo - an extensible programming language for the CLI
// Copyright (C) 2004 Rodrigo B. de Oliveira
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// As a special exception, if you link this library with other files to
// produce an executable, this library does not by itself cause the
// resulting executable to be covered by the GNU General Public License.
// This exception does not however invalidate any other reasons why the
// executable file might be covered by the GNU General Public License.
//
// Contact Information
//
// mailto:rbo@acm.org
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by the
// ast.py script on Sun Jan 11 23:16:51 2004
//
using System;

namespace Boo.Ast.Impl
{
	[Serializable]
	public abstract class AssertStatementImpl : Statement
	{
		protected Expression _condition;
		protected Expression _message;
		
		protected AssertStatementImpl()
		{
 		}
		
		protected AssertStatementImpl(Expression condition, Expression message)
		{
 			Condition = condition;
			Message = message;
		}
		
		protected AssertStatementImpl(antlr.Token token, Expression condition, Expression message) : base(token)
		{
 			Condition = condition;
			Message = message;
		}
		
		internal AssertStatementImpl(antlr.Token token) : base(token)
		{
 		}
		
		internal AssertStatementImpl(Node lexicalInfoProvider) : base(lexicalInfoProvider)
		{
 		}
		
		public override NodeType NodeType
		{
			get
			{
				return NodeType.AssertStatement;
			}
		}
		public Expression Condition
		{
			get
			{
				return _condition;
			}
			
			set
			{
				
				if (_condition != value)
				{
					_condition = value;
					if (null != _condition)
					{
						_condition.InitializeParent(this);
					}
				}
			}
		}
		public Expression Message
		{
			get
			{
				return _message;
			}
			
			set
			{
				
				if (_message != value)
				{
					_message = value;
					if (null != _message)
					{
						_message.InitializeParent(this);
					}
				}
			}
		}
		public override void Switch(IAstTransformer transformer, out Node resultingNode)
		{
			AssertStatement thisNode = (AssertStatement)this;
			Statement resultingTypedNode = thisNode;
			transformer.OnAssertStatement(thisNode, ref resultingTypedNode);
			resultingNode = resultingTypedNode;
		}
	}
}
