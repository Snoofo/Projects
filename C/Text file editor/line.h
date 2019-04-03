/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #2
* Full Name        : Stefan Mazaleigue
* Student Number   : S3507371
* Start up code provided by Paul Miller
***********************************************************************/

#include "helpers.h"
#include "shared.h"
#include "io.h"
#include <stdlib.h>
#include <string.h>
#include <errno.h>
#include <assert.h>

#ifndef LINE_H
#define LINE_H

/* The definition of a line - a pointer to char that holds the string and a
 * size_t variable that holds the length. Holding the length means we don't have
 * to call strlen which can take a while particularly for long strings */
struct line
{
        char* string;
        size_t len;
};

/* declare the function prototypes for allocating, management and freeing lines
 */

struct line * line_create(char *);
/*
BOOLEAN line_add(struct list *, struct line *);
BOOLEAN line_delete(struct list *, struct line *);
*/
void line_free(struct line *);
#endif
