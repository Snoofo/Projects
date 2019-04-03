
OBJECTS=command.o command_list.o filter.o helpers.o io.o line.o line_list.o\
main.o
HEADERS=command.h command_list.h filter.h helpers.h io.h line.h line_list.h\
main.h shared.h
CC=gcc
CFLAGS=-ansi -Wall -pedantic
LFLAGS=
EXE=main

all: $(EXE)

$(EXE): $(OBJECTS)
	$(CC) $(LFLAGS) $^ -o $@

%.o: %.c $(HEADERS)
	$(CC) $(CFLAGS) -c $<

debug:CFLAGS+=-g -DDEBUG
debug:clean all

.PHONY:clean
clean:
	rm -f $(OBJECTS) $(TARGETS)
