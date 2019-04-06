var url = "http://localhost:54371/api/";

var user;

$().ready(function() {

    console.log("Ready...");

    $.getJSON(`${url}users/4`)
        .done(function(resp) {
            console.log(resp);
            user = resp;
            display();
        });

});

function display() {
    $("#pId").text(user.id);
    $("#pUsername").text(user.username);
}