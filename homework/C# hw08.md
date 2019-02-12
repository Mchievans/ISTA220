1. What is the diﬀerence between deep copy and shallow copy?
    + creating a method that is public and calling that method that copies that data. referencing the data from that object.
2. What is the value of a reference after you declare and initialize it?
    + null
3. How do you declare a value type?
    + by declaring its type, name, and value.
4. How do you declare a reference type?
    + use keyword NEW 
5. Does C# allow you to assign NULL to a value type?
    + NO 
6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?
    + NO, it’s a reference itself unless you use? after the value type. int? = null;
7. What is the diﬀerence between the stack and the heap?
    + The stack stores value types while the heap stores reference types. 
8. What does it mean when we say that all classes are specialized types?
    + A class is a type that holds all the fields, properties, and methods of the type. 
9. What does ref do?
    + ref is the keyword used to reference a value type that is contained in a method. 
10. What does out do?
    +  when pass it to a method the method must assign a value to it before it finishes or returns
11. Describe boxing and unboxing in your own words.
    + boxing copies a variable from the stack and stores a memory address on the heap. unboxing takes that variable off the heap and on to the stack.
12. What does cast do?
    + specifies a type to the compiler.
