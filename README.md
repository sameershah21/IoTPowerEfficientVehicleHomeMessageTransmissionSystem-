# IoTPowerEfficientVehicleHomeMessageTransmissionSystem-
Power Efficient Vehicle Home Message Transmission system – An IOT Connected Home and Vehicle Project Implementation. 

Scenario:
User is carrying Connected IoT device as they are out on vacation. User has a refrigeration temperature monitor IoT device at home to make sure their grocery does not get stale. Every couple of hours the user needs to check the temperature to make sure everything is okay. The sender and receiver IoT devices can be turned off to save power during the intervals.
Technical Thought:
The emitter and receiver IoT device is battery powered and does not need to stay on constantly. This is a simple messaging scenario as no one needs to be constantly subscribed to device messages. Devices can replaced or more devices can be added on the receiving side. Hence, I used Microsoft Azure Queue since this architecture is built to satisfy these basic requirements Cloud Components:

•	Queue – Used to accept the messages securely. It will be hosted on Azure Storage account.

•	Web Job – To process messages from the Queue and store it in the database.



Other Components: 
Service Bus Explorer: To simulate creation of messages 
Implementation Details:

•	Using Service Bus Explorer, I will push the messages to the queue.Messages can be pushed async to time i.e no need to repeat within certiain intervals.

•	A Web Job will run to check the Queue and process its messages and display it Queue’s Invocation Details.


