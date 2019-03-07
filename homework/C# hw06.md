# C# Homework 06

## chapter 6

### Name: Malachi Evans

#### file: C#hw06

#### date: January 23, 2019

------------------------------

1. What is an exception?
    + an error Exceptions allow an application to transfer control from one part of the code to another.
2. What happens in a try block if the program executes without errors?
    + They all run one after another until completion.
3. How does the catch mechanism work for unhandled exceptions?
<<<<<<< HEAD
    + it loops back to the method then the caller an back to the try block and repeats then terminates. 
4. What happens in a program if an exception block fails to handle an particular error?
    + it goes back to the method and then caller, it trys to fin exception block in next higher level, if it cant find appropiate block then it ends.  
5. What is the parent class for all exceptions? How does this work?
    + exception 
6. How do you determine the type of an error?
    + you filter the exceptions using a boolean expression, the exception obeject has a propety that will give you the type.
7. What is the purpose of integer checking?
    + it checks the calcultions to make sure it didnt overflow(past maxium value using signed integers) and resut in the wrong answer integer checking will step in and say a mistake is made.
8. What does the ﬁnally block do?
    + it ensures a statement is run regardless if an exception is thrown.
=======
    + it loops back to the method then the caller a back to the try block and repeats then terminates. 
4. What happens in a program if an exception block fails to handle a particular error?
    + it goes back to the method and then caller, it tries to fin exception block in next higher level, if it can’t find appropriate block then it ends.  
5. What is the parent class for all exceptions? How does this work?
    + exception 
6. How do you determine the type of an error?
    + you filter the exceptions using a Boolean expression, the exception object has a property that will give you the type.
7. What is the purpose of integer checking?
    + it checks the calculations to make sure it didn’t overflow (past maximum value using signed integers) and result in the wrong answer integer checking will step in and say a mistake is made.
8. What does the ﬁnally block do?
    + it ensures a statement is run regardless if an exception is thrown.
>>>>>>> f5508fb2844c5c7742b5abd9271a6681a64f6a66
