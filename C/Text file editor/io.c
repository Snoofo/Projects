/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #2
* Full Name        : Stefan Mazaleigue
* Student Number   : S3507371
* Start up code provided by Paul Miller
***********************************************************************/

#include "io.h"
#include "line_list.h"

/**
 * loads the filename specified into memory, storing each line in the line_list
 **/
struct line_list* load_file(const char* fname)
{
        char line[BUFSIZ + EXTRACHARS];
        FILE * file;
        struct line_list * list;
        struct line * new_line;
        int count = 1;
        
        file = fopen(fname, "r");
        if (file == NULL)
        {
                perror("Failed to open file: ");
                return NULL;
        }

        list = line_list_create();
        while (fgets(line, BUFSIZ + EXTRACHARS, file) != NULL)
        {
                if (line[strlen(line)-1] != '\n')
                {
                        if (!feof(file))
                        {
                                print_error("%s\n", "Buffer overflow. "
                                "Line read was too long");
                                fclose(file);
                                return NULL;
                        }
                }
                new_line = line_create(line);
                if (new_line == NULL)
                {
                        fclose(file);
                        return NULL;
                }
                if (!line_list_add(list, new_line))
                {
                        fclose(file);
                        return NULL;
                }
                ++count;
        }
        fclose(file);
        return list;
}

/**
 * saves the line line back to the file after whatever operations have been
 * done to the line list
 **/
BOOLEAN save_file(const char fname[], struct line_list* list)
{
        FILE * file;
        struct line_node * node;

        file = fopen(fname, "w");
        if (file == NULL)
        {
            perror("Failed to create file: ");
            return FALSE;
        }
        node = list->head;
        while (node)
        {
            fprintf(file, node->data->string);
            node = node->next;
        }
        fclose(file);
        return TRUE;
}

void display_cmd_line_error(void)
{
        print_error("Not enough command line arguments");
}

void display_invalid_cmd(char * cmd)
{
        print_error("%s is not a valid argument\n", cmd);
}

void display_mem_fail(void)
{
        perror("Failed to allocate memory\n");
}

void display_invalid_arg(void)
{
        print_error("Argument pattern does not match argument type\n");
}

void display_invalid_int(char * arg)
{
        print_error("\"%s\" is not a valid integer\n", arg);
}

void display_line_not_found(int line)
{
        print_error("Line %d not found\n", line);
}

/**
 * prints out error messages to the console - it just prepends each line with
 * an "Error: " prefix to make it clear what has gone wrong. This function is
 * used exactly the same as the printf function from the standard library.
 **/
int print_error(const char* format, ...)
{
        va_list args;
        /* we keep a track of the number of chars printed for a consistent
         * interface to how printf works */
        int charcnt = 0;
        /* print out the prefix */
        charcnt += fprintf(stderr, "%s", "Error: ");
        /* grab the arguments passed in */
        va_start(args, format);
        /* print out the formatted string using the format and args passed
         * into this function
         */
        charcnt += vfprintf(stderr, format, args);
        va_end(args);
        return charcnt;
}

/**
 * prints out informational messages to the console - it just prepends each
 * line with and "Info: ". This function is used exactly the same way as printf
 * from the standard library.
 **/
int print_message(const char* format, ...)
{
        va_list args;
        int charcnt = 0;

        charcnt += printf("%s", "Info: ");
        va_start(args, format);
        charcnt += printf(format, args);
        va_end(args);
        return charcnt;
}

