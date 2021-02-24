# FlagPFP
A C# command line tool for adding a circular frame to images, with pride flags.

Uses the Pastel lib for color output, which makes it NO_COLOR compliant.

Usage: __flagpfp (profile pic) (flag type) (pixel margin) (output file)__

(pixel margin) is the margin of pixels to leave between the flag's border and the circle of the profile picture.

## Building FlagPFP
First off, you are going to need Visual Studio 2019, and .NET 5.0. Then open the .sln file and build it.

__--Attention--__ The program will look for DLLs in the "lib" folder on the output directory. Please copy all DLLs except FlagPFP.dll to the "lib" folder.

## Contributing
I am open to pull requests from everyone! Just fork it and start making pull requests :)
