/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #1 
* Full Name        : Stefan Mazaleigue
* Student Number   : S3507371
* Start up code provided by Paul Miller
***********************************************************************/

#include "main.h"
#include "shared.h"

#define ERROR "Error: "
/**
 * entry point for the system to run your code. Please take the comments below 
 * as hints for the code you need to write in this function.
 **/

int main(void)
{
        /* loop until the user decides to quit */
                /* display the menu */
                /* get the user's selection of option to run */
                /* execute the user's option and if that is to quit, set the 
                 * appropriate variable for exiting or exit directly */
    
    int input;
    char string[] = { 'a', '\n' };
    /* main menu loop */
    while (display_main_menu(),
        input = stringToInt(string, MENU_INPUT),
        input != EOF)
    {
        if (input == 0)
        {
            invalid_input();
            continue;
        }
        else
        {
            /* start game */
            if (input == 1)
            {
                play_game();
            }
            /* exit game */
            else if (input == 2)
            {
                break;
            }
            /* invalid entry */
            else if (input > 2)
            {
                menu_invalid();
            }
        }       
    }
    return EXIT_SUCCESS;
}

