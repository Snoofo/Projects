/***********************************************************************
* CPT220 - Programming in C
* Study Period 4 2017 Assignment #2
* Full Name        : Stefan Mazaleigue
* Student Number   : S3507371
* Start up code provided by Paul Miller
***********************************************************************/

#include "line.h"
#ifndef LINE_LIST_H
#define LINE_LIST_H

/* the line node that represents the 'links' in the doubly linked list. We have
 * required you to use a doubly linked list because it makes it easier to look
 * both forwards and backwards in the list. You will need to maintain both
 * pointers or you may have problems with uninitialised values.
 */
struct line_node
{
        struct line* data;
        struct line_node* prev;
        struct line_node* next;
};

/* the list header structure - it contains a pointer to the beginning and end
 * of the list
 */
struct line_list
{
        struct line_node* head;
        struct line_node* tail;
        int num_lines;
};

/* declare the function prototypes for allocating, managing and freeing the
 * line list
 */

struct line_list * line_list_create();
BOOLEAN line_list_add(struct line_list *, struct line *);
void line_list_delete(struct line_list *, int);
void list_free(struct line_list *);
#endif
