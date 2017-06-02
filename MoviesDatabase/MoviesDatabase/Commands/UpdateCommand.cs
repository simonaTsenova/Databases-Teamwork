﻿using System;
using System.Collections.Generic;
using MoviesDatabase.Commands.Abstracts;
using MoviesDatabase.Commands.Contracts;
using MoviesDatabase.Providers.Contracts;

namespace MoviesDatabase.Commands
{
    public class UpdateCommand : Command
    {
        public UpdateCommand(IDatabaseProvider databaseProvider) : base(databaseProvider)
        {
        }

        public override string Execute(IList<string> parameters)
        {
            throw new NotImplementedException();
        }
    }
}