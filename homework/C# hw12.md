# C# Homework 12

## chapter 12 Working with Inheritance

### Name: Malachi Evans

#### file: C#hw12

#### date: February 13, 2019

------------------------------

1. How does inheritance promote the principle of don’t repeat yourself (DRY)?
    + by using classification to further create relationships in classes 
    + write common code once and put it in base class
2. What is the syntax of a derived class that inherits from a base class?
    + class derived class: base class 
3. Do all user deﬁned types (classes and structs) inherit from some base class? If so, what is it?
    + the System.Object Class
4. What happens if you do not have a default constructor in a base class when creating a derived class?
    + it will give a compile time error.
5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?
    + yes, it is one step higher in the hierarchy it was created in. 
6. Can you assign a variable of a derived class to another variable of a derived class of its base class? Why or why not?
    + no, it is not in order of the inheritance hierarchy.
7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?
    + yes, but you must use a as, is or a cast operator to verify that the type is correct.
8. Under what circumstances would you want to use the new keyword when deﬁning a method in a derived class?
    + to hide the bas method when using the same method signature in a derived class and base class.
9. What is a virtual method? Why would you want to deﬁne a virtual method?
    + A method that is intended to be overridden when you want to implement a class specific version of the method.
10. What does override do? Why does it do it?
    + it declares another implementation of a virtual class. you can call the base class method and return new value from it specific to the derived class. you can then call that method and use it based on the type give to it.
11. How do you deﬁne an extension type?
    + use the **this** keyword.
12. Why do you deﬁne an extension type?
    + add behaviors to classes where other wise you could not touch 
