﻿// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet;
using BenchmarkDotNet.Running;

Console.WriteLine("Hello, World!");


BenchmarkRunner.Run<ComparacaoStringBenchmark>();