/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #2
* Full Name        : Stefan Mazaleigue
* Student Number   : S3507371
* Start up code provided by Paul Miller
***********************************************************************/

#include "shared.h"
#include <stdarg.h>
#include <stdio.h>
#ifndef IO_H
#define IO_H

/* the extra chars appended at the end of a line read in with fgets */
#define EXTRACHARS 2
/* predeclare structures that we need pointers to in the function prototypes */
struct line_list;
struct line_list* load_file(const char*);
void display_cmd_line_error(void);
void display_mem_fail(void);
void display_invalid_cmd(char *);
void display_invalid_arg(void);
void display_invalid_int(char *);
void display_line_not_found(int);
int print_error(const char*, ...);
int print_message(const char*, ...);
BOOLEAN save_file(const char[], struct line_list* list);
#endif
