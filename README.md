# fillArray__Java-vs-CSharp
Speed comparison, Java vs. C# (DotNet Core), filling an array with 1 million integers.

*Tests done on: Intel i7 2.9 GHz, Windows 10 64bit*

*Java: OpenJDK 15.0.1*

*C# v9.0 (.NET 5.0.100)*

### 3 test runs with parameters: 1000002, 1000003, 1000004

## fillArray.java
- 0.0051042s
- 0.0049314s
- 0.0058498s
- AVERAGE: 5.3ms

## growArrayList.java
- 0.0291516s
- 0.0306681s
- 0.0293959s
- AVERAGE: 29.74ms

## growLinkedList.java
- 0.1172112
- 0.1074784
- 0.1174478
- AVERAGE: 114.0ms

## fillArray.cs
- 3ms
- 4ms
- 3ms
- AVERAGE: 3.3ms

## growList.cs
- 6ms
- 7ms
- 6ms
- AVERAGE: 6.3ms

## growLinkedList.cs
- 71ms
- 70ms
- 71ms
- AVERAGE: 70.7ms

There are much more collection types in C#, this one just as a bonus:

## growHetArrayList.cs
- 83ms
- 74ms
- 68ms
- AVERAGE: 75ms
