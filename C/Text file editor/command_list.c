/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #2
* Full Name        : Stefan Mazaleigue
* Student Number   : S3507371
* Start up code provided by Paul Miller
***********************************************************************/

#include "command_list.h"

/* function to initialise a command_list struct. Returns a new command_list */
struct command_list * create_cmd_list(int num_args)
{
        struct command_list * command_list;
        command_list = malloc(sizeof(struct command_list));
        if (command_list == NULL)
        {
                display_mem_fail();
                return NULL;
        }
        memset(command_list, 0, sizeof(struct command_list));
        command_list->array = malloc(sizeof(struct command) * num_args);
        if (command_list->array == NULL)
        {
                display_mem_fail();
                return FALSE;
        }
        command_list->total_commands = num_args;
        return command_list;
}

/* function to populate a command list with command struct */
struct command_list* extract_commands(int num_commands, char* command_strings[])
{
        struct command_list * command_list;
        /* set starting point for command_strings array */
        int cmd_count = ARGC_3;
        char * cmd;

        command_list = create_cmd_list(num_commands);
        while (cmd = command_strings[cmd_count], cmd != NULL)
        {
                if (!command_list_add(command_list, cmd))
                {
                        command_list_free(command_list);
                        return NULL;
                }
                ++cmd_count;
        }
        return command_list;
}

/* function that adds a command struct to a command_list struct and increments
 * command_list count. Returns TRUE on success. */
BOOLEAN command_list_add(struct command_list * command_list, char * cmd_line)
{
        static int command_count = 0;
        struct command * command;
        command = create_command(cmd_line);
        if (command == NULL)
        {
                return FALSE;
        }
        command_list->array[command_count] = command;
        ++command_count;
        ++command_list->num_commands;
        return TRUE;
}

/* function to free a command_list struct, including all mallocs in the list */
void command_list_free(struct command_list * command_list)
{
        int cmd_count;

        for (cmd_count = 0; cmd_count < command_list->num_commands; ++cmd_count)
        {
                command_free(command_list->array[cmd_count]);
        }
        free(command_list->array);
        free(command_list);
}
