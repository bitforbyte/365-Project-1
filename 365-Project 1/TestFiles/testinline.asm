//test.asm - Test the assembler to see if it produces proper bytecode
//also tests the virtual machine to make sure everything works properly
//Stephen Marz	
//18 December 2017
//COSC365 - University of Tennessee -- Knoxville
#adding this comment to test python style comments


main:
	goto  begin //Testing inline comment
	push  0x0 //
	push  exit //a
	push // comment
begin:
	push  start // bcd
	neg
	ifpl  start ///
	nop
	nop
	ifez  /*star comment*/ start
	nop
	nop
	ifnz /**/ start
	nop
start:
	push  -44 #p style comments
	not #
	mul ##s
	push  0xd
	add #sdf
	dup
	add
	swap
exit:
	swap
	iflt exit
	push  0xa
	push  0xabcd
	push  -1234
	push  exit
	print
	dup   2
	dump
	exit 121

