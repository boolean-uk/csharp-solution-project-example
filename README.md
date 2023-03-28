# C# Solution Project Example

## Learning Objectives
- to understand projects and solutions in c#

## Solution Layout
A solution is a useful way of grouping projects.   A companys codebase could reside in a single solution or multiple solutions.  Those solutions may have single or many projects in them!  There is no right or wrong way of laying out a solution and projects.  I have seen solutions with single projects or solutions that contain 30 plus projects.  
Usually the solution/project layout is right at the time it was written, however if a company changes (growing, merging etc), sometimes the solution might evolve.


![](./images/BBI_solution.JPG)

Imagine Bobs Bagels Inc was once a small firm and you wrote some software for the Marketing team.  You might only have one project   
called BobsBagelsInc.Marketing  in the BobsBagelsInc solution.  Now imagine the company expands across europe and a new european markinging team want some apps buit.  You may well create some code in a project called BobsBagelsInc.Europe.Marketing  
Now imagine the IT Department needs code to access the Oracle database or a new PostgreSQL database.  They could be in two seperate projects?  or should you put all database code in a single project?

## Sharing Code Between Projects - References
The whole point of multiple projects in a solution is the ability to share code.  Imagine you are the C# dev for Bobs Bagels Inc.   Finance come to you with some changes to their finance application which is a legacy app written in VB back in 1999 on Windows ME.  As you can see in the image, the project has been added to the solution.  And its a different language!  Solutions give us the ability to do this.  
The image below shows how the **BobgsBagels.Finance.LegacyApp** written in VB has a **reference** to the **BobsBagelsInc.ITDepartment.Database.PostgreSQL** project which is a current project written in C#.  The VB LegacyCode.vb can now do somethings to our current database by calling the new code.  Itis creating a new instance of the PostgreSQLDataAccess and calling the **DoSomethingWithCompanyDatabase()** method.  You can write some basic VB to call the C# but write the majority of new code in c#?

Don't worry.  We won't be covering VB in this course. :-)

![](./images/BBI_project_references.JPG)

Couple of interesting points here.  

Note the imports statement at the top of of the VB page.  This is importing the **Namespace** which is the project name in our case.  It is generally good practice to name your projects in this way to make it clear what code you would expect/put in each project.  

The other thing worth noting is how in the **BobsBagelsInc.ITDepartment.Database.PostgreSQL** class named **PostgresSqlDataAccess.cs** 
```
  public void DoSomethingWithCompanyDatabase()
  {

      //do something with company database 



      /*

      I would imagine we would write something here 
       to update some records in the database 

      */
  }
```
See the /// <sumary>  line  and how this line is closed with a /// </summary>   ?
This is an XML comment.  This is how we can write some information about the code and what it does.  Wherever we reference and call this method, Visual Studios intellisense will show this comment, telling us what the code does.
Other ways of writing comments appear within the method itself.
