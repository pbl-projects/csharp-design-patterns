# Observer Pattern

**Scenario**: An auction system accepts bids from the user.
Upon bid several actions must take place, for example log action,
update the database, email the offering agent, update the screen, etc.
Those actions may change over time, some new may be added and others may be removed.

```WrongAuction``` is trying to do every action in the same class.
This is a problem because everytime we want to add a new action,
or remove an existing one, we need to modify the code of the class.

```Auction``` uses a list of ```AuctionListener``` observers.
Any object implementing the AuctionListener interface can register
and the Auction class needs no modofication in case of a new action to
be taken.