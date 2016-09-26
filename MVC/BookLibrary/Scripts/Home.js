function getAllBooks() {
    $.ajax({
        url: "Home/GetAllBooks",
        dataType: 'json',

    }).done(function (result) {
        fillDatatable(result);
    });
}

function getBooksByCategory(parameter) {
    $.ajax({
        url: "Home/GetBooksByCategory",
        data: { category: parameter },
        dataType: 'json',

    }).done(function (result) {
        fillDatatable(result);
    });
}

function getBooksByAuthor(parameter) {
    $.ajax({
        url: "Home/GetBooksByAuthor",
        data: { author: parameter },
        dataType: 'json',

    }).done(function (result) {
        fillDatatable(result);
    });
}

function deleteBook(parameter) {
    $.ajax({
        type: "DELETE",
        url: "Home/DeleteBook/" + "?" + $.param({ "Id": parameter }),
        data: { Id: parameter }
    }).done(function (result) {
        debugger;
    });
}

function fillDatatable(dataSource) {
    $("#grid").html("");
    for (var i = 0; i < dataSource.length; i++) {
        $("#grid").append("<tr><td>" + dataSource[i].ID +
            "</td><td>" + dataSource[i].Name +
            "</td><td>" + dataSource[i].Category +
            "</td><td>" + dataSource[i].Author +
            "</td><td>" + dataSource[i].Author +
            "</td><td><button type='button' class='btn btn-default' onclick='deleteBook(" + dataSource[i].ID + ")'><span class='glyphicon glyphicon-remove' aria-hidden='true'></span> Delete</button>" +
            "</td></tr>");
    }
}

$(document).ready(function () {
    $("#GetAllBooks").click(function () {
        getAllBooks();
    });

    $("#GetBooksByAuthor").click(function () {
        var parameter = $("#Author").val();
        getBooksByAuthor(parameter);
    });

    $("#GetBooksByCategory").click(function () {
        var parameter = $("#Category").val();
        getBooksByCategory(parameter);
    });
});