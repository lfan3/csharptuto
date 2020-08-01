# install mono on linux 9.
- https://www.mono-project.com/docs/getting-started/mono-basics/
- mcs/csc mono hello.exe

# mcs et mono command mome:
- create libary:
```
mcs -target:library -ouy:mylib.dll Partial*.cs

mcs -reference:mylib.dll Main.cs
> output Main.exe file

mono Main.exe
```

# error:
- too many characters error:
```
This is because, in C#, single quotes ('') denote (or encapsulate) a single character, whereas double quotes ("") are used for a string of characters. For example:

var myChar = 'a';

var myString = "abc";

```

# static variable and method are belong to class

# dynamic vs var
- dynamic is an object, which type can be changed at run time
- var is a static typed, the type can not changed. a value is assigned at the creation immediatly.
 ex: var test = 2; test =1.2 (x), because test is an integer!
- An implicitly typed(var) local variable declarator must include an initializer

# value type and reference type
- struct est value type, class est reference type

# convert string to int
```
string age = "90";
int Age = Convert.ToInt32(age);
int Age1 = Int32.Parse(age);

```

# boxing and unboxing
```
 int num = 2020;
 //boxing: value type to reference type
 object obj = num;
 //unboxing: reference type to value type, need casting
 int i = (int)obj;

```

# type casting + numeric data type size
- yte < short < int < float < double
- conversion can cause lossy conversion 
```
ex: 
double d = 75.2; 
int i = (int)d;
output:
i = 75, loss of 0.2 value

```

# nullable works only with value type (int char float double long short ...)

# Errors
## pointer
-  ERROR, a pointer is not permitted to poit to a reference Or struc that contains reference and the referent type.
## static method
- static method never allows a no-static method call directly.
- reason: static method belong to class only, and no-static belong to object