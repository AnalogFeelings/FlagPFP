# FlagPFP
A C# command line tool for adding a circular frame to images, with pride flags.

Uses the [Pastel](https://github.com/silkfire/Pastel) lib for color output, which makes it NO_COLOR compliant.

***Usage***: __flagpfp --image (profile pic) --flag (flag type) --margin (pixel margin) --insize (inner img size) --fsize (full size) --output (output)__

* --margin (pixel margin) is the margin of pixels to leave between the flag's border and the circle of the profile picture.

* --flag (flag type) for a list of flag types, look at [this](#flag-types)
  
* --fsize (full size) full image size, optional. Defaults to 800.

## Building FlagPFP
First off, you are going to need Visual Studio 2019, and .NET 5.0. Then open the .sln file and build it.

### Attention! 
The program will look for DLLs in the "lib" folder on the output directory. Please copy all DLLs except FlagPFP.dll to the "lib" folder. Also copy the "Flags" folder to the output directory for the program to be able to look for the flag images.

## Contributing
I am open to pull requests from everyone! Just fork it and start making pull requests :)

## Adding custom flags through JSON
Make sure the flag image is distinguisable when a circle is cropped in its middle! Also, preferably make the flag image 800x800 or just upscale it in something like 
Adobe Photoshop with filtering disabled (this is __crucial__ to having a sharp flag image after the upscale).

__Next, use this JSON template:__
```json
{
  "ConsoleHeader": "Transgender Flag",
  "FlagPattern": [ "#00D0FC", "#FFABBA", "#FFFFFF", "#FFABBA", "#00D0FC" ],
  "FlagFile": "transgender.png",
  "DesignCredits": null,
  "ParameterName": "transgender"
}
```
* "ConsoleHeader" is what will be printed when the program is ran.
* "FlagPattern" is an array of hexadecimal colors that get printed as a flag pattern next to ConsoleHeader.
* "FlagFile" the flag png or jpeg in the "Flags" folder.
* "DesignCredits" the credits to the designer of the flag that will get printed below ConsoleHeader on program use. For example, the polysexual flag has
"By McLennonSon - Own work, CC BY-SA 4.0, https://commons.wikimedia.org/w/index.php?curid=38241562" in this field.
* "ParameterName" is the name of the parameter --flag.

And you are ready to go! Your custom flag is now added.

## Flag Types (built in)

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

# PULL REQUESTS REGARDING THE "MAP" FLAG WILL BE DENIED.
Yes, thats right, we don't want your pedophile bullshit in this repository. Go see a psychologist if you are a MAP, you really need mental help.
