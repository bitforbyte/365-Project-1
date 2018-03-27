The driver will take the name of the file and output it with the same name with the extension changed to .bin
it will place the output file in the same directory as the input file

If the makefile doesn't work the line to compile is below
mcs -out:Assembler.exe src_Files/Assembler.cs src_Files/Driver.cs src_Files/Ilabel.cs src_Files/bAssembler.cs src_Files/aAssembler.cs src_Files/IInstruction.cs src_Files/kAssembler.cs src_Files/Label.cs src_Files/Instruction.cs
