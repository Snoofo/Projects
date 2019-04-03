/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #2
* Full Name        : Stefan Mazaleigue
* Student Number   : S3507371
* Start up code provided by Paul Miller
***********************************************************************/

#include "filter.h"

/**
 * array of "filter" functions that perform various operations on the line
 * line past in
 **/
const filter filters[NUM_COMMANDS] = { flt_delete_line,   flt_insert_line,
                                       flt_insert_before, flt_insert_after,
                                       flt_insert_between };

/**
 * command that delete a line specified based on the line number
 **/
struct line_list* flt_delete_line(struct line_list* list,
                                  struct command* command)
{
        struct line_node * curr;
        int count = 1;
        int line_num;
        char * output;

        line_num = strtol(command->first_arg, &output, DECIMAL);
        curr = list->head;
        while (count < line_num)
        {
                if (curr == NULL)
                {
                        display_line_not_found(line_num);
                        return NULL;
                }
                curr = curr->next;
                ++count;
        }
        if (curr->prev == NULL)
        {
                list->head = curr->next;
                curr->next->prev = NULL;
                line_free(curr->data);
                free(curr);
        }
        else if (curr->next == NULL)
        {
                list->tail = curr->prev;
                curr->prev->next = NULL;
                line_free(curr->data);
                free(curr);
        }
        else
        {
                curr->prev->next = curr->next;
                curr->next->prev = curr->prev;
                line_free(curr->data);
                free(curr);
        }
        return list;
}

/**
 * command that inserts a line into the line_list at the specified line number
 **/
struct line_list* flt_insert_line(struct line_list* list,
                                  struct command* command)
{
        struct line_node * curr, * new, * prev = NULL;
        char * output;
        int line_num;
        int count = 0;
        new = malloc(sizeof(struct line_node));
        if (new == NULL)
        {
                display_mem_fail();
                return NULL;
        }
        memset(new, 0, sizeof(struct line_node));
        new->data = line_create(command->second_arg);

        line_num = strtol(command->first_arg, &output, DECIMAL);
        curr = list->head;
        while (count < line_num)
        {
                prev = curr;
                if (curr == NULL)
                {
                        display_line_not_found(line_num);
                        line_free(new->data);
                        free(new);
                        return NULL;
                }
                curr = curr->next;
                ++count;
        }
        if (prev == NULL)
        {
                curr->prev = new;
                new->next = curr;
                list->head = new;
        }
        else if (curr->next == NULL)
        {
                curr->next = new;
                new->prev = curr;
                list->tail = new;
        }
        else
        {
                prev->next = new;
                curr->prev = new;
                new->prev = prev;
                new->next = curr;
        }
        return list;
}

/* command that inserts a string before each string that matches second arg */
struct line_list* flt_insert_before(struct line_list* list,
                                    struct command* command)
{
        struct line_node * curr;
        struct line * new_line;
        char insert[BUFSIZ];
        char * string;
        char * arg_1 = command->first_arg;
        char * arg_2 = command->second_arg;
        int first_part;
        int second_part;

        curr = list->head;
        while (curr)
        {
                char new_string[BUFSIZ];
                string = curr->data->string;
                string = strstr(string, arg_1);
                if (string == NULL)
                {
                        curr = curr->next;
                        continue;
                }
                second_part = strlen(string);
                first_part = strlen(curr->data->string) - second_part;
                memset(insert, 0, sizeof(insert));
                strncpy(insert, curr->data->string, first_part);
                strcat(insert, arg_2);
                while (string != NULL)
                {
                        memset(new_string, 0, sizeof(new_string));
                        strcpy(new_string, string);
                        ++string;
                        string = strstr(string, arg_1);
                        if (string != NULL)
                        {
                                second_part = strlen(string);
                                first_part = strlen(new_string) - second_part;
                                strncat(insert, new_string, first_part);
                                strcat(insert, arg_2);
                        }
                }
                strcat(insert, new_string);
                new_line = malloc(sizeof(struct line));
                new_line->string = malloc(sizeof(insert));
                strcpy(new_line->string, insert);
                line_free(curr->data);
                curr->data = new_line;
                curr = curr->next;
        }
        return list;
}

/**
 * command that inserts a string after each string that matches the specified
 * string
 **/
struct line_list* flt_insert_after(struct line_list* list,
                                   struct command* command)
{
        struct line_node * curr;
        struct line * new_line;
        char insert[BUFSIZ];
        char * string;
        char * arg_1 = command->first_arg;
        char * arg_2 = command->second_arg;
        int first_part;
        int second_part;

        curr = list->head;
        while (curr)
        {
                char new_string[BUFSIZ];
                string = curr->data->string;
                string = strstr(string, arg_1);
                if (string == NULL)
                {
                        curr = curr->next;
                        continue;
                }
                second_part = strlen(string) - strlen(arg_1);
                first_part = strlen(curr->data->string) - second_part;
                memset(insert, 0, sizeof(insert));
                strncpy(insert, curr->data->string, first_part);
                strcat(insert, arg_2);
                while (string != NULL)
                {
                        memset(new_string, 0, sizeof(new_string));
                        string += strlen(arg_1);
                        strcpy(new_string, string);
                        string = strstr(string, arg_1);
                        if (string != NULL)
                        {
                                second_part = strlen(string) - strlen(arg_1);
                                first_part = strlen(new_string) - second_part;
                                strncat(insert, new_string, first_part);
                                strcat(insert, arg_2);
                        }
                }
                strcat(insert, new_string);
                new_line = malloc(sizeof(struct line));
                new_line->string = malloc(sizeof(insert));
                strcpy(new_line->string, insert);
                line_free(curr->data);
                curr->data = new_line;
                curr = curr->next;
        }
        return list;
}

/**
 * command that inserts a string between two other strings that have been
 * specified
 **/
struct line_list* flt_insert_between(struct line_list* list,
                                     struct command* command)
{
        struct line_node * curr;
        struct line * new_line;
        char insert[BUFSIZ];
        char * arg_1 = command->first_arg;
        char * arg_2 = command->second_arg;
        char * arg_3 = command->third_arg;
        char * string;
        char needle [MAX_TOK_LEN];
        int first_part;
        int second_part;
        strcpy(needle, arg_1);
        strcat(needle, arg_2);

        curr = list->head;
        while (curr)
        {
                char new_string[BUFSIZ];
                string = curr->data->string;
                string = strstr(string, needle);
                if (string == NULL)
                {
                        curr = curr->next;
                        continue;
                }
                second_part = strlen(string) - strlen(arg_1);
                first_part = strlen(curr->data->string) - second_part;
                memset(insert, 0, sizeof(insert));
                strncpy(insert, curr->data->string, first_part);
                while (string != NULL)
                {
                        memset(new_string, 0, sizeof(new_string));
                        string += strlen(arg_1);
                        strcpy(new_string, string);
                        string = strstr(string, needle);
                        if (string != NULL)
                        {
                                second_part = strlen(string) - strlen(arg_1);
                                first_part = strlen(new_string) - second_part;
                                strcat(insert, arg_3);
                                strncat(insert, new_string, first_part);
                        }
                }
                strcat(insert, arg_3);
                strcat(insert, new_string);
                new_line = malloc(sizeof(struct line));
                new_line->string = malloc(sizeof(insert));
                strcpy(new_line->string, insert);
                line_free(curr->data);
                curr->data = new_line;
                curr = curr->next;
        }
        return list;
}
