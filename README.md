# Task-9 
Create a C# program that requests three names of people from the user and stores them in an array of objects of type Person. 
To do this, first create a Person class that has a Name property of type string and override the ToString() method.
 End the program by reading people and executing the ToString() method on the screen.
 
# Task-9.2
Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects.
To do this, first create a Person class that has a Name property of type string, a constructor that receives the name as a parameter,
a destructor that assigns the name to empty and overwrites the ToString () method.
End the program by reading the people and executing the ToString () method on screen.

# Task-9.3
Create a new C # project with three classes plus another class to test the logic in your code. The main classes of the program are the following classes:

Person
Student
Professor
The Student and Teacher classes inherit from the Person class.

The Student class will include a public Study() method that will write I'm studying on the screen.

The Person class must have two public methods Greet() and SetAge(int age) that will assign the age of the person.

The Teacher class will include a public Explain() method that will write I'm explaining on the screen.

Also create a public method ShowAge() in the Student class that writes My age is: x years old on the screen.

You must create another test class called StudentProfessorTest with a Main method to do the following:

Create a new Person and make him say hello
Create a new Student, set an age, say hello, and display her age on the screen.
Create a new Teacher, set an age, say hello and start the explanation.

# Task-9.4
Create a C# program to manage a photo book using object-oriented programming.

To start, create a class called PhotoBook with a private attribute numPages of type int. It must also have a public method GetNumberPages that will return the number of photo book pages.

The default constructor will create an album with 16 pages. There will be an additional constructor, with which we can specify the number of pages we want in the album.

There is also a BigPhotoBook class whose constructor will create an album with 64 pages.

Finally create a PhotoBookTest class to perform the following actions:

Create a default photo book and show the number of pages
Create a photo book with 24 pages and show the number of pages
Create a large photo book and show the number of pages
