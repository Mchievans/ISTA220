# C# Homework 03

## chapter 3

### Name: Malachi Evans

#### file: C#hw03

#### date: January 15, 2019

1. What is a method?
    + A method is a named sequence of statements. a method have a name and a body

1. What does a return statement do?
    + a return statement is the keyword return followed by an expression that specifies the retuned value and a semicolon.

1. What is an expression bodied method?
    + it is a syntactic convenience, simplifying a method the use of a => operator instead of a return statement.  

1. What is the scope of a variable?
    + it is the when a variable can be accessed at a particular location in the program. The region where it is usable. The block where it is declared.

1. What is an overloaded method?
    + IT is when you give identifiers the same name so in the case of methods two with the same name but the implementations have different sets of parameters and different returns. Compiler distinguishes by the parameters when method is called.

1. How do you call a method that requires arguments?
    + place the arguments in the place of the parameters

1. How do you write a method, that is, specify the method de 
finition, that requires a parameter list?
    + you wite the methodname and the argumentlist methodname(arguementlist). you must specfiy varible type.

1. How do you specify a parameter as optional when defi 
ning a method?
    + use a void and do not supply a return value. In the method definition assign the varaiable in a parameter list a value making it optional.
    + EX: public static int getsum(int v1, int v2 =10)

1. How do you pass a argument to a method as a named parameter?
    + you specify the name of the argurment followed by a colon.

1. How do you return values from a method? Can you         return multiple values from a method, and if so,
    how?

   + you return vaules from a method by writeing a statment for a return value. you can return multiple values from a method by returning a tuple. you specfiy a list of types as part of the return portion of the method.
  
1. How does the compiler resolve an ambiguity between named arguments and optional parameters?
    + It doesnt compile it at all.
