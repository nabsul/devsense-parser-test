# Setup instructions

Check out this repo and in its directory run:

`dotnet restore`

`dotnet build`

`dotnet run`

# On Windows

On windows, the folloing is the output:

```
Type: T_OPEN_TAG
Type: T_WHITESPACE
Type: T_VARIABLE
Type: T_WHITESPACE
Type: T_EQ
Type: T_WHITESPACE
Type: T_START_HEREDOC
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_CURLY_OPEN
Type: T_VARIABLE
Type: T_RBRACE
Type: T_ENCAPSED_AND_WHITESPACE
```

# On Linux and Mac

On Linux and Mac, it falls into an infinite loop:

```
Type: T_OPEN_TAG
Type: T_WHITESPACE
Type: T_VARIABLE
Type: T_WHITESPACE
Type: T_EQ
Type: T_WHITESPACE
Type: T_START_HEREDOC
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
Type: T_ENCAPSED_AND_WHITESPACE
^C
```