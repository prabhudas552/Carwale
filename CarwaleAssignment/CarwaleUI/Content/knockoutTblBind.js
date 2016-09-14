// Binding user information to table
function currentItem(fname, lname, DoB,gender) {
    var self = this;
    self.firstName = ko.observable(fname);
    self.lastName = ko.observable(lname);
    self.DoB = ko.observable(DoB);
    self.gender = ko.observable(gender);
}
function viewModel() {
    var self = this;
    self.tblData = ko.observableArray([
    new currentItem('Jhon', 'Smith', '12/07/1990','Male'),
    new currentItem('Mike', 'Todd', '23/03/1997', 'Female'),
    new currentItem('Jhon', 'Smith', '12/07/1990','Male'),
    new currentItem('Mike', 'Todd', '23/03/1997','Female'),
    new currentItem('Jhon', 'Smith', '12/07/1990','Male'),
    new currentItem('Mike', 'Todd', '23/03/1997', 'Female'),
    new currentItem('Jhon', 'Smith', '12/07/1990', 'Male'),
    new currentItem('Mike', 'Todd', '23/03/1997', 'Female'),
    new currentItem('Jhon', 'Smith', '12/07/1990', 'Male'),
    new currentItem('Mike', 'Todd', '23/03/1997', 'Female')
    ]);
}
ko.applyBindings(new viewModel());

// Updating user information
var global;
function updateUser(data) {

    global = data;
    document.getElementById("firstName").value = data.firstName();
    document.getElementById("lastName").value = data.lastName();
}
function update() {
    global.firstName(document.getElementById("firstName").value);
    global.lastName(document.getElementById("lastName").value);
}

// deleting user

function deleteUser(data) {

}