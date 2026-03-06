# Password Manager
(WIP) A simple password manager for my first C# WinForms project

IMPORTANT: The software is not secure so do not store real passwords. Passwords are currently stored in 
plaintext (.csv) file. They will soon be hashed once I add all basic functionality.

Please also note that if you are runnning the code, you may have to change the filePath variable for the 
correct path for test.csv, but it should work. Currently, there are multiple instances where I use the filepath,
and I'm yet to create a centralised file path variable somewhere...

## Future plans
Currently, there is very little validation in the code. This is because **I am getting the main functionality
sorted** (add, remove, change, view login) before any validation or other improvements.

When a change is made and the user returns to the main form, the changes are not shown until the application re-runs.
This will be fixed in the future.

The solution structure will also be reorganised at some point to give more centralised functions & constants that 
can be used accross the different forms (e.g. having a seperate database management class which is referred to,
instead of having all the functionality in the events methods)
