create database Projects

use Projects


Create Table Doctor (
  DoctorID int   primary key ,
  Fname varchar(50),
  Lname varchar(50),
  SSN bigint unique ,
  PhoneNumber bigint unique,
  Specialization varchar(50) ,
  Position varchar(50) ,
  Salary decimal,
  Password varchar(50)  ,
  Hired bit,
 
)
 

Create Table Rooms (
  RoomNumber bigint  ,
  Type varchar(50),
  Availability bit,
  primary key (RoomNumber),
  )


Create Table Patient (
  PatientID int , 
  Fname varchar(50),
  Lname varchar(50),
  SSN bigint unique,
  DrID int ,
  PhoneNumber bigint unique,
  Password varchar(50) ,
  primary key (PatientID),
  foreign key (DrID) references Doctor(DoctorID)

)



Create Table Pharmacy (
  DrugID int  ,
  Type varchar(50),
  Cost int,
  ExpDate date,
  Alternative int,
  Quantity int,
  primary key (DrugID),
  foreign key (Alternative) references Pharmacy(DrugID)

)

Create Table Nurse (
  NurseID int  ,
  Fname varchar(50),
  Lname varchar(50),
  SSN bigint unique,
  PhoneNumber bigint unique,
  Salary decimal,
  Password varchar(50) ,

  primary key (NurseID),


)

Create Table Feedback (
  DoctorID int  ,
  PatientID int   , 
  Feedback varchar(200) unique ,
  primary key (DoctorID,PatientID),
  foreign key (DoctorID) references Doctor(DoctorID),
  foreign key (PatientID) references Patient(PatientID)


)

Create Table Emergency (
  ID int  ,
  DrID int ,
  PatientID int,
  IfRoomNeeded bit,
  RoomNo bigint,
  Entrydate date,
  Cost bigint,
  primary key (ID),
  foreign key (DrID) references Doctor(DoctorID),
  foreign key (PatientID) references Patient(PatientID),
  foreign key (RoomNo) references Rooms(RoomNumber),

)

Create Table Machines (
  ID int  ,
  Type varchar(50),
  MaintCost bigint,
  primary key (ID),
)

Create Table Tests (
  ID int  ,
  Type varchar(50),
  Description varchar(100) ,
  Price int,
  primary key (ID),

)


Create Table Patient_Test (
  PatientId int  ,
  TestID int    ,
  primary key (PatientId,TestID),
  foreign key (PatientID) references Patient(PatientID),
  foreign key (TestID) references Tests(ID),
)

Create Table Past_Surgeries (
  PatientID int  ,
  Past_Surgeries varchar(50)  ,
  primary key (PatientId,Past_Surgeries),
  foreign key (PatientID) references Patient(PatientID),  
  
)

Create Table Allergies (
  PatientID int  ,
  Allergies varchar(50)  ,
  primary key (PatientId,Allergies),
  foreign key (PatientID) references Patient(PatientID),  
  
)

Create Table Medications (

  PatientID int  ,
  DrugID int  ,
  Quantity int,
  primary key (PatientId,DrugID),
  foreign key (PatientID) references Patient(PatientID),  
  foreign key (DrugID) references Pharmacy(DrugID),  
)

Create Table Appointment (
  PatientID int,
  DoctorID  int,
  RoomID    bigint,
  Date datetime,
  Cost bigint,
  primary key (PatientID,DoctorID,RoomID),
  foreign key (DoctorID) references Doctor(DoctorID),
  foreign key (PatientID) references Patient(PatientID),
  foreign key (RoomID) references Rooms(RoomNumber),
)

Create Table PharmaTransaction (
  TID int IDENTITY(1,1) ,
  DrugID int,
  Quantity int,
  Cost int,

  primary key (TID),
  foreign key (DrugID) references Pharmacy(DrugID),  

)


Create Table MachineMaintenance (
  TID int  ,
  MachineID int,
  Cost int,
  primary key (TID),
  foreign key (MachineID) references Machines(ID),  
 
)

Create Table DrCheckIn (
  DoctorID int  ,
  CheckIn datetime     ,
  CheckOut datetime     ,
  primary key (DoctorID,CheckIn,CheckOut),
  foreign key (DoctorID) references Doctor(DoctorID),

)

Create Table NurseCheckIn (
   NurseID int  ,
   CheckIn datetime   ,
   CheckOut datetime  ,
   primary key (NurseID,CheckIn,CheckOut),
   foreign key (NurseID) references Nurse(NurseID),
)

