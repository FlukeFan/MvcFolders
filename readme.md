
[![Build Status](https://ci.appveyor.com/api/projects/status/github/FlukeFan/MvcFolders?svg=true)](https://ci.appveyor.com/project/FlukeFan/mvcfolders) <pre>

MvcFolders
==========

Some utility classes to help implement Feature Folders in a (pre core) MVC application.


Building
========

To build, open CommandPrompt.bat, and type 'b'.

Build commands:

b                               : build
b /t:clean                      : clean
b /t:RestorePackages            : Restore NuGet packages
b /t:setApiKey /p:apiKey=[key]  : set the api key
b /t:push                       : Push packages to NuGet and publish them (setApiKey before running this)
