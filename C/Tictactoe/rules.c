/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #1 
* Full Name        : EDIT HERE
* Student Number   : EDIT HERE
* Start up code provided by Paul Miller
***********************************************************************/

#include "rules.h"
#include "game.h"

/**
 * defines whether a game is over. I handle all boards in the same way using
 * constants and variables that have been designed for the game
 **/
struct game_state get_game_state(struct game* thegame)
{
	int token_count = 0;
	int countx, county;
	struct game_state cur_game_state = { ONGOING, NULL, NULL };
	for (countx = 0; countx < thegame->board_dimension; ++countx)
	{
		for (county = 0; county < thegame->board_dimension; ++county)
		{
			if (thegame->board[countx][county] != EMPTY)
			{
				++token_count;
				if (thegame->board[countx][county] == thegame->current->token)
				{
					if (num_in_line(thegame, countx, county, thegame->current->token)
						>= thegame->num_in_row)
					{
						cur_game_state.state = WON;
						cur_game_state.winner = thegame->current;
						cur_game_state.loser = thegame->other;
						return cur_game_state;
					}
				}
			}
		}
	}
	if (token_count == thegame->board_dimension * thegame->board_dimension)
	{
		cur_game_state.state = DRAW;
	}
	return cur_game_state;
}

int num_in_line(struct game *thegame, int x, int y, enum token tok)
{
	int win_count = 1;
	BOOLEAN found_left = FALSE;
	BOOLEAN found_right = FALSE;
	struct coordinate left_coord;
	struct coordinate right_coord;
	left_coord.x = x;
	left_coord.y = y;
	right_coord.x = x;
	right_coord.y = y;

	do
	{
		if (!left_coord.x -1 < 0 && !left_coord.y -1 < 0)
		{
			if (thegame->board[left_coord.x - 1][left_coord.y - 1] == tok)
			{
				++win_count;
				--left_coord.x;
				--left_coord.y;
				found_left = TRUE;
			}
			else
			{
				found_left = FALSE;
			}
		}
		else
		{
			found_left = FALSE;
		}
		if (!right_coord.x +1 > thegame->board_dimension - 1 &&
			!right_coord.y +1 > thegame->board_dimension - 1)
		{
			if (thegame->board[right_coord.x +1][right_coord.y +1] == tok)
			{
				++win_count;
				++right_coord.x;
				++right_coord.y;
				found_right = TRUE;
			}
			else
			{
				found_right = FALSE;
			}
		}
		else
		{
			found_right = FALSE;
		}
	} while (found_left || found_right);
	if (win_count >= thegame->num_in_row)
	{
		return win_count;
	}

	win_count = 1;
	left_coord.x = x;
	left_coord.y = y;
	right_coord.x = x;
	right_coord.y = y;
	do
	{
		if (!left_coord.x -1 < 0)
		{
			if (thegame->board[left_coord.x -1][left_coord.y] == tok)
			{
				++win_count;
				--left_coord.x;
				found_left = TRUE;
			}
			else
			{
				found_left = FALSE;
			}
		}
		else
		{
			found_left = FALSE;
		}
		if (!right_coord.x +1 > thegame->board_dimension - 1)
		{
			if (thegame->board[right_coord.x + 1][right_coord.y] == tok)
			{
				++win_count;
				++right_coord.x;
				found_right = TRUE;
			}
			else
			{
				found_right = FALSE;
			}
		}
		else
		{
			found_right = FALSE;
		}
	} while (found_left || found_right);
	if (win_count >= thegame->num_in_row)
	{
		return win_count;
	}

	win_count = 1;
	left_coord.x = x;
	left_coord.y = y;
	right_coord.x = x;
	right_coord.y = y;
	do
	{
		if (!left_coord.x -1 < 0 && !left_coord.y +1 > thegame->board_dimension -1)
		{
			if (thegame->board[left_coord.x - 1][left_coord.y +1] == tok)
			{
				++win_count;
				--left_coord.x;
				++left_coord.y;
				found_left = TRUE;
			}
			else
			{
				found_left = FALSE;
			}
		}
		else
		{
			found_left = FALSE;
		}
		if (!right_coord.x +1 > thegame->board_dimension - 1 &&
			!right_coord.y -1 < 0)
		{
			if (thegame->board[right_coord.x + 1][right_coord.y -1] == tok)
			{
				++win_count;
				++right_coord.x;
				--right_coord.y;
				found_right = TRUE;
			}
			else
			{
				found_right = FALSE;
			}
		}
		else
		{
			found_right = FALSE;
		}
	} while (found_left || found_right);
	if (win_count >= thegame->num_in_row)
	{
		return win_count;
	}

	win_count = 1;
	left_coord.x = x;
	left_coord.y = y;
	right_coord.x = x;
	right_coord.y = y;
	do
	{
		if (!left_coord.y -1 < 0)
		{
			if (thegame->board[left_coord.x][left_coord.y -1] == tok)
			{
				++win_count;
				--left_coord.y;
				found_left = TRUE;
			}
			else
			{
				found_left = FALSE;
			}
		}
		else
		{
			found_left = FALSE;
		}
		if (!right_coord.y +1 > thegame->board_dimension -1)
		{
			if (thegame->board[right_coord.x][right_coord.y +1] == tok)
			{
				++win_count;
				++right_coord.y;
				found_right = TRUE;
			}
			else
			{
				found_right = FALSE;
			}
		}
		else
		{
			found_right = FALSE;
		}
	} while (found_left || found_right);
	return win_count;
}

/**
 * tests if a move is valid and if it is then it applies the move to the
 * gameboard and otherwise it returns FALSE
 **/
BOOLEAN apply_move(struct game* thegame, const struct coordinate* coord)
{
        if (coord->x > thegame->board_dimension ||
            coord->y > thegame->board_dimension ||
            coord->x < 1 || coord->y < 1)
        {
			if (thegame->current->type == HUMAN)
			{
				invalid_board_dim(coord->x, coord->y);
			}
            return FALSE;
        }
        if (thegame->board[coord->y-1][coord->x-1] != EMPTY)
        {
			if (thegame->current->type == HUMAN)
			{
				invalid_move(coord->x, coord->y);
			}
            return FALSE;
        }
        else
        {
            thegame->board[coord->y-1][coord->x-1] = thegame->current->token;
            return TRUE;
        }
        return FALSE;
}

void init_turn(struct game* thegame)
{
    int current;
    current = rand() % NUM_PLAYERS;
    if (current == 0)
    {
        thegame -> current = &thegame -> players[0];
        thegame -> other = &thegame -> players[1];
    }
    else
    {
        thegame -> current = &thegame -> players[1];
        thegame -> other = &thegame -> players[0];
    }
}

void init_rand(void)
{
    srand(time(NULL));
}
