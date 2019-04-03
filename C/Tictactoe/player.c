/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #1 
* Full Name        : EDIT HERE
* Student Number   : EDIT HERE
* Start up code provided by Paul Miller
***********************************************************************/

#include "player.h"
#include "game.h"

/**
 * provides a mapping from tokens to chars for display
 **/
const char token_chars[NUMTOKENCHARS] = { ' ', 'O', 'X' };

/**
 * initialises a player based on user input and the game pointer passed into
 * the init_player function. We do this because there's no such thing as a
 * player outside of a game. If we did not do this we would have to pass thegame
 * into player every time we called a function in player.
 **/
void init_player(struct player* new_player, enum player_type type,
                 struct game* thegame)
{
    char player_name[NAMELEN];
    if (type == HUMAN)
    {
        while (players_name(),
            readLine(player_name, NAMELEN), player_name != NULL)
        {
            if (strlen(player_name) < 2)
            {
                if (quit_checker())
                {
                    new_player -> name[0] = '\0';
                    return;
                }
                else
                {
                    continue;
                }
            }
            else
            {
                player_name[strlen(player_name)-1] = 0;
                strcpy(new_player -> name, player_name);
                break;
            }
        }
    }
    else
    {
        strcpy(new_player -> name, "Computer");
    }
    new_player -> type = type;
    new_player -> thegame = thegame;
}

/**
 * This function handles turns for both human and computer players. 
 *
 * In all cases, display the state of the board first.
 * 
 * If this is a human player, prompt for their move validate it and if it 
 * is valid, apply it. If it is not valid, reprompt until a valid ove is 
 * entered.
 *
 * If this is a computer player, generate random x and y values for a move. Test
 * if the move is a valid move, apply it, otherwise try again generating a new
 * random x and y pair.
 **/
void take_turn(struct player* curplayer)
{
	char *tok;
    char *output;
	struct coordinate coord;
	BOOLEAN valid = TRUE;
	char coords[MOVE_INPUT];
    char coordsCopy[MOVE_INPUT];
	if (curplayer->type == HUMAN)
    {
			while (prompt_move(curplayer->name, curplayer->token),
				readLine(coords, MOVE_INPUT+1), coords != NULL)
			{
                coord.x = -1;
                coord.y = -1;
				if (strlen(coords) < FGETSPACE)
				{
					if (quit_checker())
					{
						curplayer->thegame->quit = TRUE;
						return;
					}
					else
					{
						continue;
					}
				}
                coords[strlen(coords)-1] = 0;
                strcpy(coordsCopy, coords);
                if (strlen(coords) < MOVE_INPUT)
                {
                    invalid_coord(coords);
                    continue;
                }
				tok = strtok(coords, DELIMS);
				while (tok != NULL)
				{
                    if (!isdigit(tok[0]))
                    {
                        invalid_coord(coordsCopy);
                        valid = FALSE;
                        break;
                    }
					if (coord.x < 0)
					{
						coord.x = strtol(tok, &output, DECIMAL);
					}
					else
					{
						coord.y = strtol(tok, &output, DECIMAL);
                        valid = TRUE;
					}
					tok = strtok(NULL, DELIMS);
				}
                if (valid)
                {
                    if (apply_move(curplayer->thegame, &coord))
                    {
						display_board(curplayer->thegame);
                        break;
                    }
                }
			}
	}
	else
	{
		valid = FALSE;
		while (!valid)
		{
			coord.x = rand() % curplayer->thegame->board_dimension +1;
			coord.y = rand() % curplayer->thegame->board_dimension +1;
			if (apply_move(curplayer->thegame, &coord))
			{
				display_computer_move(coord.y, coord.x);
				display_board(curplayer->thegame);
				valid = TRUE;
			}
		}
	}
}
