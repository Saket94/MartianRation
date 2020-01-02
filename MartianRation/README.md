# Project Name: MartianRation

I had provided the entire MartianRation project to download with Sql server Script which contains tables, which are used in the preoject. 
This project is build using 3-tier architecture as mentioned below layers:-
	1.MartianRation.Data :- This is the data layer which consists the edmx and data models.Its reference is given inside the MartianRation.Code layer.
	2.MartianRation.Code :- This is the business layer which consists the project logic.
	3.MartianRation :- This is the presentation layer which contains the layer which is visible to the user.

##Database Part:

1.First things to do is to Create Database, an scripts file is placed inside the "DbScripts" folder in the "MartianRation" project solution with 
  name "DBScripts_Part1.sql" and "DBScripts_Part2.sql".

2.Open these above Scripts file in the SQL server management studio and execute the DBScripts_Part1.sql script, then DBScripts_Part2.sql script. 

3.This execution of script will automatically create the database with name "MartianRationDB" and associated tables along with data inside this database.

4.After Creating Database now make changes for the ConnectionStrings in Web.Config file which is residing within project solution.

5.Change this connectionStrings to your Own Data Source with Sql UserName and Password.

##Modify Connection String from the below mentioned places

1.MartianRation
  From the "MartianRation" solution change the connection string from the web.config file.

2.MartianRation.Data
  a.From the "MartianRation.Data" solution change connection string from App.config file.
  b.Change the data source,user id and password according to your sql credentials.

2.MartianRationUnitTestProject
  a.From the "MartianRationUnitTestProject" solution change connection string from App.config file.
  b.Change the data source,user id and password according to your sql credentials.
  <connectionStrings>
    <add name="MartianRationDBEntities" connectionString="metadata=res://*/Edmx.MartianRationDataModel.csdl|res://*/Edmx.MartianRationDataModel.ssdl|res://*/Edmx.MartianRationDataModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=10.10.10.113;initial catalog=MartianRationDB;user id=sa;password=cis1234;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>

##Domain Driven Document

We also have placed the domain driven diagram inside the "MartianRation" project solution with name "Domain_Driven_Code_Structure_Documentation.docx".

##MartianRationUnitTestProject Project
1.If any error occur while executing the unit test cases, then check the properties of all the .xml files.
2.If "Copy to Ouput Directory" is not set to "Copy if newer" then make it "Copy if newer".




