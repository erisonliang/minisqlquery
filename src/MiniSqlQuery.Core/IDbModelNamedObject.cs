#region License

// Copyright 2005-2019 Paul Kohler (https://github.com/paulkohler/minisqlquery). All rights reserved.
// This source code is made available under the terms of the GNU Lesser General Public License v3.0
// https://github.com/paulkohler/minisqlquery/blob/master/LICENSE

#endregion

using System;

namespace MiniSqlQuery.Core
{
	/// <summary>
	/// 	A database model object, e.g. a column, table etc can implement this interface.
	/// </summary>
	public interface IDbModelNamedObject
	{
		/// <summary>
		/// Gets the full name of the object, e.g. "dbo.FistName".
		/// </summary>
		/// <value>The full name.</value>
		string FullName { get; }

		/// <summary>
		/// Gets the name of the object, e.g. "FistName".
		/// </summary>
		/// <value>The object name.</value>
		string Name { get; }

		/// <summary>
		/// Gets the type of the object, e.g. "VARCHAR".
		/// </summary>
		/// <value>The type of the object.</value>
		string ObjectType { get; }

		/// <summary>
		/// Gets the schema name, e.g. "dbo".
		/// </summary>
		/// <value>The schema name if any.</value>
		string Schema { get; }
	}
}