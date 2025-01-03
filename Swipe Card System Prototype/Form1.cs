using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Swipe_Card_System_Prototype
{

    




    public partial class Form1 : Form
    {
        private List<User> users = new List<User>();     // List to store users
        private List<Room> rooms = new List<Room>();    // List to store rooms

        private UserList userList;           // Observable user list
        private RoomList roomList = new RoomList();  // Observable room list

        public Form1()
        {
            InitializeComponent();

            // observable objects
            userList = new UserList();
            roomList = new RoomList();

            //ConsoleObservers for lstUsers and lstRooms
            var userObserver = new ConsoleObserver(lstUsers); // Attach observer to the existing lstUsers
            userList.Attach(userObserver);

            var roomObserver = new ConsoleObserver(lstRooms); // Attach observer to the existing lstRooms
            roomList.Attach(roomObserver);

            // Load initial room state
            roomList.SetState(new List<string>()); 

         

        }



        #region Users 
        //This is anything related to Users



        public class User
        {
            public string UserID { get; set; }
            public string Name { get; set; }
            public string SwipeCardType { get; set; }  

            // Constructor
            public User(string userID, string name)
            {
                if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("UserID and Name cannot be null or empty.");
                }

                UserID = userID;
                Name = name;
            }

            //display user details
            public string GetUserDetails()
            {
                return $"{UserID} - {Name} - {SwipeCardType}";
            }

            
            public override string ToString()
            {
                return GetUserDetails();
            }
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string userID = txtUserID.Text.Trim();
            string swipeCardType = cmbSwipeCardType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(swipeCardType))
            {
                MessageBox.Show("Please enter User Name, User ID, and select a Swipe Card Type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (users.Any(u => u.UserID == userID))
            {
                MessageBox.Show($"User ID '{userID}' already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Using the User constructor
            users.Add(new User(userID, userName) { SwipeCardType = swipeCardType });
            MessageBox.Show($"User '{userName}' with ID '{userID}' and Swipe Card Type '{swipeCardType}' added successfully.", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtUserName.Clear();
            txtUserID.Clear();
            cmbSwipeCardType.SelectedIndex = -1;

            UpdateUserList();
            userList.SetState(users.Select(u => u.ToString()).ToList());  
        }




        private void btnRemoveUser_Click(object sender, EventArgs e) //This is my code to remove a user from the software
        {
            string userID = txtUserID.Text.Trim();

            if (string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("Please enter a User ID to remove.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userToRemove = users.FirstOrDefault(u => u.UserID == userID);
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
                MessageBox.Show($"User with ID '{userID}' removed successfully.", "User Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No user found with ID '{userID}'.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtUserID.Clear();
            UpdateUserList();
            userList.SetState(users.Select(u => u.ToString()).ToList()); 
        }





        private void UpdateUserList()
        {
            if (lstUsers.InvokeRequired)
            {
                lstUsers.Invoke((MethodInvoker)delegate
                {
                    lstUsers.Items.Clear();
                    foreach (var user in users)
                    {
                        lstUsers.Items.Add(user.ToString());
                    }
                });
            }
            else
            {
                lstUsers.Items.Clear();
                foreach (var user in users)
                {
                    lstUsers.Items.Add(user.ToString());
                }
            }

            if (users.Count == 0)
            {
                lstUsers.Items.Add("No users available. Please add users.");
            }
        }





        #endregion







        #region Rooms
        //This is anything related to rooms


        public class Room //I have added encapulation here to demonstrade Object oriented practices, as the room details may be private or sensitive data
        {
            private string roomNumber;
            private string roomType;
            private string state;

            public string RoomNumber
            {
                get => roomNumber;
                private set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        roomNumber = value;
                    }
                }
            }

            public string RoomType
            {
                get => roomType;
                private set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        roomType = value;
                    }
                }
            }

            public string State
            {
                get => state;
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        state = value;
                    }
                }
            }

            // Constructor
            public Room(string roomNumber, string roomType)
            {
                RoomNumber = roomNumber;
                RoomType = roomType;
                State = "normal"; // Default state
            }

            public override string ToString()
            {
                return $"{RoomNumber} - {RoomType} - {State}";
            }
        }



        private void btnAddRoom_Click(object sender, EventArgs e) // This is my code to add rooms to the software
        {
            
            string roomNumber = txtRoomNumber.Text.Trim();
            string roomType = cmbRoomType.SelectedItem?.ToString();

            // Validate input
            if (string.IsNullOrEmpty(roomNumber) || string.IsNullOrEmpty(roomType))
            {
                MessageBox.Show("Please enter a Room Number and select a Room Type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicate room numbers
            if (rooms.Any(r => r.RoomNumber == roomNumber))
            {
                MessageBox.Show($"Room {roomNumber} already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add room to the list
            rooms.Add(new Room(roomNumber, roomType));
            MessageBox.Show($"Room {roomNumber} added successfully.", "Room Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear inputs
            txtRoomNumber.Clear();
            cmbRoomType.SelectedIndex = -1;

            // Update the ListBox
            UpdateRoomList();
            roomList.SetState(rooms.Select(r => r.ToString()).ToList());  
        }




        private void btnRemoveRoom_Click(object sender, EventArgs e) //This is my code to remove rooms from the software
        {
            // Get room number from input
            string roomNumber = txtRoomNumber.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(roomNumber))
            {
                MessageBox.Show("Please enter a Room Number to remove.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Find and remove room
            var roomToRemove = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
            if (roomToRemove != null)
            {
                rooms.Remove(roomToRemove);
                MessageBox.Show($"Room {roomNumber} removed successfully.", "Room Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Room {roomNumber} not found.", "Room Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Clear input
            txtRoomNumber.Clear();

            // Update the ListBox
            UpdateRoomList();
            roomList.SetState(rooms.Select(r => r.ToString()).ToList());  
        }




        private void UpdateRoomList()//for updating room list
        {
            if (lstRooms.InvokeRequired)
            {
                lstRooms.Invoke((MethodInvoker)delegate
                {
                    lstRooms.Items.Clear();
                    foreach (var room in rooms)
                    {
                        lstRooms.Items.Add(room.ToString());
                    }
                });
            }
            else
            {
                lstRooms.Items.Clear();
                foreach (var room in rooms)
                {
                    lstRooms.Items.Add(room.ToString());
                }
            }

            if (rooms.Count == 0)
            {
                lstRooms.Items.Add("No rooms available. Please add rooms.");
            }
        }




        private void btnUpdateRoomState_Click(object sender, EventArgs e) //This is my code to change the room state between normal and emergency
        {
            // Get room number and selected state
            string roomNumber = txtRoomNumber.Text.Trim();
            string selectedState = cmbRoomState.SelectedItem?.ToString();

            // Validate input
            if (string.IsNullOrEmpty(roomNumber) || string.IsNullOrEmpty(selectedState))
            {
                MessageBox.Show("Please enter a Room Number and select a Room State.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Find room and update state
            var roomToUpdate = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
            if (roomToUpdate != null)
            {
                roomToUpdate.State = selectedState;
                MessageBox.Show($"Room {roomNumber} state updated to {selectedState}.", "Room State Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Room {roomNumber} not found.", "Room Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Clear input
            txtRoomNumber.Clear();
            cmbRoomState.SelectedIndex = -1;

            // Update the ListBox
            UpdateRoomList();
        }




        #endregion






        #region swipe simulation 
        //This is anything related to simulating card swipes


        private void btnSimulateSwipe_Click(object sender, EventArgs e)
        {
            string userId = txtSimulateUserID.Text.Trim();
            string roomNumber = txtSimulateRoomNumber.Text.Trim();
            string swipeTime = txtSwipeTime.Text.Trim();

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(roomNumber) || string.IsNullOrEmpty(swipeTime))
            {
                MessageBox.Show("Please enter User ID, Room Number, and a valid swipe time.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = users.FirstOrDefault(u => u.UserID == userId);  
            if (user == null)
            {
                MessageBox.Show("Invalid User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
            if (room == null)
            {
                MessageBox.Show("Invalid Room Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool accessGranted = CheckAccess(user, room, swipeTime);

            string resultMessage = accessGranted
                ? $"Access Granted to Room {roomNumber} at {swipeTime}."
                : $"Access Denied to Room {roomNumber} at {swipeTime}.";

            LogSwipe(user.UserID, user.SwipeCardType, room, accessGranted);

            MessageBox.Show(resultMessage, accessGranted ? "Access Granted" : "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtSimulateUserID.Clear();
            txtSimulateRoomNumber.Clear();
            txtSwipeTime.Clear();
        }












        // This is my code that uses a timing method to set each swipecards acces times in each mode

        Dictionary<string, (TimeSpan start, TimeSpan end)> managerAccessTimes = new Dictionary<string, (TimeSpan, TimeSpan)>
{
    { "normal", (new TimeSpan(0,00,0), new TimeSpan(23,59,0)) }, 
    { "emergency", (TimeSpan.Zero, TimeSpan.Zero) } 
};

        Dictionary<string, (TimeSpan start, TimeSpan end)> staffAccessTimes = new Dictionary<string, (TimeSpan, TimeSpan)>
{
    { "normal", (new TimeSpan(5, 30, 0), new TimeSpan(23, 59, 59)) }, 
    { "emergency", (TimeSpan.Zero, TimeSpan.Zero) } 
};

        Dictionary<string, (TimeSpan start, TimeSpan end)> studentAccessTimes = new Dictionary<string, (TimeSpan, TimeSpan)>
{
    { "normal", (new TimeSpan(8, 30, 0), new TimeSpan(22, 0, 0)) }, 
    { "emergency", (TimeSpan.Zero, TimeSpan.Zero) } 
};

        Dictionary<string, (TimeSpan start, TimeSpan end)> visitorAccessTimes = new Dictionary<string, (TimeSpan, TimeSpan)>
{
    { "normal", (new TimeSpan(8, 30, 0), new TimeSpan(22, 0, 0)) }, 
    { "emergency", (TimeSpan.Zero, TimeSpan.Zero) } 
};

        Dictionary<string, (TimeSpan start, TimeSpan end)> cleanerAccessTimes = new Dictionary<string, (TimeSpan, TimeSpan)>
{
    { "normalMorning", (new TimeSpan(5, 30, 0), new TimeSpan(10, 30, 0)) }, // Morning access for cleaners
    { "normalEvening", (new TimeSpan(17, 30, 0), new TimeSpan(22, 30, 0)) }, // Evening access for cleaners
    { "emergency", (TimeSpan.Zero, TimeSpan.Zero) } 
};

        Dictionary<string, (TimeSpan start, TimeSpan end)> emergencyResponderAccessTimes = new Dictionary<string, (TimeSpan, TimeSpan)>
{
    { "normal", (new TimeSpan(0,00,0), new TimeSpan(23,59,0)) }, 
    { "emergency", (new TimeSpan(0,00,0), new TimeSpan(23,59,0)) } 
};

        Dictionary<string, (TimeSpan start, TimeSpan end)> securityAccessTimes = new Dictionary<string, (TimeSpan, TimeSpan)>
{
    { "normal", (new TimeSpan(0,00,0), new TimeSpan(23,59,0)) }, 
    { "emergency", (new TimeSpan(0,00,0), new TimeSpan(23,59,0)) } 
};




      




        private bool CheckAccess(User user, Room room, string swipeTime) //This is my code to check access based on what data is being simulated in the swipe.
        //it also includes a section for debugging to show the reasons behind why certain swipes may have been denied or granted
        {
            // Debugging Logs
            Console.WriteLine($"Checking access for User: {user.SwipeCardType}, Room: {room.RoomType}, Time: {swipeTime}, State: {room.State}");

            // Validate input
            if (user == null || room == null)
            {
                MessageBox.Show("Invalid user or room data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Parse swipe time
            if (!TimeSpan.TryParse(swipeTime, out TimeSpan swipeTimeSpan))
            {
                MessageBox.Show("Invalid time format. Please use the format 'HH:mm'.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Determine room state 
            string roomState = room.State?.ToUpper() ?? "NORMAL";

            //Check Room Access Rules
            bool canAccessByRoom = false;

            switch (user.SwipeCardType)
            {
                case "Student":
                    if (roomState == "NORMAL" && (room.RoomType == "Lecture Hall" || room.RoomType == "Teaching Room"))
                    {
                        canAccessByRoom = true;
                        Console.WriteLine($"Student allowed access to {room.RoomType} in NORMAL mode.");
                    }
                    break;

                case "Manager":
                    if (roomState == "NORMAL")
                    {
                        canAccessByRoom = true;
                        Console.WriteLine($"Manager allowed access to {room.RoomType} in NORMAL mode.");
                    }
                    break;

                case "Visitor":
                    if (roomState == "NORMAL" && room.RoomType == "Lecture Hall")
                    {
                        canAccessByRoom = true;
                        Console.WriteLine($"Visitor allowed access to Lecture Hall in NORMAL mode.");
                    }
                    break;

                case "Contract Cleaner":
                    // Separate section for cleaners due to moring and evening access timings
                    if (roomState == "NORMAL" && room.RoomType != "Secure Room")
                    {
                        var morningAccess = cleanerAccessTimes["normalMorning"];
                        var eveningAccess = cleanerAccessTimes["normalEvening"];

                        if ((swipeTimeSpan >= morningAccess.start && swipeTimeSpan <= morningAccess.end) ||
                            (swipeTimeSpan >= eveningAccess.start && swipeTimeSpan <= eveningAccess.end))
                        {
                            Console.WriteLine($"Access granted by time rules for Contract Cleaner.");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine($"Access denied by time rules for Contract Cleaner.");
                        }
                    }
                    break;


                case "Emergency Responder":
                    if (roomState == "EMERGENCY")
                    {
                        canAccessByRoom = true;
                        Console.WriteLine($"Emergency Responder allowed access to {room.RoomType} in EMERGENCY mode.");
                    }
                    break;

                case "Security":
                    canAccessByRoom = true; // Full access at all times
                    Console.WriteLine($"Security allowed access to {room.RoomType}.");
                    break;

                case "Staff":
                    if (roomState == "NORMAL" && room.RoomType != "Secure Room")
                    {
                        canAccessByRoom = true;
                        Console.WriteLine($"Staff allowed access to {room.RoomType} in NORMAL mode.");
                    }
                    break;

                default:
                    canAccessByRoom = false;
                    Console.WriteLine($"Access denied by room rules.");
                    break;
            }

            // Check Time Access Rules
            if (!canAccessByRoom)
            {
                Console.WriteLine($"Access denied: Room access rules failed.");
                return false;
            }

            Dictionary<string, (TimeSpan start, TimeSpan end)> timeAccess = null; //checks times against initial dictionary to ensure access is allowed
            switch (user.SwipeCardType)
            {
                case "Manager":
                    timeAccess = managerAccessTimes;
                    break;
                case "Student":
                    timeAccess = studentAccessTimes;
                    break;
                case "Visitor":
                    timeAccess = visitorAccessTimes;
                    break;
                case "Contract Cleaner":
                    timeAccess = cleanerAccessTimes;
                    break;
                case "Emergency Responder":
                    timeAccess = emergencyResponderAccessTimes;
                    break;
                case "Security":
                    timeAccess = securityAccessTimes;
                    break;
                case "Staff":
                    timeAccess = staffAccessTimes;
                    break;
            }

            if (timeAccess != null && timeAccess.ContainsKey(roomState.ToLower()))
            {
                var accessTime = timeAccess[roomState.ToLower()];
                if (swipeTimeSpan >= accessTime.start && swipeTimeSpan <= accessTime.end)
                {
                    Console.WriteLine($"Access granted by time rules.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Access denied by time rules.");
                }
            }

            Console.WriteLine($"Final access decision: Denied.");
            return false; 
        }

        private void txtSwipeTime_Validating(object sender, System.ComponentModel.CancelEventArgs e) //this is my code to ensure the timing format is correct as it is very specific
        {
            string swipeTime = txtSwipeTime.Text.Trim();

            //time format "HH:mm"
            string pattern = @"^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$";

            if (!Regex.IsMatch(swipeTime, pattern))
            {
                MessageBox.Show("Please enter the time in the format 'HH:mm'.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; 
            }
        }


        #endregion



        #region Logging


        private void LogSwipe(string userId, string swipeCardType, Room room, bool accessGranted) //this is my code to log the details of each swipe
        {
            string logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

            // Ensure the log directory exists
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            string logFilePath = Path.Combine(logDirectory, $"room_access_log_{DateTime.Now:yyyy-MM-dd}.txt");

            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: User {userId} with Swipe Card '{swipeCardType}' attempted to access Room {room.RoomNumber} ({room.State}) - {(accessGranted ? "Granted" : "Denied")}";
            File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
        }




        private void LoadLogs() //this is my code to bring the code from the project folder and display them on the logs page of the form
        {
            string logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

            if (Directory.Exists(logDirectory))
            {
              
                string[] logFiles = Directory.GetFiles(logDirectory, "room_access_log_*.txt");

                lstLogs.Items.Clear(); 

                foreach (string logFile in logFiles)
                {
                    
                    string[] logLines = File.ReadAllLines(logFile); 
                    foreach (string logLine in logLines)
                    {
                        lstLogs.Items.Add(logLine); 
                    }
                }
            }
            else
            {
                MessageBox.Show("No logs found.", "Logs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnLoadLogs_Click(object sender, EventArgs e) //this code simply updates the log when the button is pressed
        {
            LoadLogs();
        }

    }


    #endregion



}