Create Table EmergencyMachines (
   EmergencyID int  ,
   MachineID int  ,
   primary key (EmergencyID,MachineID),
   foreign key (EmergencyID) references Emergency(ID),  
   foreign key (MachineID) references Machines(ID),  
)


Create Table LooksAfter (
   NurseID int  ,
   PatientID int  ,
   primary key (NurseID,PatientID),
   foreign key (NurseID) references Nurse(NurseID),
   foreign key (PatientID) references Patient(PatientID),

)

/////////////////////////////////////////


CREATE PROCEDURE Selectalldocs
AS
BEGIN
SELECT *
FROM Doctor
where Hired=1
END
GO

CREATE PROCEDURE SelectNOThiredDocs
AS
BEGIN
SELECT * 
FROM Doctor
where Hired=0
END
GO

CREATE PROCEDURE SelectAllDrugs
AS
BEGIN
SELECT * 
FROM Pharmacy
END
GO

CREATE PROCEDURE SelectAllMachines
AS
BEGIN
SELECT * 
FROM Machines
END
GO


CREATE PROCEDURE SelectAllNurses
AS
BEGIN
SELECT * 
FROM Nurse
END
GO


CREATE PROCEDURE UpdateDrugQuantity @quantity int , @ID int
AS
BEGIN
Update Pharmacy 
Set Quantity = Quantity + @quantity 
where DrugID = @ID
END
GO


CREATE PROCEDURE UpdateDoctorHire  @ID int
AS
BEGIN
Update Doctor 
Set Hired=1
where DoctorID = @ID
END
GO



CREATE PROCEDURE SelectDoctorFeedback  @ID int
AS
BEGIN
SELECT Feedback 
FROM Feedback 
where DoctorID =@ID
END
GO

CREATE PROCEDURE SelectSurgeries  @ID int
AS
BEGIN
SELECT Past_Surgeries 
FROM Past_Surgeries
where PatientID = @ID 
END
GO

CREATE PROCEDURE SelectAllergies  @ID int
AS
BEGIN
SELECT Allergies 
FROM Allergies
where PatientID = @ID 
END
GO
 
--////////////////////////////////////////////////
 
 --Doctor

INSERT INTO Doctor (DoctorID, Fname, Lname, SSN, PhoneNumber, Specialization, Position, Salary, Password, Hired)Values (1 ,'John', 'Doe', 123456789, 9876543210, 'General Practitioner', 'Attending', 100000, 'password1', 1)
INSERT INTO Doctor (DoctorID, Fname, Lname, SSN, PhoneNumber, Specialization, Position, Salary, Password, Hired)Values (2, 'Jane', 'Smith', 987654321, 1234567890, 'Cardiologist', 'Consultant', 120000, 'password2', 1)
INSERT INTO Doctor (DoctorID, Fname, Lname, SSN, PhoneNumber, Specialization, Position, Salary, Password, Hired) Values( 3, 'Olivia', 'Garcia', 725839164, 8912345670, 'Dermatologist', 'Resident', 75000, 'password3',1)
INSERT INTO Doctor (DoctorID, Fname, Lname, SSN, PhoneNumber, Specialization, Position, Salary, Password, Hired)Values( 4, 'Michael', 'Lee', 496317825, 9123456780, 'Oncologist', 'Senior Attending', 150000, 'password4',1)
INSERT INTO Doctor (DoctorID, Fname, Lname, SSN, PhoneNumber, Specialization, Position, Salary, Password, Hired)Values( 5, 'Emma', 'Miller', 631579284, 1234567891, 'Neurologist', 'Fellow', 95000, 'password5',1)
INSERT INTO Doctor (DoctorID, Fname, Lname, SSN, PhoneNumber, Specialization, Position, Salary, Password, Hired) Values( 6, 'Noah', 'Davis', 825936147, 2345678912, 'Psychiatrist', 'Attending', 110000, 'password6',1)
INSERT INTO Doctor (DoctorID, Fname, Lname, SSN, PhoneNumber, Specialization, Position, Salary, Password, Hired)Values( 7, 'Sophia', 'Wright', 953178624, 3456789123, 'Ophthalmologist', 'Consultant', 105000, 'password7',1)
INSERT INTO Doctor (DoctorID, Fname, Lname, SSN, PhoneNumber, Specialization, Position, Salary, Password, Hired)Values( 8, 'Alexander', 'Jackson', 258963741, 4567891234, 'Orthopedic Surgeon', 'Attending', 125000, 'password8',1)
INSERT INTO Doctor (DoctorID, Fname, Lname, SSN, PhoneNumber, Specialization, Position, Salary, Password, Hired)Values( 9, 'Victoria', 'Taylor', 536921874, 5678912345, 'Dentist', 'Resident', 80000, 'password9',1)
INSERT INTO Doctor (DoctorID, Fname, Lname, SSN, PhoneNumber, Specialization, Position, Salary, Password, Hired)Values( 10, 'Daniel', 'Walker', 172583964, 6789123456, 'Radiologist', 'Senior Attending', 130000, 'password10',1)


