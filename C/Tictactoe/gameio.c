/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #1 
* Full Name        : EDIT HERE
* Student Number   : EDIT HERE
* Start up code provided by Paul Miller
***********************************************************************/

#include "gameio.h"
#include "game.h"

/* format for displaying main menu */
void display_main_menu(void)
{
    printf("Welcome to tictactoe\n");
    printf("--------------------\n");
    printf("1) Play Game\n");
    printf("2) Exit\n");
    printf("Please enter your choice: ");
}

/* format for displaying board selection menu */
void display_board_selection(void)
{
        printf("You can play tictactoe on a 3x3 board or a 5x5 board.\n");
        printf("Do you want to play on a board the width of 3 or 5? ");
}

/* format for displaying quit confirmation message */
void display_quit_request(void)
{
    printf("Are you sure you wish to quit the program? (y/n): ");
}

void menu_invalid(void)
{
    print_error("%s", "Invalid entry. Please select 1 or 2\n");
}

void invalid_input(void)
{
    print_error("%s", "Invalid entry. Try again\n");
}

void board_invalid(void)
{
    print_error("%s", "Invalid entry. Please select 3 or 5\n");
}

void nums_to_win(void)
{
    printf("How many pieces in a row are required to win? ");
}

void out_of_range(int input)
{
    print_error("%d%s", input, " is not within the allowed range for a number to win\n");
}

void not_an_int(char input[])
{
    print_error("%s%s", input, " is not a valid integer\n");
}

void players_name(void)
{
    printf("Please enter the name for the human player: ");
}

void prompt_move(char name[], enum token tok)
{
	printf("Enter the move for %s whose token is %c: ", name, token_chars[tok]);
}

void invalid_coord(char input[])
{
    print_error("%s is not a valid coordinate\n", input);
}

void invalid_board_dim(int x, int y)
{
    print_error("%d,%d is not a valid board dimension\n", x, y);
}

void invalid_move(int x, int y)
{
    print_error("%d,%d is not a valid move, please try again\n", x, y);
}

void display_winner(struct game *thegame)
{
	print_message("%s is the winner!\n", thegame->current->name);
}

void display_draw()
{
	print_message("The game was a draw!\n");
}

void display_computer_move(int coordx, int coordy)
{
	print_message("Computer's move was %d,%d\n", coordy, coordx);
}

/* reads a line with fgets() into an array */
void readLine(char input[], int length)
{
	if (fgets(input, length + FGETSPACE, stdin) == NULL)
	{
		input[0] = 0;
		return;
	}
	else
	{
		if (input[strlen(input) - 1] != '\n')
		{
			read_rest_of_line();
		}
	}
}

/* converts a string to integer */
int stringToInt(char input[], int length)
{
    int retval;
    char *output;
    readLine(input, length);
    if (strlen(input) == 1)
    { 
        return 0;
    }
    input[strlen(input)-1] = 0;
    retval = strtol(input, &output, DECIMAL);
    if (*output != '\0')
    {
        not_an_int(input);
        return -2;
    }
    return retval;
}

/* function that request confirmation for quitting */
int quit_checker()
{
    char string[MENU_INPUT];
    while (display_quit_request(), readLine(string, MENU_INPUT), string != NULL)
    {       
        if (strlen(string) > 2 || string == NULL)
        {
            print_error("%s", "line entered was too long. Please try again\n");
            continue;
        }
        else if (string[0] == 'y' || string[0] == 'Y')
        {
            print_message("%s", "Quitting...\n");
            return 1;
        }
        else
        {
            print_message("%s", "Not quitting...\n");
            return 0;
        }
   }
   return 0;
}

