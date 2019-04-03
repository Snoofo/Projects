/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #2
* Full Name        : Stefan Mazaleigue
* Student Number   : S3507371
* Start up code provided by Paul Miller
***********************************************************************/

#include "line.h"

/* implement the functions for allocation, management and freeing of lines
 */

/* function to create a line. Returns a new malloc'd line struct, the char* in
 * the struct is also malloc'd */
struct line * line_create(char * line)
{
        struct line * new;
        int length;

        length = strlen(line);
        new = malloc(sizeof(struct line));
        if (new == NULL)
        {
                display_mem_fail();
                return NULL;
        }
        memset(new, 0, sizeof(struct line));
        new->string = malloc((sizeof(char) * length) + 1);
        if (new->string == NULL)
        {
                display_mem_fail();
                return NULL;
        }

        strcpy(new->string, line);
        new->len = length;
        return new;
}

/* function to free a line struct including it's malloc'd char pointer */
void line_free(struct line * line)
{
        free(line->string);
        free(line);
}