--////////////////////////////////////////////////

--Room

INSERT INTO Rooms (RoomNumber, Type, Availability) VALUES (101, 'Single', 1);
INSERT INTO Rooms (RoomNumber, Type, Availability) VALUES (102, 'Double', 0);
INSERT INTO Rooms (RoomNumber, Type, Availability) VALUES (103, 'ICU', 1);
INSERT INTO Rooms (RoomNumber, Type, Availability) VALUES (104, 'Examination', 1);
INSERT INTO Rooms (RoomNumber, Type, Availability) VALUES (105, 'Operating', 0);
INSERT INTO Rooms (RoomNumber, Type, Availability) VALUES (106, 'Recovery', 1);
INSERT INTO Rooms (RoomNumber, Type, Availability) VALUES (107, 'Isolation', 0);
INSERT INTO Rooms (RoomNumber, Type, Availability) VALUES (108, 'Labor', 1);
INSERT INTO Rooms (RoomNumber, Type, Availability) VALUES (109, 'Emergency', 1);
INSERT INTO Rooms (RoomNumber, Type, Availability) VALUES (110, 'Shared Ward', 0);


--////////////////////////////////////////////////

--Patient

INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (1, 'Alice', 'Jones', 31492687, 1, 789023456, 'patient11');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (2, 'Bob', 'Williams', 82569174, 2, 901245678, 'patient12');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (3, 'Olivia', 'Garcia', 59214386, 3, 013456789, 'patient13');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (4, 'Michael', 'Lee', 26835714, 4, 12567890, 'patient14');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (5, 'Emma', 'Miller', 91472563, 5, 245678901, 'patient15');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (6, 'Noah', 'Davis', 36914857, 6, 356789012, 'patient16');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (7, 'Sophia', 'Wright', 82791364, 7, 456790123, 'patient17');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (8, 'Alexander', 'Jackson', 59164278, 8, 567801234, 'patient18');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (9, 'Victoria', 'Taylor', 21743956, 9, 678902345, 'patient19');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (10, 'Daniel', 'Walker', 93612587, 10, 799023456, 'patient20');


INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (11, 'Alice', 'Jones', 314592687, 1, 7890123456, 'patient11');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (12, 'Bob', 'Williams', 825369174, 2, 9012345678, 'patient12');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (13, 'Olivia', 'Garcia', 579214386, 3, 0123456789, 'patient13');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (14, 'Michael', 'Lee', 268357194, 4, 1234567890, 'patient14');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (15, 'Emma', 'Miller', 914725863, 5, 2345678901, 'patient15');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (16, 'Noah', 'Davis', 369148257, 6, 3456789012, 'patient16');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (17, 'Sophia', 'Wright', 825791364, 7, 4567890123, 'patient17');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (18, 'Alexander', 'Jackson', 593164278, 8, 5678901234, 'patient18');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (19, 'Victoria', 'Taylor', 217483956, 9, 6789012345, 'patient19');
INSERT INTO Patient (PatientID, Fname, Lname, SSN, DrID, PhoneNumber, Password) VALUES (20, 'Daniel', 'Walker', 936142587, 10, 7990123456, 'patient20');


--////////////////////////////////////////////////

--Pharmacy

-- Antihypertensive and diuretic
INSERT INTO Pharmacy (DrugID, Type, Cost, ExpDate , Quantity) VALUES (11, 'Antihypertensive', 25, '2025-02-28', 40);
INSERT INTO Pharmacy (DrugID, Type, Cost, ExpDate, Quantity) VALUES (12, 'Diuretic', 18, '2024-10-31', 35);

Update Pharmacy Set Alternative =12 where DrugID =11
Update Pharmacy Set Alternative =11 where DrugID =12

-- Antidepressant and anxiolytic
INSERT INTO Pharmacy (DrugID, Type, Cost, ExpDate, Quantity) VALUES (13, 'Antidepressant', 30, '2025-04-15', 25);
INSERT INTO Pharmacy (DrugID, Type, Cost, ExpDate, Quantity) VALUES (14, 'Anxiolytic', 20, '2024-12-15', 30);


