/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #2
* Full Name        : Stefan Mazaleigue
* Student Number   : S3507371
* Start up code provided by Paul Miller
***********************************************************************/

#include "line_list.h"

/* implement the functions for allocation, management and freeing the line_list
 * should go here
 */

/* function to create a line list. Returns a new mallocd line_list struct */
struct line_list * line_list_create()
{
        struct line_list * list;
        list = (struct line_list *)malloc(sizeof(struct line_list));
        if (list == NULL)
        {
                display_mem_fail();
                return NULL;
        }
        memset(list, 0, sizeof(struct line_list));
        return list;
}

/* Function that adds a line to the list
 * Assumption: line has already been malloc'd */
BOOLEAN line_list_add(struct line_list * list, struct line * line)
{
        struct line_node * new, * curr;
        
        new = malloc(sizeof(struct line_node));
        if (new == NULL)
        {
                display_mem_fail();
                return FALSE;
        }
        memset(new, 0, sizeof(struct line_node));
        new->data = line;
        
        if (list->head == NULL)
        {
                list->head = new;
                list->tail = new;
                list->tail->next = NULL;
                ++list->num_lines;
                return TRUE;
        }

        if (list->head->next == NULL)
        {
            list->head->next = new;
            new->prev = list->head;
            list->tail = new;
            return TRUE;
        }
        curr = list->tail;
        curr->prev->next = curr;
        new->next = curr->next;
        curr->next = new;
        new->prev = curr;
        list->tail = new;
        ++list->num_lines;

        return TRUE;
}

/* Function to free the memory allocated to the list iterating over all lines
 * in the list and calling the line_free function */
void list_free(struct line_list * list)
{
        struct line_node * node;
        struct line_node * next;
        int count = 1;

        node = list->head;

        while(node)
        {
                next = node->next;
                line_free(node->data);
                free(node);
                node = next;
                ++count;
        }
        free(list);
}

