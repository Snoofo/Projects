/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #2
* Full Name        : Stefan Mazaleigue
* Student Number   : S3507371
* Start up code provided by Paul Miller
***********************************************************************/

#include "helpers.h"
#include "shared.h"
#ifndef COMMAND_H
#define COMMAND_H

#define DECIMAL 10
#define CMD_DELIM "/"
#define MAX_TOK_LEN 100
#define MAX_TOKS 4
#define DEL_NUM 2
#define INS_NUM 3
#define INBEF_NUM 3
#define INAFT_NUM 3
#define INBET_NUM 4

/**
 * the different kinds of commands available in the system - these are also
 * array indices that can be used to refer to each type of command in the
 * global array of filters.
 **/
enum command_type
{
        CMD_DELETE_LINE,
        CMD_INSERT_LINE,
        CMD_INSERT_BEFORE,
        CMD_INSERT_AFTER,
        CMD_INSERT_BETWEEN,
        CMD_INVALID
};
/**
 * the struct that will be passed into the various functions that provided
 * details on the command being used. Currently this is rather bare. You
 * will want to add variables to this struct to represent the various parameters
 * that need to be passed into a command - in most cases these are likely to be
 * char pointers.
 **/
struct command
{
        enum command_type type;
        char * first_arg;
        char * second_arg;
        char * third_arg;
};

enum command_type command_type(const char*);
BOOLEAN check_valid_cmd(enum command_type);
struct command * create_command(char *);
BOOLEAN create_cmd_del(struct command *, char **);
BOOLEAN create_cmd_insert(struct command *, char **);
BOOLEAN create_cmd_inbef(struct command *, char **);
BOOLEAN create_cmd_inaft(struct command *, char **);
BOOLEAN create_cmd_inbet(struct command *, char **);
void command_free(struct command *);
#endif
