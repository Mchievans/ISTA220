# C# Homework 17

## chapter 17 introducing generics

### Name: Malachi Evans

#### file: C#hw17

#### date: March 03, 2019

------------------------------

1. What is a type parameter?
    + the type name followed by the type in brackets
2. What does a type parameter do?
    + you create a generic type that can tak on any type
3. How many type parameters can a generic class have?
    + as many as you want.
4. What is the difference between a generic class and a generalized class?
    + you dont have to cast with a generic class.
5. What is a constraint? How do you specify a constraint?
    + you can limit the parameter types. using the keyword where
6. What is a generic method? How do you define a generic method?
    + you can specify the types of the parameters and the return type by using a type parameter and by using the same type parameter syntax you use when you create generic classes.
7. What do we mean when we say that a generic type interface is invariant?
    + the type must stay the same.
8. What do we mean when we say that a generic type interface is covariant?
    + the return type must stay the same.
9. Does covariance work with value types? Does it work with reference types?
    + reference types only.
10. What do we mean when we say that a generic type interface is contravariant?
    + Contravariance follows a similar principle to covariance except that it works in the opposite direction; it enables you to use a generic interface to reference an object of type B through a reference to type A as long as type B derives from type A.