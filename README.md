# AspNet-Core2-Page-Route-Problem

Problem: adding the following;
```
@page "{id?}"
```
to the top of a page causes it to pick up the route of other pages.

Produce:
1. Out-of-the-box asp.net core2.1 WebApplication
2. Add the following to contacts.cshtml and about.cshtml
```
@page "{id?}"
```
3. Route to;
```
https://localhost:44306/About/hello
```
4. Now click on "Contacts" in the NavBar.

You will be routed to 
```
https://localhost:44306/Contact/hello
```

HWhattt?


I have tried replacing;
```
  app.UseMve();
```
with
```
 app.UseMvcWithDefaultRoute();
```
Still the same problem.



