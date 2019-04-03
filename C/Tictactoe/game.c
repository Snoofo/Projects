/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #1 
* Full Name        : Stefan Mazaleigue
* Student Number   : S3507371
* Start up code provided by Paul Miller
***********************************************************************/

#include "game.h"
#include "rules.h"

#include "main.h"
/**
 * this function swaps the pointers to the two players in the game. It is the
 * code responsible for changing the current player. Please note that many
 * of you will find it difficult to figure out what to do for this function.
 * This is considered a high distinction requirement and as such not something
 * that everyone is expected to be able to do. For this reason, this function
 * is worth 5 bonus marks.
 **/
void swap_players(struct player** first, struct player** second)
{
	struct player *tmp = *first;
	*first = *second;
	*second = tmp;
}

/**
 * This function is responsible for the initialisation of the game (and thus
 * the game struct. First initialise all structures to be empty (including
 * players and the board. Next, ask the player for the player's name and assign
 * the token values to the players and also initialise the computer player,
 **/
void init_game(struct game* thegame)
{
    int token;
    int board_dimensions;
    int num_to_win = 3;
    struct player human;
    struct player computer;

    board_dimensions = init_board_dimensions();
	if (board_dimensions == 0)
	{
        thegame -> board_dimension = board_dimensions;
		return;
	}
    if (board_dimensions == 5)
    {
        num_to_win = init_num_to_win(board_dimensions);
        if (num_to_win == 0)
        {
            thegame -> num_in_row = num_to_win;
            return;
        }
    }
    
    token = rand() % NUM_PLAYERS;
    if (token == 0)
    {
        human.token = NOUGHT;
        computer.token = CROSS;
    }
    else
    {
        human.token = CROSS;
        computer.token = NOUGHT;
    }

    init_rand();
    init_player(&human, HUMAN, thegame);
    thegame -> players[0] = human;
    if (human.name[0] == '\0')
    {
        return;
    }

    init_player(&computer, COMPUTER, thegame);
    thegame -> board_dimension = board_dimensions;
    thegame -> num_in_row = num_to_win;
    thegame -> players[1] = computer;
    init_turn(thegame);
    thegame->quit = FALSE;
    gameboard_init(thegame -> board);
}

/**
 * the main function that manages the game loop. You'll need to call
 * initialisation functions. To initialise the game struct, which includes the
 * players and then it's just a matter of alternating turns until the end of
 * the game. At the end of the game, you'll need to print out details of the
 * final game state.
 **/
void play_game(void)
{
    struct game thegame;
    init_game(&thegame);
	if (thegame.board_dimension != 3 && thegame.board_dimension != 5)
	{
		return;
	}
    if (thegame.num_in_row < 3 && thegame.num_in_row > 5)
    {
        return;
    }
    if (thegame.players[0].name[0] == '\0')
    {
        return;
    }
	if (thegame.current->type == HUMAN)
	{
		display_board(&thegame);
	}
	while (!thegame.quit)
	{
		take_turn(thegame.current);
		if (get_game_state(&thegame).state == ONGOING)
		{
			swap_players(&thegame.current, &thegame.other);
		}
		else if (get_game_state(&thegame).state == WON)
		{
			display_winner(thegame);
			thegame.quit = TRUE;
		}
		else if (get_game_state(&thegame).state == DRAW)
		{
			display_draw();
			thegame.quit = TRUE;
		}
		else
		{
			thegame.quit = TRUE;
		}
	}
}
