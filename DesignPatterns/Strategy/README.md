# Strategy Pattern

A transportation system provides passengers with several ways of commuting to the airport.
In the future many more may be added.

Our approach involves ```ITransportationStrategy``` interface which is implemented by any available
transportation method.
A ```TransportationContext``` object holds a ITransportationStrategy reference  which
can refer to any concrete implementation of the interface.
```Passenger``` class has a TransportationContext data member. This way it can handle any
existing transportation strategy as well as any strategy to be added in the future, without any
modification of the Passenger.
