
function display() {
    var tbodyCtrl = document.getElementById("tbody");
    tbodyCtrl.innerHTML = ""; // clear the table 
    var yellowRow = false;
    for(var product of products) {
        var row = "";
        if(yellowRow) {
            row = "<tr class='yellow'>";
        } else {
            row = "<tr>";
        }
        yellowRow = !yellowRow;
        //var row = "<tr>";
        row += `<td class='center'>${product.id}</td>`;
        row += `<td>${product.code}</td>`;
        row += `<td>${product.name}</td>`;
        var price = (product.price == 0 ? "Free" : product.price);
        row += `<td class='right'>${price}</td>`;
        row += `<td>${product.vendor.name}</td>`;
        row += "</tr>";
        tbodyCtrl.innerHTML += row;
    }

}

function loaded() {
    display();
}