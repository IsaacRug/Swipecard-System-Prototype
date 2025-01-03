namespace Swipe_Card_System_Prototype
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateRoomState = new System.Windows.Forms.Button();
            this.cmbRoomState = new System.Windows.Forms.ComboBox();
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSwipeCardType = new System.Windows.Forms.ComboBox();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSwipeTime = new System.Windows.Forms.TextBox();
            this.btnSimulateSwipe = new System.Windows.Forms.Button();
            this.txtSimulateRoomNumber = new System.Windows.Forms.TextBox();
            this.txtSimulateUserID = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnLoadLogs = new System.Windows.Forms.Button();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(37, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1212, 763);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnUpdateRoomState);
            this.tabPage1.Controls.Add(this.cmbRoomState);
            this.tabPage1.Controls.Add(this.lstRooms);
            this.tabPage1.Controls.Add(this.btnRemoveRoom);
            this.tabPage1.Controls.Add(this.btnAddRoom);
            this.tabPage1.Controls.Add(this.cmbRoomType);
            this.tabPage1.Controls.Add(this.txtRoomNumber);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1204, 737);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rooms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Room State:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(60, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Room Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(429, 90);
            this.label4.TabIndex = 10;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Room Name:";
            // 
            // btnUpdateRoomState
            // 
            this.btnUpdateRoomState.BackColor = System.Drawing.Color.LightSalmon;
            this.btnUpdateRoomState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoomState.Location = new System.Drawing.Point(237, 232);
            this.btnUpdateRoomState.Name = "btnUpdateRoomState";
            this.btnUpdateRoomState.Size = new System.Drawing.Size(75, 44);
            this.btnUpdateRoomState.TabIndex = 6;
            this.btnUpdateRoomState.Text = "Change State";
            this.btnUpdateRoomState.UseVisualStyleBackColor = false;
            this.btnUpdateRoomState.Click += new System.EventHandler(this.btnUpdateRoomState_Click);
            // 
            // cmbRoomState
            // 
            this.cmbRoomState.FormattingEnabled = true;
            this.cmbRoomState.Items.AddRange(new object[] {
            "Normal",
            "Emergency"});
            this.cmbRoomState.Location = new System.Drawing.Point(64, 246);
            this.cmbRoomState.Name = "cmbRoomState";
            this.cmbRoomState.Size = new System.Drawing.Size(121, 21);
            this.cmbRoomState.TabIndex = 5;
            // 
            // lstRooms
            // 
            this.lstRooms.BackColor = System.Drawing.Color.White;
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.Location = new System.Drawing.Point(579, 44);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(337, 524);
            this.lstRooms.TabIndex = 4;
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.BackColor = System.Drawing.Color.LightSalmon;
            this.btnRemoveRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveRoom.Location = new System.Drawing.Point(237, 124);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(75, 42);
            this.btnRemoveRoom.TabIndex = 3;
            this.btnRemoveRoom.Text = "Remove Room";
            this.btnRemoveRoom.UseVisualStyleBackColor = false;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Location = new System.Drawing.Point(237, 44);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(75, 38);
            this.btnAddRoom.TabIndex = 2;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Lecture Hall",
            "Teaching Room",
            " Staff Room",
            "Secure Room"});
            this.cmbRoomType.Location = new System.Drawing.Point(64, 137);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(121, 21);
            this.cmbRoomType.TabIndex = 1;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(64, 55);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(121, 20);
            this.txtRoomNumber.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cmbSwipeCardType);
            this.tabPage2.Controls.Add(this.lstUsers);
            this.tabPage2.Controls.Add(this.btnRemoveUser);
            this.tabPage2.Controls.Add(this.btnAddUser);
            this.tabPage2.Controls.Add(this.txtUserID);
            this.tabPage2.Controls.Add(this.txtUserName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1204, 737);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Swipe Card Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "User ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Username:";
            // 
            // cmbSwipeCardType
            // 
            this.cmbSwipeCardType.FormattingEnabled = true;
            this.cmbSwipeCardType.Items.AddRange(new object[] {
            "Staff",
            "Student",
            "Visitor",
            "Contract Cleaner",
            "Manager",
            "Security",
            "Emergency Responder"});
            this.cmbSwipeCardType.Location = new System.Drawing.Point(58, 207);
            this.cmbSwipeCardType.Name = "cmbSwipeCardType";
            this.cmbSwipeCardType.Size = new System.Drawing.Size(121, 21);
            this.cmbSwipeCardType.TabIndex = 5;
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(463, 24);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(232, 550);
            this.lstUsers.TabIndex = 4;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.Color.LightSalmon;
            this.btnRemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.Location = new System.Drawing.Point(233, 143);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(75, 48);
            this.btnRemoveUser.TabIndex = 3;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(233, 67);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 45);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(58, 128);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(58, 58);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtSwipeTime);
            this.tabPage3.Controls.Add(this.btnSimulateSwipe);
            this.tabPage3.Controls.Add(this.txtSimulateRoomNumber);
            this.tabPage3.Controls.Add(this.txtSimulateUserID);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1204, 737);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Simulation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(105, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Time Of Swipe (HH:MM):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Room Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "User ID:";
            // 
            // txtSwipeTime
            // 
            this.txtSwipeTime.Location = new System.Drawing.Point(109, 297);
            this.txtSwipeTime.Name = "txtSwipeTime";
            this.txtSwipeTime.Size = new System.Drawing.Size(100, 20);
            this.txtSwipeTime.TabIndex = 4;
            // 
            // btnSimulateSwipe
            // 
            this.btnSimulateSwipe.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSimulateSwipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulateSwipe.Location = new System.Drawing.Point(407, 179);
            this.btnSimulateSwipe.Name = "btnSimulateSwipe";
            this.btnSimulateSwipe.Size = new System.Drawing.Size(90, 55);
            this.btnSimulateSwipe.TabIndex = 3;
            this.btnSimulateSwipe.Text = "Simulate Swipe";
            this.btnSimulateSwipe.UseVisualStyleBackColor = false;
            this.btnSimulateSwipe.Click += new System.EventHandler(this.btnSimulateSwipe_Click);
            // 
            // txtSimulateRoomNumber
            // 
            this.txtSimulateRoomNumber.Location = new System.Drawing.Point(109, 198);
            this.txtSimulateRoomNumber.Name = "txtSimulateRoomNumber";
            this.txtSimulateRoomNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSimulateRoomNumber.TabIndex = 1;
            // 
            // txtSimulateUserID
            // 
            this.txtSimulateUserID.Location = new System.Drawing.Point(109, 96);
            this.txtSimulateUserID.Name = "txtSimulateUserID";
            this.txtSimulateUserID.Size = new System.Drawing.Size(100, 20);
            this.txtSimulateUserID.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage4.Controls.Add(this.btnLoadLogs);
            this.tabPage4.Controls.Add(this.lstLogs);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1204, 737);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Logs";
            // 
            // btnLoadLogs
            // 
            this.btnLoadLogs.BackColor = System.Drawing.Color.LightSalmon;
            this.btnLoadLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadLogs.Location = new System.Drawing.Point(272, 22);
            this.btnLoadLogs.Name = "btnLoadLogs";
            this.btnLoadLogs.Size = new System.Drawing.Size(94, 38);
            this.btnLoadLogs.TabIndex = 1;
            this.btnLoadLogs.Text = "Show/Update Log";
            this.btnLoadLogs.UseVisualStyleBackColor = false;
            this.btnLoadLogs.Click += new System.EventHandler(this.btnLoadLogs_Click);
            // 
            // lstLogs
            // 
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.Location = new System.Drawing.Point(50, 66);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(1139, 654);
            this.lstLogs.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1301, 841);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.ListBox lstRooms;
        private System.Windows.Forms.Button btnRemoveRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Button btnUpdateRoomState;
        private System.Windows.Forms.ComboBox cmbRoomState;
        private System.Windows.Forms.Button btnSimulateSwipe;
        private System.Windows.Forms.TextBox txtSimulateRoomNumber;
        private System.Windows.Forms.TextBox txtSimulateUserID;
        private System.Windows.Forms.ComboBox cmbSwipeCardType;
        private System.Windows.Forms.TextBox txtSwipeTime;
        private System.Windows.Forms.ListBox lstLogs;
        private System.Windows.Forms.Button btnLoadLogs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}

