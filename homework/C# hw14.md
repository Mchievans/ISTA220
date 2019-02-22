# C# Homework 14

## chapter 14 Working with Inheritance

### Name: Malachi Evans

#### file: C#hw14

#### date: February 19, 2019

------------------------------

1. What is the diﬀerence between a managed resource and an unmanaged resource?
    + Managed by the CLR unmanaged linked file connections and 
2. When is memory for an object (reference type) allocated? When is the memory deallocated?
    + when the new keyword is used, when they variable goes out of scope.
3. What is a destructor?
    + a method that the CLR calls after the reference to an object disappears 
4. What is the diﬀerence in syntax between a constructor and a destructor?
    + a tilde ~ AND A DESTRUCTOR Can’t take parameters.
5. Give some examples of scarce resources. Why would you want to manage scarce resources?
    + memory, database connections, and file handles. All are limited to a certain amount.
6. What is exception-safe disposal?
    + using a disposal method in a finally block, disposal will happen no matter what.
7. How do you think that the using statement works for resource management? Give an informal, English language, explanation of how it works.
    + using creates its own scope and limits whatever is created to the scope of the method.
8. What ill eﬀects could result from attempting to dispose of a resource more than once?
    + It may throw an exception.
9. We will look at threads later in the term. For now, what is your understanding of how threads interact with resource management? A good guess is a suﬃcient answer to this question.
    + A thread is defined as the execution path of a program.
10. Why does the book recommend not attempting to force the garbage collector? Are there any exceptions to this recommendation?
    + you may lose data.