Update Pharmacy Set Alternative =14 where DrugID =13
Update Pharmacy Set Alternative =13 where DrugID =14

-- Antibiotic and pain reliever
INSERT INTO Pharmacy (DrugID, Type, Cost, ExpDate,  Quantity) VALUES (15, 'Antibiotic', 45, '2025-03-31', 20);
INSERT INTO Pharmacy (DrugID, Type, Cost, ExpDate,  Quantity) VALUES (16, 'Pain reliever', 15, '2024-11-30',  50);


Update Pharmacy Set Alternative =16 where DrugID =15
Update Pharmacy Set Alternative =15 where DrugID =16

-- Antihistamine and asthma medication
INSERT INTO Pharmacy (DrugID, Type, Cost, ExpDate,  Quantity) VALUES (17, 'Antihistamine', 12, '2025-05-15',  60);
INSERT INTO Pharmacy (DrugID, Type, Cost, ExpDate,  Quantity) VALUES (18, 'Asthma medication', 35, '2024-12-20', 45);

Update Pharmacy Set Alternative =18 where DrugID =17
Update Pharmacy Set Alternative =17 where DrugID =18

--////////////////////////////////////////////////

--Nurse

INSERT INTO Nurse (NurseID, Fname, Lname, SSN, PhoneNumber, Salary, Password ) VALUES (11, 'Mary', 'Jones', 639258147, 9876543211, 75000, 'nurse11');
INSERT INTO Nurse (NurseID, Fname, Lname, SSN, PhoneNumber, Salary, Password ) VALUES (12, 'Peter', 'Brown', 596317824, 0123456782, 80000, 'nurse12');
INSERT INTO Nurse (NurseID, Fname, Lname, SSN, PhoneNumber, Salary, Password ) VALUES (13, 'Olivia', 'Garcia', 731579284, 1234567893, 70000, 'nurse13');
INSERT INTO Nurse (NurseID, Fname, Lname, SSN, PhoneNumber, Salary, Password ) VALUES (14, 'Michael', 'Lee', 46317825, 2345678904, 85000, 'nurse14');
INSERT INTO Nurse (NurseID, Fname, Lname, SSN, PhoneNumber, Salary, Password ) VALUES (15, 'Emma', 'Miller', 61579284, 3456789015, 90000, 'nurse15');
INSERT INTO Nurse (NurseID, Fname, Lname, SSN, PhoneNumber, Salary, Password ) VALUES (16, 'Noah', 'Davis', 85936147, 4567890126, 82000, 'nurse16');
INSERT INTO Nurse (NurseID, Fname, Lname, SSN, PhoneNumber, Salary, Password ) VALUES (17, 'Sophia', 'Wright', 93178624, 5678901237, 78000, 'nurse17');
INSERT INTO Nurse (NurseID, Fname, Lname, SSN, PhoneNumber, Salary, Password ) VALUES (18, 'Alexander', 'Jackson', 28963741, 6789012348, 92000, 'nurse18');
INSERT INTO Nurse (NurseID, Fname, Lname, SSN, PhoneNumber, Salary, Password ) VALUES (19, 'Victoria', 'Taylor', 56921874, 7890123459, 87000, 'nurse19');
INSERT INTO Nurse (NurseID, Fname, Lname, SSN, PhoneNumber, Salary, Password) VALUES (20, 'Daniel', 'Walker', 172583964, 8901234560, 75000, 'nurse20');



--////////////////////////////////////////////////

--Feedback


INSERT INTO Feedback (DoctorID, PatientID, Feedback)
VALUES (1, 11, 'Very knowledgeable and explained my condition clearly.');

INSERT INTO Feedback (DoctorID, PatientID, Feedback)
VALUES (2, 12, 'Patient and listened to my concerns, but long wait time.');

INSERT INTO Feedback (DoctorID, PatientID, Feedback)
VALUES (3, 13, 'Friendly and helpful, but seemed a bit rushed.');

INSERT INTO Feedback (DoctorID, PatientID, Feedback)
VALUES (4, 14, 'Excellent bedside manner and thorough explanations.');

INSERT INTO Feedback (DoctorID, PatientID, Feedback)
VALUES (5, 15, 'Very professional and addressed all my questions.');

INSERT INTO Feedback (DoctorID, PatientID, Feedback)
VALUES (6, 16, 'Took the time to understand my concerns and made me feel comfortable.');

