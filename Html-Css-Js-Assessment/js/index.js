var friends = [
    // { name: 'Greg', age: 99, bff: true }
];

function loaded() {
    display(friends);
}

function display(friends) {
    var tbody = document.getElementById("tbody");
    tbody.innerHTML = "";
    for(var f of friends) {
        var bff = f.bff ? "Y" : "N";
        var row = "<tr>";
        row += "<td>" + f.name + "</td>";
        row += "<td>" + f.age + "</td>";
        row += "<td>" + bff + "</td>";
        row += "<tr>";
        tbody.innerHTML += row;
    }
}

function add() {
    var friend = {
        name: document.getElementById("name").value,
        age: document.getElementById("age").value,
        bff: document.getElementById("bff").checked ? true : false
    }
    friends.push(friend);
    display(friends);
}