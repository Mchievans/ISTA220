# C# Homework 15

## chapter 15 Implmenting properties to access fields

### Name: Malachi Evans

#### file: C#hw15

#### date: February 24, 2019

------------------------------
1. What is the difference between a property and a field?
    + A property has implemntation a field doesnt.
2. What is the difference between a property and a method?
    + A property looks like a field but acts like a method.
3. What is your understanding of encapsulation?
    + it hides part of the code.
4. Some languages are case insensitive, that is, an `a" and an \A" are considered to be the same letter.
C# is case sensitive. What implications does this have regarding the naming of variables, methods,
and other identiers? Do you think that the difference in case in the initial character of two different
identiers is suffcient to distinguish them?


5. Give an example that is not in the book of an instance where you might want to use a read-only
property. Give an example not in the book of an instance where you might want to use s write-only
property.
   + A user id / social security code.
6. Can you think of a reason why you might ever want to make getters and setters private? Give an
example. Also, make a case why getters and setters should never be private.
   + 
7. What are restrictions on the use of properties?
   + A property can contain at most one get accessor and one set accessor. lds, or properties.The get and set accessors cannot take any parameters. 
   + You can’t declare properties by using const
   + You can’t use a property as a ref or an out argument to a method (although you can use a writable field as a ref or an out argument). 
8. What is an object initializer? What is the syntax for an object initializer?
   + initialize it by specifying the names and values for any public properties that have set accessors.
   + Triangle tri1 = new Triangle { Side3Length = 15 };