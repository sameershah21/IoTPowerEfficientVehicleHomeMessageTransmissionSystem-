
using System;
using System.IO;

using Microsoft.Azure.WebJobs;
using t1.data.datatypes;
using Microsoft.ServiceBus.Messaging;


namespace t1.azure.servicebusqueueprocessor
{
    public class Functions
    {
        private static readonly IoTDatabaseContext database = new IoTDatabaseContext();

        /// <summary>
        /// This function will get triggered/executed when a new message is written on an Azure Service Bus Queue.
        /// </summary>
        public static void ProcessQueueMessage([ServiceBusTrigger("queueerrorsandwarnings")] BrokeredMessage message, TextWriter log)
        {
            try
            {
                log.WriteLine($"Processing message: {message.Properties["exceptionmessage"]} Vehicle: {message.Properties["vehicle"]}");

                // Add the message we received from our queue to the database
                database.ErrorAndWarningsEntries.Add(new ErrorAndWarning()
                {
                    CreatedDateTime = DateTime.Parse(message.Properties["time"].ToString()),
                    VehicleName = message.Properties["vehicle"].ToString(),
                    Message = message.Properties["exceptionmessage"].ToString()
                });

                // Save changes in the database
                database.SaveChanges();
            }
            catch (Exception exception)
            {
                log.WriteLine($"Exception in ProcessQueueMessage: {exception}");
            }
        }
    }
}
