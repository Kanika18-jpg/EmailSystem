using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSystem
{
    class Email
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Sender { get; set; }
        public DateTime Timestamp { get; set; }

        public Email(string subject, string body, string sender)
        {
            Subject = subject;
            Body = body;
            Sender = sender;
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"From: {Sender}\nSubject: {Subject}\nReceived: {Timestamp}\n{Body}";
        }
    }

    class Contact
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }

        public Contact(string name, string email)
        {
            Name = name;
            EmailAddress = email;
        }
    }

    class Inbox
    {
        private List<Email> emails = new List<Email>();

        public void SendEmail(Email email)
        {
            emails.Add(email);
            Console.WriteLine("Email sent.");
        }

        public void ReceiveEmail(Email email)
        {
            emails.Add(email);
            Console.WriteLine("Email received.");
        }

        public void DisplayEmails()
        {
            if (emails.Count == 0)
            {
                Console.WriteLine("No emails in the inbox.");
            }
            else
            {
                Console.WriteLine("Inbox:");
                foreach (var email in emails)
                {
                    Console.WriteLine(email);
                    Console.WriteLine();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create some contacts
            Contact contact1 = new Contact("Deevanshu", "vanshu@example.com");
            Contact contact2 = new Contact("Rakesh", "rakesh@example.com");

            // Create an inbox
            Inbox inbox = new Inbox();

            // Compose and send emails
            Email email1 = new Email("Hello", "How are you?", "vanshu@example.com");
            Email email2 = new Email("Meeting", "Let's schedule a meeting.", "rakesh@example.com");

            inbox.SendEmail(email1);
            inbox.SendEmail(email2);

            // Display emails in the inbox
            inbox.DisplayEmails();

            Console.Read();
        }
    }
}