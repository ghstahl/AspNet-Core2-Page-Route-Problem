# AspNet-Core2-Page-Route-Problem

Problem: adding the following;
```
@page "{id?}"
```
to the top of a page causes it to pick up the route of other pages.

When you run this sample click on the following;  
[https://localhost:44367/Ones/Trigger](https://localhost:44367/Ones/Trigger)

Then hover over "Contact" you will notice that the route is;  
[https://localhost:44367/Contact/Trigger](https://localhost:44367/Contact/Trigger)  

Whats up with that?  

I have tried replacing;
```
  app.UseMve();
```
with
```
 app.UseMvcWithDefaultRoute();
```
Still the same problem.



