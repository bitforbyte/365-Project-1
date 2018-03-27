#Compiler for Cs
COMP =mcs

#Cs Flags
FLAGS =-out:$(EXECUTABLE)

#add source files
SRC_FILES = $(wildcard src_Files/*.cs)

#Executable name
EXECUTABLE = Assembler.exe

#Run everything if neccasry
all: $(EXECUTABLE)

$(EXECUTABLE): $(SRC_FILES)
	$(COMP) $(FLAGS) $(SRC_FILES)

.PHONY: clean
clean:
	rm -f $(EXECUTABLE)



