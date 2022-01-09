# Standard Library

The standard library is vital to all U+ projects, as it includes all the methods and properties necessary to interact with the environment (unless the runtime to be used has been modified to include things not in the standard library). The standard library does not need to be mentioned at the top of any .upi or .ups file, so you can get straight into the actual code! Below is a tree of the standard library.

- IO
    - Read
        - ReadChar()
        - ReadString()
    - Write
        - PrintChar()
        - PrintString()
    - Look
        - GetPixel()
        - GetPixels()
    - Draw
        - SetPixel()
        - SetPixels()
    - Hear
        - GetSound()
        - GetFrequency()
        - GetWavelength()
        - GetAmplitude()
    - Sound
        - PlaySound()
        - PlayFrequency()
        - PlayWavelength()
        - PlayAmplitude()
    - GraphicsMode

- Integer
    - ToFloat()
    - ToString()
- Float
    - ToInt()
    - ToString()
- String
    - ToInt()
    - ToFloat()
    - ToChar()
- Char
    - ToInt()
    - ToFloat()
    - ToString()
- Bool
    - ToInt()
    - ToFloat()
    - ToString()
    - ToChar()