INSERT INTO Feedback (DoctorID, PatientID, Feedback)
VALUES (7, 17, 'Very thorough and explained everything in detail, which I appreciated.');

INSERT INTO Feedback (DoctorID, PatientID, Feedback)
VALUES (8, 18, 'Great listener and provided helpful advice.');

INSERT INTO Feedback (DoctorID, PatientID, Feedback)
VALUES (9, 19, 'Made me feel at ease and confident in my treatment plan.');

INSERT INTO Feedback (DoctorID, PatientID, Feedback)
VALUES (10, 20, 'Very knowledgeable and experienced, I would highly recommend.');




--////////////////////////////////////////////////

--Emergency

INSERT INTO Emergency (ID, DrID, PatientID, IfRoomNeeded, RoomNo, Entrydate, Cost)
VALUES (1, 5, 11, 1, 104, '2023-12-28', 4500);  -- Assigning available room 104

INSERT INTO Emergency (ID, DrID, PatientID, IfRoomNeeded, RoomNo, Entrydate, Cost)
VALUES (2, 7, 15, 0, NULL, '2023-12-28', 3200);  -- No room needed

INSERT INTO Emergency (ID, DrID, PatientID, IfRoomNeeded, RoomNo, Entrydate, Cost)
VALUES (3, 1, 19, 1, 109, '2023-12-28', 5100);  -- Assigning available room 109

INSERT INTO Emergency (ID, DrID, PatientID, IfRoomNeeded, RoomNo, Entrydate, Cost)
VALUES (4, 4, 16, 1, 101, '2023-12-28', 3850);  -- Assigning available room 101

INSERT INTO Emergency (ID, DrID, PatientID, IfRoomNeeded, RoomNo, Entrydate, Cost)
VALUES (5, 8, 14, 0, NULL, '2023-12-28', 2900);  -- No room needed

--////////////////////////////////////////////////

--Machines

INSERT INTO Machines (ID, Type, MaintCost)
VALUES (1, 'CT Scanner', 14697);

INSERT INTO Machines (ID, Type, MaintCost)
VALUES (2, 'X-ray', 11257);

INSERT INTO Machines (ID, Type, MaintCost)
VALUES (3, 'CT Scanner', 13503);

INSERT INTO Machines (ID, Type, MaintCost)
VALUES (4, 'MRI', 48127);

INSERT INTO Machines (ID, Type, MaintCost)
VALUES (5, 'Dialysis Machine', 10690);

INSERT INTO Machines (ID, Type, MaintCost)
VALUES (6, 'MRI', 23008);

INSERT INTO Machines (ID, Type, MaintCost)
VALUES (7, 'X-ray', 24236);

INSERT INTO Machines (ID, Type, MaintCost)
VALUES (8, 'MRI', 16236);

INSERT INTO Machines (ID, Type, MaintCost)
VALUES (9, 'Dialysis Machine', 49360);

INSERT INTO Machines (ID, Type, MaintCost)
VALUES (10, 'X-ray', 45124);



--////////////////////////////////////////////////

--Tests


INSERT INTO Tests (ID, Type, Description, Price)
VALUES (1, 'Blood Test', 'Complete Blood Count (CBC)', 54.00);

INSERT INTO Tests (ID, Type, Description, Price)
VALUES (2, 'Urine Test', 'Urinalysis', 35.00);

INSERT INTO Tests (ID, Type, Description, Price)
VALUES (3, 'Imaging Test', 'X-ray (Chest)', 125.00);

INSERT INTO Tests (ID, Type, Description, Price)
VALUES (4, 'Blood Test', 'Comprehensive Metabolic Panel (CMP)',85.00);

INSERT INTO Tests (ID, Type, Description, Price)
VALUES (5, 'Imaging Test', 'CT Scan (Head)', 350.00);

INSERT INTO Tests (ID, Type, Description, Price)
VALUES (6, 'Allergy Test', 'Skin Prick Test', 100.0);

INSERT INTO Tests (ID, Type, Description, Price)
VALUES (7, 'Genetic Test', 'Carrier Screening for Cystic Fibrosis', 250);

INSERT INTO Tests (ID, Type, Description, Price)
VALUES (8, 'Blood Test', 'Hemoglobin A1c Test', 40.00);

INSERT INTO Tests (ID, Type, Description, Price)
VALUES (9, 'Imaging Test', 'MRI (Brain)', 750.00);

INSERT INTO Tests (ID, Type, Description, Price)
VALUES (10, 'Urine Test', 'Urine Culture', 45.00);

--////////////////////////////////////////////////

