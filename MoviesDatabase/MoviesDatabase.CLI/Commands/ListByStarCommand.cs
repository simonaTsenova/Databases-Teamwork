﻿using System;
using System.Collections.Generic;
using ConsoleTables;
using MoviesDatabase.CLI.Commands.Contracts;
using MoviesDatabase.Models;
using MoviesDatabase.Parsers.Models;
using MoviesDatabase.Services.Contracts;

namespace MoviesDatabase.CLI.Commands
{
    public class ListByStarCommand : ICommand
    {
        private readonly IMovieService movieService;

        public ListByStarCommand(IMovieService movieService)
        {
            if (movieService == null)
            {
                throw new ArgumentNullException("Movie service cannot be null.");
            }

            this.movieService = movieService;
        }

        public string Execute(IList<string> parameters)
        {
            string starName = string.Join(" ", parameters);

            IEnumerable<Movie> movies = this.movieService.GetMoviesByStar(starName);

            if (movies == null)
            {
                throw new NullReferenceException("This star has no movie to show.");
            }

            IEnumerable<MovieForPrint> moviesForPrint = this.movieService.ConvertForPrint(movies);

            return ConsoleTable.From<MovieForPrint>(moviesForPrint).ToString();
        }
    }
}
