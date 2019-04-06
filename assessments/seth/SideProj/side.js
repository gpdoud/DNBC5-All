function insertFunction() {
    var table = document.getElementById("dataTable");
    var row = table.insertRow(0);
    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    var cell3 = row.insertCell(2);
    var name = document.getElementById('name').value;
    var bff = document.getElementById('bff').value;
    var age = document.getElementById('age').value;
    cell1.innerHTML = name;
    cell2.innerHTML = age;
    cell3.innerHTML = bff? "Yes" : "No";
  }