--Patient_Tests
INSERT INTO Patient_Test (PatientId, TestID)
VALUES (11, 2);  -- Patient 11 assigned Urinalysis test

INSERT INTO Patient_Test (PatientId, TestID)
VALUES (15, 3);  -- Patient 15 assigned X-ray (Chest) test

INSERT INTO Patient_Test (PatientId, TestID)
VALUES (19, 1);  -- Patient 19 assigned Complete Blood Count (CBC) test

INSERT INTO Patient_Test (PatientId, TestID)
VALUES (16, 4);  -- Patient 16 assigned Comprehensive Metabolic Panel (CMP) test

INSERT INTO Patient_Test (PatientId, TestID)
VALUES (14, 5);  -- Patient 14 assigned CT Scan (Head) test

INSERT INTO Patient_Test (PatientId, TestID)
VALUES (12, 6);  -- Patient 12 assigned Skin Prick Test

INSERT INTO Patient_Test (PatientId, TestID)
VALUES (17, 7);  -- Patient 17 assigned Carrier Screening for Cystic Fibrosis

INSERT INTO Patient_Test (PatientId, TestID)
VALUES (18, 8);  -- Patient 18 assigned Hemoglobin A1c Test

INSERT INTO Patient_Test (PatientId, TestID)
VALUES (13, 9);  -- Patient 13 assigned MRI (Brain)

INSERT INTO Patient_Test (PatientId, TestID)
VALUES (20, 10); -- Patient 20 assigned Urine Culture


--////////////////////////////////////////////////

--Past_surgeries

INSERT INTO Past_Surgeries (PatientID, Past_Surgeries)
VALUES (11, 'Appendectomy');

INSERT INTO Past_Surgeries (PatientID, Past_Surgeries)
VALUES (11, 'Tonsillectomy');

INSERT INTO Past_Surgeries (PatientID, Past_Surgeries)
VALUES (12, 'Cataract surgery');

INSERT INTO Past_Surgeries (PatientID, Past_Surgeries)
VALUES (13, 'Knee arthroscopy');

INSERT INTO Past_Surgeries (PatientID, Past_Surgeries)
VALUES (14, 'Gallbladder removal');

INSERT INTO Past_Surgeries (PatientID, Past_Surgeries)
VALUES (15, 'C-section');

INSERT INTO Past_Surgeries (PatientID, Past_Surgeries)
VALUES (16, 'Open heart surgery');

INSERT INTO Past_Surgeries (PatientID, Past_Surgeries)
VALUES (17, 'Spinal fusion');

INSERT INTO Past_Surgeries (PatientID, Past_Surgeries)
VALUES (18, 'Dental implant placement');

INSERT INTO Past_Surgeries (PatientID, Past_Surgeries)
VALUES (19, 'Skin cancer removal');


--////////////////////////////////////////////////

--Allergies
INSERT INTO Allergies (PatientID, Allergies)
VALUES (11, 'Penicillin');

INSERT INTO Allergies (PatientID, Allergies)
VALUES (11, 'Pollen');

INSERT INTO Allergies (PatientID, Allergies)
VALUES (12, 'Shellfish');

INSERT INTO Allergies (PatientID, Allergies)
VALUES (13, 'Bee stings');

INSERT INTO Allergies (PatientID, Allergies)
VALUES (13, 'Shellfish');

INSERT INTO Allergies (PatientID, Allergies)
VALUES (13, 'Latex');

INSERT INTO Allergies (PatientID, Allergies)
VALUES (14, 'Nuts');

INSERT INTO Allergies (PatientID, Allergies)
VALUES (15, 'Aspirin');

INSERT INTO Allergies (PatientID, Allergies)
VALUES (16, 'Dust mites');

INSERT INTO Allergies (PatientID, Allergies)
VALUES (16, 'Shellfish');


--////////////////////////////////////////////
--Medications

INSERT INTO Medications (PatientID, DrugID, Quantity)
VALUES (11, 11, 9);

INSERT INTO Medications (PatientID, DrugID, Quantity)
VALUES (12, 11, 4);

INSERT INTO Medications (PatientID, DrugID, Quantity)
VALUES (12, 13, 11);

INSERT INTO Medications (PatientID, DrugID, Quantity)
VALUES (13, 14, 10);

INSERT INTO Medications (PatientID, DrugID, Quantity)
VALUES (14, 15, 3);

INSERT INTO Medications (PatientID, DrugID, Quantity)
VALUES (14, 16, 4);

INSERT INTO Medications (PatientID, DrugID, Quantity)
VALUES (14, 17, 18);

