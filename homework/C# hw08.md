# C# Homework 08

## chapter 8

### Name: Malachi Evans

#### file: C#hw08

#### date: January 30, 2019

------------------------------

1. What is the diﬀerence between deep copy and shallow copy?
    + When the clone method copies a reference to a field its a deep copy. when just copies references its a shallow copy.
2. What is the value of a reference after you declare and initialize it? The assign vaule when it was initalized

3. How do you declare a value type?
    + use one of the primitive type names 
4. How do you declare a reference type?
    + create a new instannce of the class and assign the refference varable to the new object
5. Does C# allow you to assign NULL to a value type?
    + no because it is a reference. 
6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?
    + no becasue that vaule can not be null
7. What is the diﬀerence between the stack and the heap?
    + the stack stores  methods and values while the heap stores objects  and reference types 
8. What does it mean when we say that all classes are specialized types? 
    + a class is a custom type 
9. What does ref do?
    + changes the parameter in the orginal aragument instead of passing it a copy of the new reference 
10. What does out do?
    + it makes the method initialize the parameter method must assign a value.
11. Describe boxing and unboxing in your own words.
    + Boxing - converting a value to a reference type.
    + unboxing - converting reference type into the value type.
12. What does cast do?
    + casting tells the system the object referecnced is a certain data type. The complier wont throw and exception but the runtime will if it is wrong. Put a catch in place for this. 