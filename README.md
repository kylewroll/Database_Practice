Author: Kyle Rolland
Date: 2/20/2021
File: README.md
Description: Describes project, bugs, design decisions

This project is a simple dive into tying a database to a WPF application

It creates two buttons, each tied to a text box, that takes data from the database included with the program, and prints it out to the box. One button prints the Assets table, and the other button prints out the Employees table.

Since this was just some quick practice, there's nothing special about the application itself, I just created the buttons and the boxes and linked them, no fancy text, or background colors, or anything like that.

At first this project gave me some trouble, because I was trying to use data binding to update the text box's text, but after getting some sleep I realized that I literally just had access to the content of the boxes while in the button functions, so I use that to manually change the text content, and everything sorted itself out wihtout any issues. I also had some trouble getting the conection string, because I thought it had saved as something else, but I was wrong, and had to go back into the database wizard to find it, then add an extra backslash to tell the compiler that I needed the backslash character for the path to the database.

Other than these few things, the project went well, and I'm hoping that future database use can go as smoothly as this, because I think it would be helpful to utilize databases for our project for this semester.

I tried to work on implementing a button that added data to the database, and I think I got about halfway through, but I've had some bad experience with testing out different things (recently leading to things imploding, and me having to find a previous version to reload and restart from, which is a whole other fiasco in itself), so I decided to not push my luck, and stick with what I've got working, but from what I was looking at, an addition feature doesn't seem that much different from the reading command, just with a few more variables and steps.
