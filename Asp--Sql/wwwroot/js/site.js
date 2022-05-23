// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$('#search').click(function () {

    $.ajax({
        url: "/home/getlist",
        data: {
            Name: $('#seachInput').val()
        },
        success: function (response) {
            $('#listTableBody').html('');


            let array = response.list;

            let bodyStirng = '';

            for (var i = 0; i < array.length; i++) {
                bodyStirng += '<tr><td>' + array[i].name + '</td><td>' + array[i].className +'</td></tr>'
            }

            $('#listTableBody').html(bodyStirng);

            console.log(response)
        }
    })



})


