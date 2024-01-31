// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const addAuthor = document.getElementById('add-author-checkbox');
const authorInput = document.getElementById('add-author');
const authorPredefined = document.getElementById('predefined-authors');



function changeState() {
    if (addAuthor.checked) {
       
        authorPredefined.style.display = "none";
        authorInput.style.display = "block";
    } else {
       
        authorPredefined.style.display = "block";
        authorInput.style.display = "none";
    }

}