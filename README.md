# Design Patterns

Design patterns are typical solutions to common problems in software design. This repository contains 22 of the Gang of Four's patterns.


## [Creational](/Creational)

Patterns that flexibly create and instantiate objects.

- [Abstract Factory](/Creational/AbstractFactory) groups object factories that have a common theme.
- [Builder](/Creational/Builder) constructs complex objects by separating construction and representation.
- [Factory Method](/Creational/FactoryMethod) creates objects without specifying the exact class to create.
- [Prototype](/Creational/Prototype) creates objects by cloning an existing object.
- [Singleton](/Creational/Singleton) restricts object creation for a class to only one instance.

## [Structural](/Structural)

Patterns that define ways to compose objects to obtain new functionality.

- [Adapter](/Structural/Adapter) allows classes with incompatible interfaces to collaborate.
- [Bridge](/Structural/Bridge) decouples an abstraction from its implementation so that the two can vary independently.
- [Composite](/Structural/Composite) composes zero-or-more similar objects so that they can be manipulated as one object.
- [Decorator](/Structural/Decorator) dynamically adds/overrides behaviour in an existing method of an object.
- [Facade](/Structural/Facade) provides a simplified interface to a complex system of classes, library or framework.
- [Flyweight](/Structural/Flyweight) reduces the cost of creating and manipulating a large number of similar objects.
- [Proxy](/Structural/Proxy) provides a placeholder for another object to control access, reduce cost, and reduce complexity.

## [Behavioral](/Behavioral)

Patterns that specifically concern the communication and the assignment of responsibilities between objects.

- [Chain of Responsibility](/Behavioral/ChainOfResponsibility) delegates commands to a chain of processing objects.
- [Command](/Behavioral/Command) converts request into a object which encapsulates actions and parameters.
- [Iterator](/Behavioral/Iterator) accesses the elements of an object sequentially without exposing its underlying representation.
- [Mediator](/Behavioral/Mediator) allows loose coupling between classes by being the only class that has detailed knowledge of their methods.
- [Memento](/Behavioral/Memento) provides the ability to restore an object to its previous state (undo).
- [Observer](/Behavioral/Observer) is a publish/subscribe pattern which allows a number of observer objects to see an event.
- [State](/Behavioral/State) allows an object to alter its behavior when its internal state changes.
- [Strategy](/Behavioral/Strategy) allows one of a family of algorithms to be selected on-the-fly at runtime.
- [Template Method](/Behavioral/TemplateMethod) defines the skeleton of an algorithm as an abstract class, allowing its subclasses to provide concrete behavior.
- [Visitor](/Behavioral/Visitor) separates an algorithm from an object structure by moving the hierarchy of methods into one object.