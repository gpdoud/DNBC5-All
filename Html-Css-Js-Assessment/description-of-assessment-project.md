# Assessment Project for HTML/CSS/JS

In this assessment, you need to create single html page that both displays data and allows new data to be entered.

The data to use is called Friend. Each friend item has the following properties

* name - a string with a max of 30 characters
* age - an integer
* bestFriend - a boolean

The page should have a number of form controls to allow new friend items to be added. It should also be styled with Bootstrap.

```
Name: _______________
Age: ___
Best Friend: _ (Y or N)
OK (button)
```

The underscores above should be form controls like <input> (text, number, checkbox) or <select>.

The user can fill out the form controls, click the OK button, and the row should be inserted into an array that starts empty.

Below the for controls, the current data in the array is displayed in rows and columns in the order each record exist.

The array display should look something like this:

Name        Age     BFF
John        27      N
Jill        23      Y
Bill        31      Y
Jane        21      N

Your project should include a separate file for javascript and a separate file for any CSS and they should be stored in
subfolders with names as instructed in class. They should NOT be in the same folder with your HTML file.