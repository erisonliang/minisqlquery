#region License

// Copyright 2005-2019 Paul Kohler (https://github.com/paulkohler/minisqlquery). All rights reserved.
// This source code is made available under the terms of the GNU Lesser General Public License v3.0
// https://github.com/paulkohler/minisqlquery/blob/master/LICENSE

#endregion

using System;
using System.Data;

namespace MiniSqlQuery.Core
{
    /// <summary>
    /// 	Represents an SQL query, some timings and the result (if executed).
    /// </summary>
    public class Query
    {
        /// <summary>
        /// 	Initializes a new instance of the <see cref = "Query" /> class.
        /// </summary>
        /// <param name = "sql">The SQL for the query.</param>
        public Query(string sql)
        {
            Sql = sql;
        }

        /// <summary>
        /// 	Gets or sets the end time.
        /// </summary>
        /// <value>The end time.</value>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 	Gets or sets the result.
        /// </summary>
        /// <value>The result.</value>
        public DataSet Result { get; set; }

        /// <summary>
        /// 	Gets the SQL query text.
        /// </summary>
        /// <value>The SQL query text.</value>
        public string Sql { get; private set; }

        /// <summary>
        /// 	Gets or sets the start time.
        /// </summary>
        /// <value>The start time.</value>
        public DateTime StartTime { get; set; }
    }
}