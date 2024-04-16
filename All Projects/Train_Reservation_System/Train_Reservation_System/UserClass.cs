using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Reservation_System
{
    class UserClass
    {
        static Train_Reservation_DBEntities TRDB = new Train_Reservation_DBEntities();
        static booked_ticket bt = new booked_ticket();
        static canceled_ticket ct = new canceled_ticket();
        static seat_availability sa = new seat_availability();
        static train_details td = new train_details();
        static user_details ud = new user_details();
        static int uid;


        public static void userFunction()
        {
            Console.Write("\n  New User -> 1\n  Old User -> 2\n  Exit     -> 0\n");
            Console.WriteLine();
            Console.Write("Enter Your Choice: ");
            int input;

            while (!int.TryParse(Console.ReadLine(), out input) || (input < 0 || input > 2))
            {
                Console.WriteLine("Please enter a valid option (1, 2, or 0).");
                Console.Write("Enter your choice: ");
            }

            switch (input)
            {
                case 0:
                    Console.WriteLine("Exiting the program...");
                    return; // Exit the program
                case 1:
                    Console.WriteLine();
                    Console.WriteLine(".................New User selected.................");
                    Console.WriteLine();
                    // new user create account
                    userDetailsFun();
                    Console.WriteLine();
                    userPartOptions();
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine(".................Old User selected.................");
                    Console.WriteLine();
                    // old user login
                    oldUserLogin();
                    Console.WriteLine();
                    userPartOptions();
                    
                    break;
            }
        }

        //method for user registration
        static void userDetailsFun()
        {
            Console.Write("\nEnter new user id: ");
            uid = Convert.ToInt32(Console.ReadLine());
            var checkUID = TRDB.user_details.SingleOrDefault(ud => ud.userId == uid);
            if (checkUID != null)
            {
                Console.WriteLine("User ID is already Exists...");
                userDetailsFun();
            }

            ud.userId = uid;
            Console.Write("\nEnter Name : ");
            ud.userName = Console.ReadLine();
            Console.Write("\nEnter Age : ");
            ud.age = int.Parse(Console.ReadLine());
            Console.Write("\nEnter Passcode : ");
            ud.passcode = Console.ReadLine();
            TRDB.user_details.Add(ud);
            TRDB.SaveChanges();
            Console.Write("Successfully Registered!");
        }

        static void userPartOptions()
        {
            Console.Write("\n  Book Ticket        ->    1\n  Booked Ticket      ->    2\n  Cancel Ticket      ->    3\n  Your All Tickets   ->    4\n  Go to Home Page    ->    5\n  Exit               ->    6\n");
            Console.WriteLine();
            Console.Write("Enter Your Choice : ");
            int input;

            while (!int.TryParse(Console.ReadLine(), out input) || (input < 1 || input > 6))
            {
                Console.WriteLine("Please enter a valid option (1, 2, 3 or 4).");
                Console.Write("Enter your choice: ");
            }

            switch (input)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine(".................Book Ticket Selected.................");
                    Console.WriteLine();
                    ShowAllTrains();
                    BookTicket(uid);
                    userPartOptions();
                    break; // Exit the program
                case 2:
                    Console.WriteLine();
                    Console.WriteLine(".................Booked Ticket Selected.................");
                    Console.WriteLine();
                    ShowBookedTickets(uid);                    
                    userPartOptions();
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine(".................Cancel Ticket Selected.................");
                    Console.WriteLine();
                    CancelTicket();
                    userPartOptions();
                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine(".................Show All Tickets.................");
                    Console.WriteLine();
                    ShowBookingCancellation(uid);
                    userPartOptions();
                    break;

                case 5:
                    Program.mainFunction();
                    Console.WriteLine();
                    break;

                case 6:
                    Console.WriteLine("Exiting the program...");
                    return;

            }
        }

        //Existing user login
        static void oldUserLogin()
        {
            Console.Write("Enter User ID: ");
            uid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            var user = TRDB.user_details.FirstOrDefault(ud => ud.userId == uid && ud.passcode == password);
            if (user != null)
            {
                Console.WriteLine($"Welcome, {user.userName}!");
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
        }

        //Book Ticket
        static void BookTicket(int uid)
        {
            Console.WriteLine();
            Console.Write("Enter train number: ");
            int trainNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter passenger name: ");
            string passengerName = Console.ReadLine();

            Console.Write("Enter passenger age: ");
            int passengerAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter ticket class (1AC, 2AC, 3AC, SL): ");
            string ticketClass = Console.ReadLine().ToUpper();

            // Check if the train is active
            var train = TRDB.train_details.FirstOrDefault(td => td.trainNo == trainNo && td.Status == "Active");
            if (train == null)
            {
                Console.WriteLine("Sorry, this train is not active.");
                return;
            }

            // Check seat availability
            var seatAvailability = TRDB.seat_availability.FirstOrDefault(sa => sa.trainNo == trainNo);
            if (seatAvailability == null || !HasAvailableSeats(seatAvailability, ticketClass))
            {
                Console.WriteLine("Sorry, there are no available seats in the selected class.");
                return;
            }

            // Calculate total fare
            var train2 = TRDB.train_classes.FirstOrDefault(tc => tc.trainNo == trainNo && tc.train_details.Status == "Active");
            float fare = GetFare(train2, ticketClass);

            // Deduct booked seats from seat availability
            UpdateSeatAvailability(seatAvailability, ticketClass);


            // Add booked ticket to the database
            var newTicket = new booked_ticket
            {
                PNR = GenerateUniquePNR(),
                userId = uid,
                trainNo = trainNo,
                passengerName = passengerName,
                passengerAge = passengerAge,
                ticketClass = ticketClass,
                totalFare = fare,
                bookingDateTime = DateTime.Now
            };

            TRDB.booked_ticket.Add(newTicket);
            TRDB.SaveChanges();

            Console.WriteLine("Ticket booked successfully.");
        }

        static bool IsPNRUnique(int pnr)
        {
            // Check if the generated PNR already exists in the database
            return TRDB.booked_ticket.Any(bt => bt.PNR == pnr);
        }

        static Random random = new Random();
        static int GenerateUniquePNR()
        {
            int pnr;
            do
            {
                // Generate a random number for PNR
                pnr = random.Next(1000, 5001); // Range from 1000 to 5000
            } while (IsPNRUnique(pnr)); // Check if the generated PNR is unique
            return pnr;
        }



        static void CancelTicket()
        {
            Console.Write("Enter your user ID:");
            int userId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter PNR (Passenger Name Record) number:");
            int pnr = Convert.ToInt32(Console.ReadLine());

            // Find the booked ticket
            var ticket = TRDB.booked_ticket.FirstOrDefault(bt => bt.PNR == pnr && bt.userId == userId);
            if (ticket == null)
            {
                Console.WriteLine("No ticket found with the specified PNR number.");
                return;
            }

            // Refund the amount
            Console.WriteLine();
            double refundAmount = ticket.totalFare * 0.75f; // Assuming 75% refund policy
            Console.WriteLine($"Refund amount: {refundAmount}");

            // Update seat availability
            var seatAvailability = TRDB.seat_availability.FirstOrDefault(sa => sa.trainNo == ticket.trainNo);
            if (seatAvailability != null)
            {
                AddCancelledSeats(seatAvailability, ticket.ticketClass);
            }

            // Add cancelled ticket to the database
            var cancelledTicket = new canceled_ticket
            {
                canceledId = pnr, // Assuming canceledId is PNR
                userId = userId,
                trainNo = ticket.trainNo,
                cancellationDateTime = DateTime.Now,
                refundAmount = refundAmount
            };

            TRDB.canceled_ticket.Add(cancelledTicket);
            TRDB.SaveChanges();

            // Remove booked ticket from the database
            TRDB.booked_ticket.Remove(ticket);
            TRDB.SaveChanges();

            Console.WriteLine("Ticket cancelled successfully.");
        }

        //method for showing all trains
        static void ShowAllTrains()
        {
            var trains = TRDB.train_details.Where(td => td.Status != "Deactivated").ToList();
            Console.WriteLine("All Trains:");
            foreach (var train in trains)
            {

                Console.WriteLine($"Train No: {train.trainNo},  Name: {train.trainName},  From: {train.From},  To: {train.To},  Status: {train.Status}");
            }
        }

        //method for show booked tickets
        static void ShowBookedTickets(int userId)
        {
            var bookedTickets = TRDB.booked_ticket.Where(bt => bt.userId == userId).ToList();

            if (bookedTickets.Count == 0)
            {
                Console.WriteLine("No booked tickets found for the specified user.");
                return;
            }

            Console.WriteLine("Booked Tickets:");
            foreach (var ticket in bookedTickets)
            {
                Console.WriteLine($"PNR: {ticket.PNR}, Train No: {ticket.trainNo}, Passenger Name: {ticket.passengerName}, Class: {ticket.ticketClass}, Fare: {ticket.totalFare}, Booking Date: {ticket.bookingDateTime}");
            }
        }


        //method for show all tickets Booked and Cancelled in one place
        static void ShowBookingCancellation(int uid)
        {
            int userId = uid;

            var bookedTickets = TRDB.booked_ticket.Where(bt => bt.userId == userId).ToList();
            Console.WriteLine("Booked Tickets:");
            foreach (var ticket in bookedTickets)
            {
                Console.WriteLine($"PNR: {ticket.PNR}, Train No: {ticket.trainNo}, Passenger Name: {ticket.passengerName}, Class: {ticket.ticketClass}, Fare: {ticket.totalFare}, Booking Date: {ticket.bookingDateTime}");
            }

            var cancelledTickets = TRDB.canceled_ticket.Where(t => t.userId == userId).ToList();
            Console.WriteLine("Cancelled Tickets:");
            foreach (var ticket in cancelledTickets)
            {
                Console.WriteLine($"Cancelled ID: {ticket.canceledId}, PNR: {ticket.canceledId}, Train No: {ticket.trainNo}, Cancellation Date: {ticket.cancellationDateTime}, Refund Amount: {ticket.refundAmount}");
            }
        }

        static bool HasAvailableSeats(seat_availability seatAvailability, string ticketClass)
        {
            switch (ticketClass)
            {
                case "1AC":
                    return seatAvailability.C1AC > 0;
                case "2AC":
                    return seatAvailability.C2AC > 0;
                case "3AC":
                    return seatAvailability.C3AC > 0;
                case "SL":
                    return seatAvailability.SL > 0;
                default:
                    return false;
            }
        }

        static float GetFare(train_classes train, string ticketClass)
        {
            switch (ticketClass)
            {
                case "1AC":
                    return (float)train.C1AC;
                case "2AC":
                    return (float)train.C2AC;
                case "3AC":
                    return (float)train.C3AC;
                case "SL":
                    return (float)train.SL;
                default:
                    return 0;
            }
        }

        static void UpdateSeatAvailability(seat_availability seatAvailability, string ticketClass)
        {
            switch (ticketClass)
            {
                case "1AC":
                    seatAvailability.C1AC--;
                    break;
                case "2AC":
                    seatAvailability.C2AC--;
                    break;
                case "3AC":
                    seatAvailability.C3AC--;
                    break;
                case "SL":
                    seatAvailability.SL--;
                    break;
            }
        }

        static void AddCancelledSeats(seat_availability seatAvailability, string ticketClass)
        {
            switch (ticketClass)
            {
                case "1AC":
                    seatAvailability.C1AC++;
                    break;
                case "2AC":
                    seatAvailability.C2AC++;
                    break;
                case "3AC":
                    seatAvailability.C3AC++;
                    break;
                case "SL":
                    seatAvailability.SL++;
                    break;
            }
        }

    }
}
