/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #2
* Full Name        : Stefan Mazaleigue
* Student Number   : S3507371
* Start up code provided by Paul Miller
***********************************************************************/

#include "command.h"
/**
 * which kind of command is being referred to in this command? In this function,
 * you should determine the type of command (which filter function that is
 * called) for a given command
 **/
enum command_type command_type(const char* filter_str)
{
        if (strcmp(filter_str,"dl") == 0)
        {
            return CMD_DELETE_LINE;
        }
        if (strcmp(filter_str,"il") == 0)
        {
            return CMD_INSERT_LINE;
        }
        if (strcmp(filter_str,"ib") == 0)
        {
            return CMD_INSERT_BEFORE;
        }
        if (strcmp(filter_str,"ia") == 0)
        {
            return CMD_INSERT_AFTER;
        }
        if (strcmp(filter_str,"ibt") == 0)
        {
            return CMD_INSERT_BETWEEN;
        }
        return CMD_INVALID;
}

/* function to create a command which calls a specific create function
 * depending on the command type */
struct command * create_command(char * cmd_line)
{
        struct command * command;
        char * tok;
        char * tok_lines[MAX_TOK_LEN];
        int tok_count = 0;
        command = malloc(sizeof(struct command));
        if (command == NULL)
        {
                display_mem_fail();
                return NULL;
        }
        memset(command, 0, sizeof(struct command));
        tok = strtok(cmd_line, CMD_DELIM);
        while (tok)
        {
                tok_lines[tok_count] = tok;
                tok = strtok(NULL, CMD_DELIM);
                ++tok_count;
                if (tok_count > MAX_TOKS && tok != NULL)
                {
                        display_invalid_arg();
                        command_free(command);
                        return NULL;
                }
        }
        command->type = command_type(tok_lines[0]);
        switch (command->type)
        {
                case CMD_DELETE_LINE:
                    if(tok_count != DEL_NUM)
                    {
                            display_invalid_arg();
                            command_free(command);
                            return NULL;
                    }
                    if(!create_cmd_del(command, tok_lines))
                    {
                            command_free(command);
                            return NULL;
                    }
                    break;
                case CMD_INSERT_LINE:
                    if(tok_count != INS_NUM)
                    {
                            display_invalid_arg();
                            command_free(command);
                            return NULL;
                    }
                    if(!create_cmd_insert(command, tok_lines))
                    {
                            command_free(command);
                            return NULL;
                    }
                    break;
                case CMD_INSERT_BEFORE:
                    if(tok_count != INBEF_NUM)
                    {
                            display_invalid_arg();
                            command_free(command);
                            return NULL;
                    }
                if(!create_cmd_inbef(command, tok_lines))
                    {
                            command_free(command);
                            return NULL;
                    }
                    break;
                case CMD_INSERT_AFTER:
                    if(tok_count != INAFT_NUM)
                    {
                            display_invalid_arg();
                            command_free(command);
                            return NULL;
                    }
                    if(!create_cmd_inaft(command, tok_lines))
                    {
                            command_free(command);
                            return NULL;
                    }
                    break;
                case CMD_INSERT_BETWEEN:
                    if(tok_count != INBET_NUM)
                    {
                            display_invalid_arg();
                            command_free(command);
                            return NULL;
                    }
                    if(!create_cmd_inbet(command, tok_lines))
                    {
                            command_free(command);
                            return NULL;
                    }
                    break;
                default:
                    display_invalid_cmd(cmd_line);
                    command_free(command);
                    return NULL;
        }
        return command;
}

/* function to add the args for delete command */
BOOLEAN create_cmd_del(struct command * command, char ** lines)
{
        int line_count = 1;
        int num;
        char * output;

        num = strtol(lines[line_count], &output, DECIMAL);
        if (*output != '\0' || num < 0)
        {
                display_invalid_arg();
                display_invalid_int(lines[line_count]);
                return FALSE;
        }
        
        command->first_arg = malloc(sizeof(char)*(strlen(lines[line_count])+1));
        if (command->first_arg == NULL)
        {
                display_mem_fail();
                return FALSE;
        }
        strcpy(command->first_arg, lines[line_count]);
        return TRUE;

}

/* function to add the args for insert line command */
BOOLEAN create_cmd_insert(struct command * command, char ** lines)
{
        int line_count = 1;
        int num;
        char * output;

        num = strtol(lines[line_count], &output, DECIMAL);
        if (*output != '\0' || num < 0)
        {
                display_invalid_arg();
                display_invalid_int(lines[line_count]);
                return FALSE;
        }
        
        command->first_arg = malloc(sizeof(char)*(strlen(lines[line_count])+1));
        if (command->first_arg == NULL)
        {
                display_mem_fail();
                return FALSE;
        }
        strcpy(command->first_arg, lines[line_count]);
        
        ++line_count;
        command->second_arg = malloc(sizeof(char)*(strlen(lines[line_count])+1)+1);
        if (command->second_arg == NULL)
        {
                display_mem_fail();
                return FALSE;
        }

        strcpy(command->second_arg, lines[line_count]);
        strcat(command->second_arg, "\n");
        return TRUE;
}

/* function to add the args for insert before command */
BOOLEAN create_cmd_inbef(struct command * command, char ** lines)
{
        int line_count = 1;
        
        command->first_arg = malloc(sizeof(char)*(strlen(lines[line_count])+1));
        if (command->first_arg == NULL)
        {
                display_mem_fail();
                return FALSE;
        }
        strcpy(command->first_arg, lines[line_count]);
        
        ++line_count;
        command->second_arg = malloc(sizeof(char)*(strlen(lines[line_count])+1));
        if (command->second_arg == NULL)
        {
                display_mem_fail();
                return FALSE;
        }

        strcpy(command->second_arg, lines[line_count]);
        return TRUE;
}

/* function to add the args for insert after command */
BOOLEAN create_cmd_inaft(struct command * command, char ** lines)
{
        int line_count = 1;
        
        command->first_arg = malloc(sizeof(char)*(strlen(lines[line_count])+1));
        if (command->first_arg == NULL)
        {
                display_mem_fail();
                return FALSE;
        }
        strcpy(command->first_arg, lines[line_count]);
        
        ++line_count;
        command->second_arg = malloc(sizeof(char)*(strlen(lines[line_count])+1));
        if (command->second_arg == NULL)
        {
                display_mem_fail();
                return FALSE;
        }

        strcpy(command->second_arg, lines[line_count]);
        return TRUE;
}

/* function to add the args for insert between command */
BOOLEAN create_cmd_inbet(struct command * command, char ** lines)
{
        int line_count = 1;
        
        command->first_arg = malloc(sizeof(char)*(strlen(lines[line_count])+1));
        if (command->first_arg == NULL)
        {
                display_mem_fail();
                return FALSE;
        }
        strcpy(command->first_arg, lines[line_count]);
        
        ++line_count;
        command->second_arg = malloc(sizeof(char)*(strlen(lines[line_count])+1));
        if (command->second_arg == NULL)
        {
                display_mem_fail();
                return FALSE;
        }
        strcpy(command->second_arg, lines[line_count]);
        
        ++line_count;
        command->third_arg = malloc(sizeof(char)*(strlen(lines[line_count])+1));
        if (command->third_arg == NULL)
        {
                display_mem_fail();
                return FALSE;
        }
        strcpy(command->third_arg, lines[line_count]);
        return TRUE;
}

/* function to free a command including the malloc'd char pointers */
void command_free(struct command * cmd)
{
        free(cmd->first_arg);
        free(cmd->second_arg);
        free(cmd->third_arg);
        free(cmd);
}