INSERT INTO Medications (PatientID, DrugID, Quantity)
VALUES (15, 13, 18);

INSERT INTO Medications (PatientID, DrugID, Quantity)
VALUES (15, 18, 30);

INSERT INTO Medications (PatientID, DrugID, Quantity)
VALUES (16, 12, 26);

--////////////////////////////////////////////
--Appointments

INSERT INTO Appointment (PatientID, DoctorID, RoomID, Date, Cost)
VALUES (14, 5, 104, '2024-04-05 14:00:00', 250);

INSERT INTO Appointment (PatientID, DoctorID, RoomID, Date, Cost)
VALUES (16, 3, 109, '2024-03-28 11:30:00', 175);

INSERT INTO Appointment (PatientID, DoctorID, RoomID, Date, Cost)
VALUES (11, 1, 101, '2024-04-12 09:45:00', 120);

INSERT INTO Appointment (PatientID, DoctorID, RoomID, Date, Cost)
VALUES (18, 8, 106, '2024-04-01 16:15:00', 300);

INSERT INTO Appointment (PatientID, DoctorID, RoomID, Date, Cost)
VALUES (15, 5, 104, '2024-03-21 10:00:00', 250);

INSERT INTO Appointment (PatientID, DoctorID, RoomID, Date, Cost)
VALUES (19, 9, 103, '2024-04-15 13:30:00', 400);

INSERT INTO Appointment (PatientID, DoctorID, RoomID, Date, Cost)
VALUES (12, 2, 104, '2024-03-30 15:00:00', 250);


--////////////////////////////////////////////
--PharmaTransAction

INSERT INTO PharmaTransaction ( DrugID, Quantity, Cost)
VALUES ( 15, 12, 540);  -- Sale of 12 units of antibiotic
INSERT INTO PharmaTransaction ( DrugID, Quantity, Cost)
VALUES ( 17, 30, 360);  -- Sale of 30 units of antihistamine
INSERT INTO PharmaTransaction ( DrugID, Quantity, Cost)
VALUES ( 11, 25, 625);  -- Sale of 25 units of antihypertensive
INSERT INTO PharmaTransaction ( DrugID, Quantity, Cost)
VALUES ( 16, 10, 150);  -- Sale of 10 units of pain reliever
INSERT INTO PharmaTransaction ( DrugID, Quantity, Cost)
VALUES ( 13, 15, 450);  -- Sale of 15 units of antidepressant
INSERT INTO PharmaTransaction ( DrugID, Quantity, Cost)
VALUES ( 18, 20, 700);  -- Sale of 20 units of asthma medication
INSERT INTO PharmaTransaction ( DrugID, Quantity, Cost)
VALUES ( 14, 5, 100);   -- Sale of 5 units of anxiolytic



--////////////////////////////////////////////
--MachineMaint


INSERT INTO MachineMaintenance (TID, MachineID, Cost)
VALUES (1001, 5, 8552);  -- Maintenance for dialysis machine 5
INSERT INTO MachineMaintenance (TID, MachineID, Cost)
VALUES (1002, 4, 48127);  -- Full maintenance for MRI machine 4
INSERT INTO MachineMaintenance (TID, MachineID, Cost)
VALUES (1003, 7, 12118);  -- Partial maintenance for X-ray machine 7
INSERT INTO MachineMaintenance (TID, MachineID, Cost)
VALUES (1004, 1, 7348);   -- Partial maintenance for CT scanner 1
INSERT INTO MachineMaintenance (TID, MachineID, Cost)
VALUES (1005, 9, 16453);  -- Partial maintenance for dialysis machine 9
INSERT INTO MachineMaintenance (TID, MachineID, Cost)
VALUES (1006, 3, 13503);  -- Full maintenance for CT scanner 3
INSERT INTO MachineMaintenance (TID, MachineID, Cost)
VALUES (1007, 6, 9203);   -- Partial maintenance for MRI machine 6
INSERT INTO MachineMaintenance (TID, MachineID, Cost)
VALUES (1008, 2, 11257);  -- Full maintenance for X-ray machine 2




--////////////////////////////////////////////
--EmergencyMachines 


INSERT INTO EmergencyMachines (EmergencyID, MachineID)
VALUES (1, 2);  -- Emergency 1 used X-ray machine 2
INSERT INTO EmergencyMachines (EmergencyID, MachineID)
VALUES (1, 1);  -- Emergency 1 also used CT Scanner 1
INSERT INTO EmergencyMachines (EmergencyID, MachineID)
VALUES (3, 8);  -- Emergency 3 used MRI machine 8
INSERT INTO EmergencyMachines (EmergencyID, MachineID)
VALUES (4, 5);  -- Emergency 4 used Dialysis Machine 5



