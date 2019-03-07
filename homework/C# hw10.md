# C# Homework 10

## chapter 10 Using Arrays

### Name: Malachi Evans

#### file: C#hw10

#### date: February 06, 2019

------------------------------

1. What does an array look like in memory?
    +  a block of a collection of stored locations on memory.   
2. Where is memory allocated to hold an array, on the stack or on the heap?
    + the heap
3. Where is memory allocated to hold an array reference, on the stack or on the heap?
    + stack 
4. Can an array hoold values of diﬀerent types? This is a trick question, the answer is, “It depends.” 
    + yes differt value types same as varriable before (int array) or use an object to varry 
5. Describe the syntax of the condition or a foreach loop.
    + int[] intArray = new int[3]{ 10, 20, 30};

        foreach(var i in intArray)
        
        Console.WriteLine(i);   

6. How do you make a deep copy of a array?
    + create an array of the same type and length then copy from original to the new one.
7. What is the diﬀerence between a multi-dimensional array and an array of arrays?
    + multi-dimensional arrays have rows and columns where a value is held is defined by the two while an array of arrays does not.
8. How do you “ﬂatten” a multidimensional array? In other words, take something that looks like a matrix
    + iterate through the multi-dimensional array.
