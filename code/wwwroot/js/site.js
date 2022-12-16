// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// create event listener for the movies
let movies = document.getElementsByClassName("movieTitle");
let movieDetails = document.getElementsByClassName("movieInfo");

for (let i = 0; i < movies.length; i++) {
    movies[i].addEventListener("click", function () {
        // check if the movie details are already shown
        if (movieDetails[i].style.display === "block") {
            // hide the movie details
            movieDetails[i].style.display = "none";
        } else {
            // check if there are any other movie details shown
            for (let j = 0; j < movieDetails.length; j++) {
                if (movieDetails[j].style.display === "block") {
                    // hide the movie details
                    movieDetails[j].style.display = "none";
                }
            // show the movie details
            movieDetails[i].style.display = "block";
            }
        }
    });
}