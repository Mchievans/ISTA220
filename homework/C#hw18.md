# C# Homework 18

## chapter 18 using collections

### Name: Malachi Evans

#### file: C#hw18

#### date: March 04, 2019

------------------------------

1. You are building a help ticket system. You want to ensure that the older the ticket, the sooner it will be handled by the team. For example, a ticket submitted a week ago has a higher priority than a ticket just submitted. What kind of data structure would you use, and why?
    + a queue, first in first out
2. You are building a tracking system for seasonal agricultural farm labor. The labor requirements vary widely, depending on the season. Your requirement is that the newest hires are terminated first, and that our more experienced hires are kept longer. What kind of data structure would you use, and why?
    + stack becasue last in first out.
3. You are building a transaction database. Your requirement is that the database adds data very quickly, and that deletions, updates, and searches happen infrequently. In other words, data is typically added in the order in which the transaction occurs. What kind of data structure would you use, and why?
    + a list its added in the order in which tranacstions occur and doesnt need to be accessed quickly.
4. You are building an analytical database. Your requirement is that the database handle queries very quickly, but that the data never changes, i.e., there are no inserts, deletions, or updates. What kind of data structure would you use, and why?
    + dictionary its always sorted.
5. You are building a personnel directory, where searched are performed by last name, first name, middle name. What kind of data structure would you use, and why?
    + a dictionary, i can create two sets to store the names 
6. You are building a username/password database. Your requirement is that updates happen frequently (when users change their passwords) and that searches (to authenticate users) happenb extremely quickly. What kind of data structure would you use, and why?
    + a dictionary 
7. What is a lambda expression? Give an example. Why would we use a lambda expression?
    + a expression that returns a method to use as a predicate to return a boolean. search in a dictionary for a user name by name. 
8. What is the difference between lambda expressions and anonymous methods? What are the advantages of each?
    + anonoymous methios arent as flexible and must use delagates and doesnt have a name.  