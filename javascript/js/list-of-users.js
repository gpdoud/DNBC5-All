var users = [
    { id: 1, username: "sa1", password: "sa6", firstname: "SuperA", lastname: "AdminF", 
        phone:"555-555-5555", email:"a@user.com", isReviewer:true, isAdmin:true  },
    { id: 2, username: "sa2", password: "sa7", firstname: "SuperB", lastname: "AdminG", 
        phone:"555-555-5555", email:"a@user.com", isReviewer:true, isAdmin:true  },
    { id: 3, username: "sa3", password: "sa8", firstname: "SuperC", lastname: "AdminH", 
        phone:"555-555-5555", email:"a@user.com", isReviewer:true, isAdmin:true  },
    { id: 4, username: "sa4", password: "sa9", firstname: "SuperD", lastname: "AdminI", 
        phone:"555-555-5555", email:"a@user.com", isReviewer:true, isAdmin:true  },
    { id: 5, username: "sa5", password: "sa0", firstname: "SuperE", lastname: "AdminJ", 
        phone:"555-555-5555", email:"a@user.com", isReviewer:true, isAdmin:true  }
];

function loaded() {
    buildUserTable();
}

function buildUserTable() {
    var tbodyCtrl = document.getElementById("tbody");
    tbodyCtrl.innerHTML = "";
    for(var user of users) {
        var tr = "<tr>";
        tr += "<td class='center'>" + user.id + "</td>";
        tr += "<td>" + user.username + "</td>";
        tr += "<td>" + user.password + "</td>";
        tr += "<td>" + user.firstname + " " + user.lastname + "</td>";
        tr += "<td>" + user.phone + "</td>";
        tr += "<td>" + user.email + "</td>";
        tr += "<td class='center'>" + (user.isReviewer ? "Yes" : "No") + "</td>";
        tr += "<td class='center'>" + (user.isAdmin ? "Yes" : "No") + "</td>";
        tr += "</tr>";
        tbodyCtrl.innerHTML += tr;
    }
}