// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    $(".btn-voltar").on("mousedown", function () {        
        $('.svg-btn-voltar').css("background-color", "#5C5327");
        $('.svg-btn-voltar path').css("fill", "#E1CC61");
    }).on("mouseup", function () {
        $('.svg-btn-voltar').css("background-color", "#E1CC61");
        $('.svg-btn-voltar path').css("fill", "#5C5327");
    });

    $('.btn-voltar').on('click', function (e) {
        e.preventDefault();
        window.history.back();
    });



});