# fillArray__Java-vs-CSharp
Speed comparison, Java vs. C# (DotNet Core), filling an array with 1 million integers.

*Tests done on: Intel i7 2.9 GHz, Windows 10 64bit*

*Java: OpenJDK 15.0.1*

*C# v8.0 (compiler v3.7.0-6.20459.4)

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

## growList.java
- 0.1172112
- 0.1074784
- 0.1174478
- AVERAGE: 114.0ms


## fillArray.cs
- 3ms
- 4ms
- 3ms
- AVERAGE: 3.3ms
