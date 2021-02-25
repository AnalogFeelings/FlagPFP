# FlagPFP
A C# command line tool for adding a circular frame to images, with pride flags.

Uses the [Pastel](https://github.com/silkfire/Pastel) lib for color output, which makes it NO_COLOR compliant.

* Usage: __flagpfp (profile pic) (flag type) (pixel margin) (output file)__

  * (pixel margin) is the margin of pixels to leave between the flag's border and the circle of the profile picture.

  * (flag type) for a list of flag types, look at [this](#flag-types)

### Attention!
Your profile picture must be over 800x800!

## Building FlagPFP
First off, you are going to need Visual Studio 2019, and .NET 5.0. Then open the .sln file and build it.

### Attention! 
The program will look for DLLs in the "lib" folder on the output directory. Please copy all DLLs except FlagPFP.dll to the "lib" folder. Also copy the "Flags" folder to the output directory for the program to be able to look for the flag images.

## Contributing
I am open to pull requests from everyone! Just fork it and start making pull requests :)

## Adding custom flags (Not possible yet!)
Make sure the flag image is distinguisable when a circle is cropped in its middle! Also, preferably make the flag image 800x800 or just upscale it in something like 
Adobe Photoshop with filtering disabled (this is __crucial__ to having a sharp flag image after the upscale).

## Flag Types

* agender
* aromantic
* asexual
* bisexual
* demisexual
* gay
* gaymen
* genderfluid
* genderqueer
* lesbian
* nonbinary
* pansexual
* polysexual
* transexual
