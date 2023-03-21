# C# Solution Project Example

## Solution Layout
![](./images/BBI_solution.JPG)

.Net Solutions are a useful way of grouping up a few projects which may cover codebase for a whole company or just a specific project.  I have seen solutions  
with single projects or solutions that contain 30 plus projects.

There is no right or wrong way of laying out a solution and projects inside them.  If a company changes (growing, merging etc), sometimes it might make sense to reflect this in the solution.  
For example, imagine Bobs Bagels was once a small firm and you wrote some software for the Marketing team.  You might only have one project   
called BobsBagelsInc.Marketing  in the BobsBagelsInc solution.  Now imagine the company expands across europe and a new markinging team want some apps buit.  You may well create some code in a project called BobsBagelsInc.Europe.Marketing .  You can still access the code in the BobsBagelsIc.ITDepartment.Database.Oracle


## Sharing Code Between Projects
One benefit of having multiple projects inside a solution is the ability to share code.  Imagine you are the C# dev for Bobs Bagels Inc.   Imagine finance come to you with some changes to their finance application which is a legacy app written in VB a few years ago.  As you can see in the image, the project has been added to the solution.  And its a different language!  Solutions give us the ability to do this.  
The image below shows how the BobgsBagels.Finance.LegacyApp written in VB has a reference to the BobsBagelsInc.ITDepartment.Database.PostgreSQL project which is a current project written in C#.  The VB LegacyCode.vb can now do somethings to our current database by calling the new code.  Itis creating a new instance of the PostgreSQLDataAccess and calling the DoSomethingWithCompanyDatabase method.  You can write some basic VB to call the C# but write the majority of new code in c#?

Don't worry.  We won't be covering VB in this course. :-)

![](./images/BBI_project_references.JPG)
