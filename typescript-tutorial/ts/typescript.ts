class User {
    id: number;
    username: string;
    password: string;
    firstname: string;
    lastname: string;
    phone: string;
    email: string;
    isReview: boolean;
    isAdmin: boolean;
    active: boolean;

    private log(): void {
        console.log(this);
    }

    constructor(username: string, password: string, firstname: string, lastname: string, 
                phone: string, email: string, isReviewer: boolean = false, isAdmin: boolean = false, 
                active: boolean = true) {
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
}

let user: User = new User("ABC", "CBA", "XXX", "ZZZ", "555-555-5555", "abc@cba.com");

user.log();