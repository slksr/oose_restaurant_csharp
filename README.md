# OOSE Restaurant Exercise

## Exercise 

Give the design of a solution (with a UML class diagram) which solves following problem: A system administers a few cooks (using a class Cook for this). Some of these cooks need different things than others in order to prepare themselves for a cooking session, this way the cooks distinguish amongst others and are able to serve different settings. The system is used by a chain of restaurants that works with a lot of cooks. In all restaurants work a few cooks, and when their shifts start they all do their preparation. But because new cooks come and some go, it should be fairly easy to remove cooks of a certain preparation type or to add new ones.


Your solution should be able to execute the preparation of all cooks by calling a preparation-method on each cook. This preparation method should return the name of the executed preparation (see examples below) and also show the content of the preparation in the console.

Some examples: 
- cook Christian uses a simple preparation: 
  - he just needs to ‘put an apron on’ 
  - this is also what most others cooks do. 
- cook Peter needs the the hardrock preparation:
  - take a collection of knifes
  - set some hardrock music on. 
- the cooks Maria and Rody need the soccer preparation 
  - open a beer 
  - hum the anthem of their favourite soccer team. 
