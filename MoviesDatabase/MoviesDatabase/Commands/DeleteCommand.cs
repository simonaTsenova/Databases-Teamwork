﻿using System;
using System.Collections.Generic;
using MoviesDatabase.CLI.Commands.Abstracts;
using MoviesDatabase.CLI.Commands.Contracts;
using MoviesDatabase.CLI.Providers.Contracts;

namespace MoviesDatabase.CLI.Commands
{
    public class DeleteCommand : Command
    {
        public DeleteCommand(IDatabaseProvider databaseProvider) : base(databaseProvider)
        {
        }

        public override string Execute(IList<string> parameters)
        {
            throw new NotImplementedException();
        }
    }
}
