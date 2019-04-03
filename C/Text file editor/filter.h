/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #2
* Full Name        : Stefan Mazaleigue
* Student Number   : S3507371
* Start up code provided by Paul Miller
***********************************************************************/

#include "command.h"
#include "line_list.h"
#include <ctype.h>
#include <time.h>
#ifndef FILTER_H
#define FILTER_H
#define NUM_COMMANDS 5
/* the definition of a filter - it is a function that returns a struct line list
 * pointer and takes as parameters a line_list struct pointer and the command -
 * which holds the array index for the filter to call and pointers to each
 * element that is required for all the commands */
typedef struct line_list* (*filter)(struct line_list*, struct command*);

/* global array of filters */
extern const filter filters[];

/* the actual implementation of each of the filters */
struct line_list* flt_delete_line(struct line_list*, struct command*);
struct line_list* flt_insert_line(struct line_list*, struct command*);
struct line_list* flt_insert_before(struct line_list*, struct command*);
struct line_list* flt_insert_after(struct line_list*, struct command*);
struct line_list* flt_insert_between(struct line_list*, struct command*);
#endif
