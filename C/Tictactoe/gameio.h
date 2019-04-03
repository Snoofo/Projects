/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #1 
* Full Name        : EDIT HERE
* Student Number   : EDIT HERE
* Start up code provided by Paul Miller
***********************************************************************/

#include <ctype.h>
#include <limits.h>
#include <stdarg.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <errno.h>

#include "gameboard.h"
#include "shared.h"

/**
 * The role of this module is to provide a single place where all input and 
 * output is performed from. The reason for doing this is firstly consistency
 * of input and output but also if we decided to change the way we are doing
 * input and output (such as the implementation of a graphical user interface,
 * we would only need to change this module). 
 **/

#ifndef GAMEIO_H
#define GAMEIO_H

/* the default line length is 80 chars */
#define LINELEN 80
/* trailing characters in a valid string returned from fgets() */
#define EXTRACHARS 2
#define DECIMAL 10

/**
 * Add below the function prototypes for the public functions available from 
 * gameio.c. 
 **/

void readLine();
void read_rest_of_line();
void invalid_input();
void menu_invalid();
void board_invalid();
void nums_to_win();
void out_of_range();
void not_an_int();
void players_name();
void display_main_menu();
void display_board_selection();
void display_quit_request();
void draw_line(int length);
void display_gameboard();
void prompt_move();
void invalid_coord();
void invalid_board_dim(int x, int y);
void invalid_move(int x, int y);
void display_winner();
void display_draw();
void display_computer_move();

int stringToInt();
int quit_checker();
int init_board_dimensions();
int init_num_to_win();
int print_error(const char format[], ...);
int print_message(const char format[], ...);
#endif /* GAMEIO_H */
