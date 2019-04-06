var url = "http://localhost:54371/api/";

var user = {
    id: 0,
    username: "test1",
    password: "test1",
    firstname: "test1",
    lastname: "test1",
    phone: "513-555-1212",
    firstname: "test1@test.com",
    isReviewer: true,
    isAdmin: false,
    active: true
};

$().ready(function() {

    console.log("Ready...");

    $.ajax({
        method: "POST",
        url: url + "users",
        data: JSON.stringify(user),
        content: "json",
        contentType: "application/json"
    })
        .done(function(resp) {
            console.log(resp);
            getAllUsers();
        });

});

function getAllUsers() {
    $.getJSON(url + "users")
        .done(function(resp) {
            console.log(resp);
        });
}
