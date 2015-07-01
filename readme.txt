This solution is based off one of my blog posts:
To demonstrate the transactional boundaries for handling events vs. handling commands, please to the following:

- comment IN the “throw new Exception(“the web service call failed”);” line and comment out the bus.Send line in SendCommandToInvokeWebServiceHandler. 
- try to place an order.
- note that CustomerPreferred will NOT be written to the database, because the handler invoking the web service call failed.

- comment OUT the exception being throw in the ChangeCustomerPreferredStatusHandler and comment IN the bus.Send line. 
- in the InvokeWebServiceHandler, I’m throwing an exception to simulate the web service call failing. 
- when you run the code, even though you still see exceptions being thrown, note that the CustomerPreferred entity is successfully written to the database.