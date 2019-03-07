# C# Homework 09

## chapter 9 Creating Value types with enumerations and structures

### Name: Malachi Evans

#### file: C#hw09

#### date: February 05, 2019

------------------------------

1. Declare an enum for military ranks, either oﬃcer or enlisted. Name it Ranks. What are the symbols, like Private, PFD, Corporal, or 1stLt, 2ndLt, Capt?
    + enum ranks {private, specialist, sergeant, staffSergeant , sergeantFirstClass, masterSergeant, firstSergeant = masterSergeant, sergeantMajor}
2. Using the Ranks enum, assign a rank to yourself or a friend.
    + rank malachi = rank.sergeant;
3. Determine the numeric index of particular ranks, using the Ranks enum.
    + enum ranks {private = 3, specailist, sergeant,staffSergeant , sergeantFirstClass, masterSergeant,firstSergeant = masterSergeant, sergeantMajor}
4. How do you select the type of an enum?
    + place the specified integer type before braces and legal values so enum ranks: byte {}
5. Are structs stored on the stack or on the heap? What about enums?
    + structures are stored on the stack. enumerations are stored on the stack, they are a value type.
6. Declare a struct named DOD with four branches.
    + struct Dod
        {
            private short army, navy, marines, airforce;
        }
7. Why can’t you create a default constructor for a struct?
    + a default value is already assigned to a struct.
8. What is CIL? What does the CLR do to the CIL?
    + Common intermediate language complier converts c# into cil and then the common language runtime is what converts the cil and calls on the aps from win32 or winrt to interact with the machine to process
