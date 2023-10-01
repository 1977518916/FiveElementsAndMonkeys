# CompDevLib

## Introduction

This is an all-in-one c# code library with a bunch of utility functions, data structures, algorithms, etc. that are commonly used in game development.

 It is created in hope that myself and possibly others can start with a fairly rich utility library to work with for future projects, without having to implement the same stuff again and again every time it is needed.

## Modules

### Collection

* SpanList
* Fixed length BoolArray (struct)
* Binary heap
* Graph
* Collection extensions for sorting, shuffling, searching, and some replacements for LinQ functions.

### Math Utilities

* Vector and matrix manipulation (_TO BE IMPLEMENTED_)
* Interpolations
* Bitwise operations

### Algorithm

Algorithms that are commonly used in video games.

* Binary space partitioning algorithm
* AStar algorithm (_TO BE IMPLEMENTED_)
* Dijkstra algorithm
* Alpha-Beta Pruning (_TO BE IMPLEMENTED_)

### Event System

An event triggering and handling system.

* synchronous and asynchronous event actions
* Event chains with priority (can be used as a base for blueprint-like game flow controlling system)

### State Machine

* A generic state machine that is powered by the event system
* A lightweight implementation of behavior tree

### Job System

A system for frame-based "concurrent" jobs' execution and other coroutine-like behaviors.

* Single threaded job management.
* Multi-threaded job management.

### Code Processing

A simple lexer. 

### Pool

* Object pool
* Memory pool (_TO BE IMPLEMENTED_)
* Thread pool (_TO BE IMPLEMENTED_)

### Console

Define and manage "console commands" with ease for in-game console development.