int init_board_dimensions(void)
{
	char input[MENU_INPUT];
	int board_dimensions;
	while (display_board_selection(),
		board_dimensions = stringToInt(input, MENU_INPUT),
		(char)board_dimensions != EOF)
	{
		if (board_dimensions == 0)
		{
			if (quit_checker())
			{
				return board_dimensions;
			}
			else
			{
				continue;
			}
		}
		else if (board_dimensions != MIN_BOARD && board_dimensions != MAXWIDTH &&
			board_dimensions != -2)
		{
			board_invalid();
			continue;
		}
		else if (board_dimensions == 3 || board_dimensions == 5)
		{
			return board_dimensions;
		}
	}
    return board_dimensions;
}

int init_num_to_win(int board_dimensions)
{
	char input[MENU_INPUT];
	int num_to_win;
	if (board_dimensions == MAXWIDTH)
	{
		while (nums_to_win(),
			num_to_win = stringToInt(input, MENU_INPUT),
			(char)num_to_win != EOF)
		{
			if (num_to_win == 0)
			{
				if (quit_checker())
				{
					return num_to_win;
				}
				else
				{
					continue;
				}
			}
			else if (num_to_win == -2)
			{
				continue;
			}
			else if (num_to_win < MININROW || num_to_win > MAXINROW)
			{
				out_of_range(num_to_win);
				continue;
			}
			else
			{
				break;
			}
        }
	}
	else if (board_dimensions == MIN_BOARD)
	{
		num_to_win = MIN_BOARD;
	}
	return num_to_win;
}
/**
 * function that performs buffer clearing when you detect that too much input
 * has been entered. Have a look at the course examples to see how to use this
 * function correctly. Understanding of the operation of buffering is essential
 * to understanding input and output in C and there is a lot of misunderstanding
 * of this topic. If you struggle with this, please ensure that you ask lots of 
 * questions.
 **/
void read_rest_of_line(void)
{
        int ch;
        while (ch = getc(stdin), ch != '\n' && ch != EOF)
                ;
        clearerr(stdin);
}


/**
 * this function provides a printf like interface for you to use to print out
 * error messages from your program. You provide the format specifier as the
 * first argument followed by any other arguments. It does some minor formatting
 * such as prepending "Error: " to all your error messages which is required
 * for my tester of your program
 **/
int print_error(const char format[], ...)
{
        int numchars;
        va_list arg_list;
        numchars = fprintf(stderr, "\nError: ");
        /* retrieve the argument list */
        va_start(arg_list, format);
        /* pass the argument list to vprintf */
        numchars += vfprintf(stderr, format, arg_list);
        /* stop processing the argument list */
        va_end(arg_list);
        return numchars;
}

void display_board_header(int board_dim)
{
	int count;
	printf("   |");
	for (count = 0; count < board_dim; ++count)
	{
		printf(" %d |", count + 1);
	}
	printf("\n");
	draw_line(board_dim);
}

/**
 * displays the game board for the game. The game board array itself it the
 * same size regardless of the official board_dimension but it only draws a
 * board sufficient to draw the game state's board.
 **/
void display_board(struct game* thegame)
{
	int county, countx;
	display_board_header(thegame->board_dimension);
	for (county = 0; county < thegame->board_dimension; ++county)
	{
		printf(" %d |", county + 1);
		for (countx = 0; countx < thegame->board_dimension; ++countx)
		{
			printf(" %c |", token_chars[thegame->board[county][countx]]);
		}
		printf("\n");
		draw_line(thegame->board_dimension);
	}
}

void draw_line(int length)
{
	int count;
	for (count = 0; count < length; ++count)
	{
		printf("----");
	}
	printf("----\n");
}

/**
 * function to allow you to print out general informational messages
 **/
int print_message(const char format[], ...)
{
        /* print out a leading info tag */
        int numchars = printf("%s", "\nInfo: ");
        /* extract the data passed from the ... and pass it into printf */
        va_list arg_list;
        va_start(arg_list, format);
        numchars += vprintf(format, arg_list);
        va_end(arg_list);
        /* return the number of chars printed consistent with the printf
         * interface */
        return numchars;
}

