var url = "http://localhost:54371/api/";

// var user = {
//     id: 0,
//     username: "sa", password: "sa",
//     firstname: "Super", lastname: "Admin",
//     phone: "513-555-1212", email: "super@admin.com",
//     isReviewer: true, isAdmin: true, active: true
// };


$().ready(() => {

    console.log("Ready...");

    $.getJSON(url + "users")
        .done(function(resp) { 
            console.log(resp); 
            render(resp);
        });

});

function render(users) {
    $("tbody").html("");
    for(var user of users) {
        var tr = "<tr>";
        tr += `<td>${user.id}</td>`;
        tr += `<td>${user.username}</td>`;
        tr += `<td>${user.firstname} ${user.lastname}</td>`;
        tr += `<td>${user.phone}</td>`;
        tr += `<td>${user.email}</td>`;
        var reviewer = user.isReviewer ? "Rev" : "";
        var admin = user.isAdmin ? "Adm" : "";
        tr += `<td>${reviewer} ${admin}</td>`;
        tr += `<td><a href="">Detail</a> | <a href="">Edit</a></td>`;
        tr += "</tr>";
        $("tbody").append(tr);
    }
}