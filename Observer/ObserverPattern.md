# Observer pattern
**Observer pattern is used for avoiding polling. It uses push notifications instead.**

Here we have an observable object and a few observers observing the changes.
When a change happens on the observable object ( usually called a subject ) observers are notified. 

### *Example*: 
This example is taken from head first design patterns.
Here we are observing the changes of a weather station.
We have two observers 
  - a TV  
  - and a cell phone.

### Notes
As I built the observer and observable (subject) I noticed that I dont have a mechanism for sending the data along with the notification.
Then I created a payload interface for that purpose.

