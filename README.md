# U-Plus-Language

This is the repository for the U+ (U Plus) programming language

## Current State and Todo

- [ ] Syntax/class format (.upi and .ups)
  - [ ] Logic
  - [ ] IO
  - [ ] Variables
  - [ ] Loops
- [ ] Executable/binary format (.upe)
  - [ ] Logic
  - [ ] IO
  - [ ] Variables
  - [ ] Loops
- [ ] Parakeet Runtime for Windows (C#)
  - [ ] Logic
  - [ ] IO
  - [ ] Variables
  - [ ] Loops
- [ ] Pelican Compiler for Windows (C#)
  - [ ] Conversion from .upi and .ups to .upc (maybe seperate file, or maybe just variables in the compiler - haven't decided)
    - [ ] Loops
  - [ ] Conversion from .upc/simplified code to .upe
    - [ ] Logic
    - [ ] IO
    - [ ] Variables
    - [ ] Loops
- [ ] Useful documentation
  - [ ] Actually starting (as in doing something and not just saying something is being done - could take a while)

## Syntax, .upi and .ups

Logic, IO, and Variables are all part of the standard library that is built into the compiler and runtime, and doesn't need to be mentioned in the .upi or .ups.

Libraries can be included (.upl), but they are essentially .upi or .ups files that contain methods and properties that can be used just as standard library properties or methods. Because .upe does not use a native application format, and does not run natively (unless you somehow put the compiler in the kernel I guess), .upl libraries are basically just methods that consist of standard library methods, and can't include methods which interact with the environment that aren't in the standard library.

## Executable/binary format (.upe)

A standardised format that means only version seperates any app in .upe format.

## Parakeet Runtime

.upe files do not run natively, and are not in any standard binary format, therefore a runtime is required to execute them.

Because the runtime is seperate to the compiler, if the runtime doesn't support a platform, or you just want to write a faster or more lightweight one, you can - we plan on writing strong documentation about the .upe format, and about the general compilation of .upi and .ups, to make this as painless as possible.

## Pelican Compiler

This is the compiler used to compile .upi and .ups files into the executable .upe format.
