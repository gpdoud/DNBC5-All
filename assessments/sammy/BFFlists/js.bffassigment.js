
function Addrow() {
    var name = document.getElementById('name').value;
    var Age = document.getElementById('Age').value;
    var BFF = document.getElementById('BFF').value;

    var table = document.getElementById('BFFList');
     //var onclick= getElementBrId('Add'). Value; 

    var newRow = table.insertRow(1);

    var cel1 = newRow.insertCell(0);
    var cel2 = newRow.insertCell(1);
    var cel3 = newRow.insertCell(2);
    
    cel1.innerHTML = name;
    cel2.innerHTML = Age;
    cel3.innerHTML = BFF;

}

 //Addrow('BFFList');
    //BFF.add({
       // name: nameField.val(),
       // Age: AgeField.val(),
       // BFF: BFFField.val()
    //});
//});


