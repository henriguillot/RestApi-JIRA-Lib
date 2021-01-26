## Routine (method) : GetAllUsers()
 
1. Get All Jira user's username (from all groups)
2. Store the list in several  files :  ( one file of username list per each group)  List--users-from-group-.json & List-all-users-from-group .txt
3. Returns a list of objects (objects of type Group) List<Group>

![alt text](https://github.com/guihen01/RestApi-JIRA-Lib/blob/main/GetAllUsers/Capture-1.PNG "Logo Title Text 1")

# Inplementation

1. This method is part of a Library of jira routines (Jira methods) based on REST API
2. Included in JiraLib.dll
3. used to extract or to get informations on Jira server, Jira users, Groups, and so on ......
4. is used with C# code 

 # How to use it 
 
![alt text](https://github.com/guihen01/RestApi-JIRA-Lib/blob/main/GetAllUsers/Capture-2.PNG "Logo Title Text 1")

# Publication

Package distributed as a nuget package at : https://www.nuget.org/packages/RestAPI-JIRA-Lib/

Is distributed as a .DLL library file

# Dependency 

1. package JiraLib : JiraLib.DLL
2. package Newtonsoft.Json;   

https://github.com/guihen01/RestApi-JIRA-Lib/blob/main/nuget%20packages%20needed.PNG
![alt text](https://github.com/guihen01/RestApi-JIRA-Lib/blob/main/nuget%20packages%20needed.PNG  "Logo Title Text 1")

# How to use

1. using JiraLib             in you project, reference this package   
2. using Newtonsoft.Json;  ;  in your project,  reference this package
# 
