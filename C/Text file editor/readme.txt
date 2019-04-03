	 ******* CPT220 - Programming in C
 *******
	 * Study Period 4 2017 Assignment #2
     *
	 * Full Name: Stefan Mazaleigue          *
	 * Student Number: S3507371              *
	 * Start up code provided by Paul Miller
 *
 	**************** READ ME ****************

### Description ###
This program is a utility to modify text files.
Command line arguments are used as instructions
on which to modify the file.
The file is then overwritten with the modified text.

### User Info ###
* A minimum of three command line arguments are needed and separated with a space
  - First argument: The executable name (main)
  - Second argument: The text file name to be modified
  - Third and any additional arguments: These are the commands
to be applied to the text file.
  - All command parameters are to be separated with the forwardslash character '/'
  - Any command parameters requiring a space character need to be encapsulated
in quotation marks e.g /" this is the replacement "/

# Command syntax:
  - command_name/cmd_first_argument/cmd_second_argument/cmd_third_argument

# Command acronyms:
  - 'dl' is the command_name to delete a line
    - It takes one addition parameter being the line number to delete
    - e.g dl/4

  - 'il' is the command_name to insert a line of text
    - It takes two addition parameters being the line number to insert at
and the string to insert e.g il/5/"insert this"

  - 'ia' is the command_name to insert a string after a specified string
    - It takes two addition parameters being the string to insert after
followed by the string to insert

  - 'ib' is the command_name to insert a string before a specified string
    - It takes two addition parameters being the string to insert before
followed by the string to insert
    - e.g ia/target/" practice"

  - 'ibt' is the command_name to insert a string between two other strings
    - It takes three additional parameters being the first two are the
strings to insert between and the last being the string to insert
    - e.g ibt/" this "/" that "/and

********************************************************************************