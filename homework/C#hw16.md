# C# Homework 16

## chapter 16 Handling Binary Data and Using Indexers

### Name: Malachi Evans

#### file: C#hw16

#### date: February 25, 2019

------------------------------
1. Give five examples (using valid C# code) of the five bitwise operators listed in the text.
   + int Result = (shortIntA << 16 ) left shift operator
   + (A ^ B) = 49, 
   + int result = // Set User Permissions to 1010 0010| 1000
    User.Permissions = SecurityLevel.SuperUser | SecurityLevel.AnswerAdmin;
   + (A & B) = 12
   + (~A ) = 61
2. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valid
C# code.
   + (IT HALFS THE VALUE) 
   + Yes 
   + int value1 = 99999999;
        for (int i = 0; i < 32; i++)
        {
            int shift = value1 >> i;
            Console.WriteLine("{0} = {1}",
3. Explain in detail this code: bits & (1 << index);.
   + it sets the position of the varible zero in the index to the one position.
4. Explain in detail this code: bits |= (1 << index);.
   + ACTS AS GETTER
   + sets the position of the index varinale to to one.
5. Explain in detail this code: bits &= (1 << index);.
   + acts AS SETTER.
   + it check both the index and of bits and .......
6. How does C# interpret this? bool peek = bits[n];
   + peek equals one or zero as a bool if bits n is a a one or zero true or false.
7. How does C# interpret this? bits[n] = true;
   + 1
8. How does C# interpret this? bits[n] ^= true;
   + 11 or 00
9. Assume that users were assigned read, write, and execute permissions according to this scheme: read
= 1, write = 2, execute = 4. How would you interpret the following user permissions:
(a) permission = 0
(b) permission = 1
(c) permission = 2
(d) permission = 3
(e) permission = 4
(f) permission = 5
(g) permission = 6
(h) permission = 7
   + chmod EACH   value evalutate to a  binary that can be evaluated against collection 
10. Answer the previous question by converting the decimal permissions into binary permissions. What
does this tell you about using this shceme of permissions?
+ it is limited to expansion