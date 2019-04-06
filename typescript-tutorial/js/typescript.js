"use strict";
var User = /** @class */ (function () {
    function User(username, password, firstname, lastname, phone, email, isReviewer, isAdmin, active) {
        if (isReviewer === void 0) { isReviewer = false; }
        if (isAdmin === void 0) { isAdmin = false; }
        this.id = 0;
        this.username = username;
        this.password = password;
        this.firstname = firstname;
        this.lastname = lastname;
        this.phone = phone;
        this.email = email;
        this.isReview = isReviewer;
        this.isAdmin = isAdmin;
        this.active = active;
    }
    User.prototype.log = function () {
        console.log(this);
    };
    return User;
}());
var user = new User("ABC", "CBA", "XXX", "ZZZ", "555-555-5555", "abc@cba.com", false, false, true);
user.log();
