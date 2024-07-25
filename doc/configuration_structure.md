# Configuration file structure

Configuration file is obligatory part of using TM cli. The contain main information about clients configuration and messaging tasks.

Configuration file should have *.tmconf type.

## Configuration file syntax

There are two types of parameters in tmconf syntax.

First type of parameters is a common parameter. They must be written in one line with '=' sign between parameter name and parameter value.

Example:
```
parameter_name1=value1
```

The second type of parameters in tmcofig syntax is complicate parameters, which are multiline and must be written in special sections. The only purpose of using such parameters is describing your messaging tasks, so the syntax of such parameters looks like:

```
Task_taskname
    parameter_name1=value1
    parameter_name2=value2
    ...
Task_taskname
```