--////////////////////////////////////////////
--Looks After


INSERT INTO LooksAfter (NurseID, PatientID)
VALUES (11, 11);  -- Nurse Mary Jones looks after patient Alice Jones
INSERT INTO LooksAfter (NurseID, PatientID)
VALUES (14, 15);  -- Nurse Michael Lee looks after patient Emma Miller
INSERT INTO LooksAfter (NurseID, PatientID)
VALUES (15, 18);  -- Nurse Emma Miller looks after patient Alexander Jackson
INSERT INTO LooksAfter (NurseID, PatientID)
VALUES (16, 12);  -- Nurse Noah Davis looks after patient Bob Williams
INSERT INTO LooksAfter (NurseID, PatientID)
VALUES (18, 19);  -- Nurse Alexander Jackson looks after patient Victoria Taylor
INSERT INTO LooksAfter (NurseID, PatientID)
VALUES (19, 16);  -- Nurse Victoria Taylor looks after patient Noah Davis

INSERT INTO LooksAfter (NurseID, PatientID) VALUES (11, 12); -- Nurse Mary Jones also looks after Bob Williams
INSERT INTO LooksAfter (NurseID, PatientID) VALUES (15, 17); -- Nurse Emma Miller also looks after Sophia Wright
INSERT INTO LooksAfter (NurseID, PatientID) VALUES (18, 11); -- Nurse Alexander Jackson also looks after Alice Jones







--////////////////////////////////////////////
--DrcheckIn

INSERT INTO DrCheckIn (DoctorID, CheckIn, CheckOut)
VALUES (4, '2024-04-05 08:00:00', '2024-04-05 17:30:00'); -- Dr. Michael Lee
INSERT INTO DrCheckIn (DoctorID, CheckIn, CheckOut)
VALUES (2, '2024-04-05 09:15:00', '2024-04-05 16:00:00'); -- Dr. Jane Smith
INSERT INTO DrCheckIn (DoctorID, CheckIn, CheckOut)
VALUES (8, '2024-04-05 10:30:00', '2024-04-05 18:45:00'); -- Dr. Alexander Jackson
INSERT INTO DrCheckIn (DoctorID, CheckIn, CheckOut)
VALUES (5, '2024-04-04 07:45:00', '2024-04-04 16:15:00'); -- Dr. Emma Miller
INSERT INTO DrCheckIn (DoctorID, CheckIn, CheckOut)
VALUES (1, '2024-04-04 09:00:00', '2024-04-04 17:00:00'); -- Dr. John Doe
INSERT INTO DrCheckIn (DoctorID, CheckIn, CheckOut)
VALUES (7, '2024-04-06 08:30:00', '2024-04-06 16:45:00'); -- Dr. Sophia Wright
INSERT INTO DrCheckIn (DoctorID, CheckIn, CheckOut)
VALUES (9, '2024-04-06 10:00:00', '2024-04-06 14:00:00'); -- Dr. Victoria Taylor
INSERT INTO DrCheckIn (DoctorID, CheckIn, CheckOut)
VALUES (3, '2024-04-06 11:15:00', '2024-04-06 18:00:00'); -- Dr. Olivia Garcia



--////////////////////////////////////////////
--NurseCheckIn


INSERT INTO NurseCheckIn (NurseID, CheckIn, CheckOut)
VALUES (11, '2023-12-28 07:00:00', '2023-12-28 15:30:00'); -- Nurse Mary Jones
INSERT INTO NurseCheckIn (NurseID, CheckIn, CheckOut)
VALUES (15, '2023-12-28 08:15:00', '2023-12-28 16:45:00'); -- Nurse Emma Miller
INSERT INTO NurseCheckIn (NurseID, CheckIn, CheckOut)
VALUES (18, '2023-12-28 09:30:00', '2023-12-28 18:00:00'); -- Nurse Alexander Jackson
INSERT INTO NurseCheckIn (NurseID, CheckIn, CheckOut)
VALUES (12, '2023-12-29 07:00:00', '2023-12-29 15:30:00'); -- Nurse Peter Brown
INSERT INTO NurseCheckIn (NurseID, CheckIn, CheckOut)
VALUES (14, '2023-12-29 08:15:00', '2023-12-29 16:45:00'); -- Nurse Michael Lee

