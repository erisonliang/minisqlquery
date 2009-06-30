﻿using System;
using System.Data;
using MiniSqlQuery.Core;

namespace MiniSqlQuery.PlugIns.DatabaseInspector.Commands
{
	public class GenerateDeleteStatementCommand : GenerateStatementCommandBase
	{
		public GenerateDeleteStatementCommand()
			: base("Generate Delete Statement")
		{
		}

		public override void Execute()
		{
			IQueryEditor editor = Services.HostWindow.ActiveChildForm as IQueryEditor;
			string tableName = Services.HostWindow.DatabaseInspector.RightClickedTableName;
			DataTable schema = Services.HostWindow.DatabaseInspector.DbSchema;

			if (tableName != null && editor != null)
			{
				//todo - calc PK?
				string pkClause = "(idToDo = ?)";
				string text = string.Format("DELETE\r\nFROM {0}\r\nWHERE {1}", tableName, pkClause);
				editor.InsertText(text);
			}
		}
	}
}