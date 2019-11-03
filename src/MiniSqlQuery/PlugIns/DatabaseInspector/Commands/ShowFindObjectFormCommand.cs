﻿#region License

// Copyright 2005-2019 Paul Kohler (https://github.com/paulkohler/minisqlquery). All rights reserved.
// This source code is made available under the terms of the GNU Lesser General Public License v3.0
// https://github.com/paulkohler/minisqlquery/blob/master/LICENSE
#endregion

using System;
using System.Linq;
using System.Windows.Forms;
using MiniSqlQuery.Core;
using MiniSqlQuery.Core.Commands;

namespace MiniSqlQuery.PlugIns.DatabaseInspector.Commands
{
    /// <summary>The show find object form command.</summary>
    public class ShowFindObjectFormCommand : CommandBase
    {
        /// <summary>Initializes a new instance of the <see cref="ShowFindObjectFormCommand"/> class.</summary>
        public ShowFindObjectFormCommand()
            : base("Find Object...")
        {
            ShortcutKeys = Keys.Alt | Keys.F;
        }

        /// <summary>Execute the command.</summary>
        public override void Execute()
        {
            using (var frm = Services.Resolve<FindObjectForm>())
            {
                frm.ShowDialog(HostWindow.Instance);

                var selectedTableName = frm.SelectedObjectName;
                if (frm.DialogResult == DialogResult.OK && !String.IsNullOrEmpty(selectedTableName))
                {
                    // Special case for handling schemas - We want the search without the [dbo].[foo] part 
                    // but the FindTableOrView expects it....
                    var parts = selectedTableName.Split('.').Select(s => "[" + s + "]").ToArray();
                    var name = String.Join(".", parts);

                    IDbModelNamedObject obj = HostWindow.DatabaseInspector.DbSchema.FindTableOrView(name);
                    HostWindow.DatabaseInspector.NavigateTo(obj);
                }
            }
        }
    }
}