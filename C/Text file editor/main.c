/***********************************************************************
 *
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #2
* Full Name        : Stefan Mazaleigue
* Student Number   : S3507371
* Start up code provided by Paul Miller
***********************************************************************/

#include "main.h"

int main(int argc, char** argv)
{
        struct line_list * list;
        struct command_list * command_list;
        /* get number of command arguments */
        int num_cmds = argc - ARGC_3;
        int cmd_count;

        /* check the minimum number of arguments have been passed in */
        if (argc < MINARGS)
        {
                display_cmd_line_error();
                return EXIT_FAILURE;
        }

        /* load in the text file into a linked list - don't forget to
         * check this has succeeded!!*/
        list = load_file(argv[ARGC_2]);
        /* check for list initialisation failure */
        if (list == NULL)
        {
                return EXIT_FAILURE;
        }
        
        /* parse all the commands from the arguments passed in */
        command_list = extract_commands(num_cmds, argv);
        /* check for command list initialisation failure */
        if (command_list == NULL)
        {
                list_free(list);
                return EXIT_FAILURE;
        }

        /* iterate over the command list, applying each command to the line list
         */
        for (cmd_count = 0; cmd_count < command_list->num_commands; ++cmd_count)
        {
                struct command * cmd = command_list->array[cmd_count];
                if(!filters[cmd->type](list, cmd))
                {
                        list_free(list);
                        command_list_free(command_list);
                        return EXIT_FAILURE;
                }
        }

        /* save the file back to the original file name and check for success */
        if (!save_file(argv[ARGC_2], list))
        {
                list_free(list);
                command_list_free(command_list);
                return EXIT_FAILURE;
        }
        
        /* free all memory */
        list_free(list);
        command_list_free(command_list);
        return EXIT_SUCCESS;
}
