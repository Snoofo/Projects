/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #2
* Full Name        : Stefan Mazaleigue
* Student Number   : S3507371
* Start up code provided by Paul Miller
***********************************************************************/

#include "command.h"
#include "filter.h"
#include "line_list.h"
#include "shared.h"
#ifndef COMMAND_LIST_H
#define COMMAND_LIST_H

/**
 * The array list that holds the commands that are iterated over
 **/
struct command_list
{
        struct command** array;
        int num_commands;
        int total_commands;
};

struct command_list* extract_commands(int, char * []);
/* you will need to provide function prototypes for the allocation, management
 * and freeing a command line here */
struct command_list* create_cmd_list(int);
BOOLEAN command_list_add(struct command_list*, char *);
void command_list_free(struct command_list*);
#endif
