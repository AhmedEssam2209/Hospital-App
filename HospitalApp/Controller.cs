using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System.Collections;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }


        public DataTable SelectAllDoctors()
        {
            //string query = "SELECT * FROM Doctor where Hired=1;";
            //return dbMan.ExecuteReader(query);

            return dbMan.ExecuteReader("Selectalldocs", null);
        }
        public object SelectDoctorSalary(int id)
        {
            string query = "SELECT Salary FROM Doctor where DoctorID = " + id + ";";
            return dbMan.ExecuteScalar(query);

        }

        public object SelectNurseSalary(int id)
        {
            string query = "SELECT Salary FROM Nurse where NurseID = " + id + ";";
            return dbMan.ExecuteScalar(query);

        }

        public DataTable SelectAllNOThiredDoctors()
        {
            //string query = "SELECT * FROM Doctor where Hired=0;";
            //return dbMan.ExecuteReader(query);
            return dbMan.ExecuteReader("SelectNOThiredDocs", null);

        }
        public DataTable SelectAllDrugs()
        {
            //string query = "SELECT * FROM Pharmacy;";
            //return dbMan.ExecuteReader(query);
            return dbMan.ExecuteReader("SelectAllDrugs", null);
        }
        public DataTable SelectAllNurses()
        {
            //string query = "SELECT NurseID,Fname,Lname,Salary FROM Nurse;";
            //return dbMan.ExecuteReader(query);
            return dbMan.ExecuteReader("SelectAllNurses", null);

        }
        public DataTable SelectAllMachines()
        {
            //string query = "SELECT * FROM Machines;";
            //return dbMan.ExecuteReader(query);
            return dbMan.ExecuteReader("SelectAllMachines", null);

        }
        public DataTable SelectDoctorFeedback(int DrID)
        {
            //string query = "SELECT Feedback FROM Feedback where DoctorID=" + DrID + ";";
            //return dbMan.ExecuteReader(query);
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", DrID);
            return dbMan.ExecuteReader("SelectDoctorFeedback", Parameters);

        }

        public int UpdateDocSalary(int ID, decimal salary)
        {
            string query = "Update Doctor Set Salary = " + salary + " where DoctorID = " + ID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateDoctorHire(int ID)
        {
            //string query = "Update Doctor Set Hired = 1 where DoctorID = " + ID + ";";
            //return dbMan.ExecuteNonQuery(query);
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return dbMan.ExecuteNonQuery("UpdateDoctorHire", Parameters);

        }

        public int UpdateNurseSalary(int ID, decimal salary)
        {
            string query = "Update Nurse Set Salary = " + salary + " where NurseID = " + ID + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateManagerPass(string newpass)
        {
            string query = "Update Doctor Set Password = '" + newpass + "' where DoctorID = 1";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateDrugQuantity(int ID, int quantity)
        {
            //string query = "Update Pharmacy Set Quantity = " + quantity + " + where DrugID = " + ID + ";";
            //return dbMan.ExecuteNonQuery(query);
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@quantity", quantity);
            Parameters.Add("@ID", ID);

            return dbMan.ExecuteNonQuery("UpdateDoctorHire", Parameters);

        }
        public int InsertPharmaTrans(int DID, int quantity, int cost)
        {
            string query = "INSERT INTO PharmaTransaction (DrugID,Quantity,Cost) " +
                  "Values (" + DID + "," + quantity + "," + cost + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertMachTrans(int mID, int cost)
        {
            string query = "INSERT INTO MachineMaintenance (MachineID,Cost) " +
                  "Values (" + mID + "," + cost + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        

        public int DeleteDoctor(int ID)
        {
            string query = "Delete From Doctor Where DoctorID = " + ID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeleteNurse(int ID)
        {
            string query = "Delete From Nurse Where NurseID = " + ID + ";";
            return dbMan.ExecuteNonQuery(query);
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////
       


        public DataTable SelectPatients()
        {
            string query = "SELECT * FROM Patient;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectTests()
        {
            string query = "SELECT * FROM Tests;";
            return dbMan.ExecuteReader(query);
        }

        public int AddMedication(int PID, int DID, int Q)
        {
            string query = "INSERT INTO Medications (PatientID,DrugID,Quantity)" +
                "Values(" + PID + "," + DID + "," + Q + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int AddTests(int PID, int TID)
        {
            string query = "INSERT INTO Patient_Test (PatientId,TestID)" +
                "Values(" + PID + "," + TID + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectAllergies(int PID)
        {
            //    string query = "SELECT Past_Surgeries FROM Past_Surgeries where PatientID=" + PID + ";";
            //    return dbMan.ExecuteReader(query);
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", PID);
            return dbMan.ExecuteReader("SelectAllergies", Parameters);

        }

        public DataTable SelectSurgeries(int PID)
        {

            //string query = "SELECT Allergies FROM Allergies where PatientID=" + PID + ";";
            //return dbMan.ExecuteReader(query);
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", PID);
            return dbMan.ExecuteReader("SelectSurgeries", Parameters);

        }

        public DataTable SelectFeedback(int DID)
        {
            string query = "SELECT PatientID and Feedback FROM Feedback WHERE DoctorID=" + DID + ";";
            return dbMan.ExecuteReader(query);
        }

        public int updateDoctorpass(string FName, string LName,string pass)
        {
            string query = "UPDATE Doctor SET Password='" + pass + "' WHERE Fname='" + FName + "' and Lname='" + LName + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Selectappointments(int DID)
        {
            string query = "SELECT PatientID and RoomID and Date and Cost FROM Appointment where DoctorID=" + DID + ";";
            return dbMan.ExecuteReader(query);
        }
        public int updatePatientpass(string FName,string Lname, string pass)
        {
            string query = "UPDATE Patient SET Password='" + pass + "' WHERE Fname='" + FName + "' and  Lname='" + Lname + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectMedications(int PID)
        {
            string query = "SELECT P.Type FROM Pharmacy P and Medications M WHERE PatientID=" + PID + " and P.DrugID=M.DrugID ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectTests(int PID)
        {
            string query = "SELECT TestID and Type and Description and Price FROM Tests and Patient_Test WHERE PatientID=" + PID + " and TestID=ID;";
            return dbMan.ExecuteReader(query);
        }
        public int GiveFeedback(int PID, int DID, String feedback)
        {
            string query = "INSERT INTO Feedback(DoctorID,PatientID,Feedback)" +
                "Values(" + DID + "," + PID + ",'" + feedback + "');";
            return dbMan.ExecuteNonQuery(query);

        }
        public DataTable SelectDoctor()
        {
            //string query = "SELECT * FROM Doctor;";
            //return dbMan.ExecuteReader(query);
            return dbMan.ExecuteReader("Selectalldocs", null);

        }
        public DataTable GetDoctorInfo()
        {
            string query = "SELECT DoctorID,Fname,Lname,Specialization,Position FROM Doctor WHERE Hired =1 ";
            return dbMan.ExecuteReader(query);

        }
        public DataTable GetDoctorFeedback()
        {
            string query = "SELECT Feedback , DoctorID FROM Feedback ";
            return dbMan.ExecuteReader(query);

        }
        public int ChooseDoctor(int ssn, int DID)
        {
            string query = "UPDATE Patient P SET DrID= " + DID + " WHERE P.SSN=" + ssn + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateAppointment(int PID, string date)
        {

            string query = "UPDATE Appointment SET Date'" + date + "' WHERE PatientID = " + PID + "; ";
            return dbMan.ExecuteNonQuery(query);

        }
        public int DeleteAppointment( int PID,string date)
        {

            string query = "DELETE FROM Appointment WHERE PatientID=" + PID + "and Date='" + date + "';";
            return dbMan.ExecuteNonQuery(query);

        }

        public DataTable ViewAppointmentDetails(int PID)
        {
            string query = "SELECT PatientID,DoctorID,RoomID,Date,Cost FROM Appointment A, Patient P where PatientID=" + PID + " and P.PatientID==A.PatientID; ";
            return dbMan.ExecuteReader(query);

        }
        public int GetPatientID(int ssn)
        {
            string query = "SELECT PatientID FROM Patient WHERE SSN=" + ssn + ";";
            return (int)dbMan.ExecuteScalar(query);

        }
        public int GetDoctorID(string fname, string lname)
        {
            string query = "SELECT DoctorID FROM Doctor WHERE ' WHERE Fname='" + fname + "' and Lname='" + lname + "'; ";
            return (int)dbMan.ExecuteScalar(query);

        }

        public DataTable ViewAllPatients(int DID)
        {

            string query = "SELECT PatientID,Fname,Lname,PhoneNumber FROM Patient WHERE DrID=" + DID + ";";
            return dbMan.ExecuteReader(query);

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public object CountPatiants()
        {
            string q = "Select Count(*) From Patient";
            return dbMan.ExecuteScalar(q);
        }
        public object CountDoctors()
        {
            string q = "Select Count(*) From Doctor";
            return dbMan.ExecuteScalar(q);
        }
        public int SignUp_Patient(string fname, string lname, int ssn, int phno, string passw)
        {
            object x = CountPatiants();
            int id = int.Parse(Convert.ToString(x)) + 1;
            string q = "Insert Into Patient Values (" + id + ",'" + fname + "','" + lname + "'," + ssn
                + ",null," + phno + ",'" + passw + "')";
            return dbMan.ExecuteNonQuery(q);
        }
        public int SignUp_Doctor(string fname, string lname, int ssn, int phno, string spec, string position, int exp_sal, string passw)
        {
            object x = CountDoctors();
            int id = int.Parse(Convert.ToString(x)) + 1;
            string q = "Insert Into Doctor Values (" + id + ",'" + fname + "','" + lname + "'," + ssn + "," + phno + ",'" + spec
                + "','" + position + "'," + exp_sal + ",'" + passw + "' ,0)";
            return dbMan.ExecuteNonQuery(q);
        }
        public int Add_Appointment(int pid, int d_id, int rno, DateTime date, int cost)
        {
            string q = "Insert Into Appointment Values (" + pid + "," + d_id + "," + rno + "," + date + "," + cost + "')";
            return dbMan.ExecuteNonQuery(q);
        }
        public int SetRoomToUnavailbe(int RoomNo)
        {
            string q = " Update Rooms Set Availability = 1 Where RoomNumber = " + RoomNo;
            return dbMan.ExecuteNonQuery(q);
        }
        public int DrCheckIn_Out(int DID, DateTime checkin, DateTime checkout)
        {
            string query = "INSERT INTO DrCheckIn " +
                  "Values (" + DID + "," + checkin + "," + checkout + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int NurseCheckIn_Out(int NID, DateTime checkin, DateTime checkout)
        {
            string query = "INSERT INTO NurseCheckIn " +
                  "Values (" + NID + "," + checkin + "," + checkout + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int AddWorkingHours(int Duration, int Dr_id)
        {
            string q = " Update Doctor Set Hours_Worked = " + Duration + " Where DoctorID = " + Dr_id;
            return dbMan.ExecuteNonQuery(q);
        }
        public object GetMangPass()
        {
            string q = "Select Password From Doctor Where DoctorID = 1";
            return dbMan.ExecuteScalar(q);
        }
        public object GetDocPass(string fname, string lname)
        {
            string q = "Select Password From Doctor Where Fname = '" + fname + "' and  Lname = '" + lname + "';";
            return dbMan.ExecuteScalar(q);
        }

        public object GetPatientPass(string fname, string lname)
        {
            string q = "Select Password From Patient Where Fname = '" + fname + "' and  Lname = '" + lname+ "';";
            return dbMan.ExecuteScalar(q);
        }
        public object GetRecepPass()
        {
            string q = "Select Password From Nurse Where NurseID = 1";
            return dbMan.ExecuteScalar(q);
        }
        public DataTable GetPatientsFname()
        {
            string q = "Select Fname From Patient";
            return dbMan.ExecuteReader(q);
        }
        public DataTable GetDoctorsFname()
        {
            string q = "Select Fname From Doctor where Hired=1";
            return dbMan.ExecuteReader(q);
        }
        public DataTable GetDoctorsID()
        {
            string q = "Select DoctorID From Doctor where Hired=1";
            return dbMan.ExecuteReader(q);
        }
        public DataTable GetNursesID()
        {
            string q = "Select NurseID From Nurse where Hired=1";
            return dbMan.ExecuteReader(q);
        }
        public DataTable GetPatientsID()
        {
            string q = "Select PatientID From Patient";
            return dbMan.ExecuteReader(q);
        }
        public DataTable GetPatientsLname(string fname)
        {
            string q = "Select Lname From Patient Where Fname = " + fname;
            return dbMan.ExecuteReader(q);
        }
        public DataTable GetDoctorsLname(string fname)
        {
            string q = "Select Lname From Doctor Where Fname = " + fname;
            return dbMan.ExecuteReader(q);
        }
        public DataTable GetPatientsInfo(string fname, string lname)
        {
            string q = "Select * From Patient Where Fname = " + fname + " and Lname = " + lname;
            return dbMan.ExecuteReader(q);
        }
        public DataTable GetDoctorsInfo(string fname, string lname)
        {
            string q = "Select * From Doctor Where Fname = " + fname + " and Lname = " + lname;
            return dbMan.ExecuteReader(q);
        }
        public DataTable GetDrugsID()
        {
            string q = "Select DrugID From Medications Group By DrugID";
            return dbMan.ExecuteReader(q);
        }
        public object GetRemainingDrugQty(int DrugID)
        {
            string q = "Select sum(Quantity) From Medications Where DrugID = " + DrugID + " Group By DrugID";
            return dbMan.ExecuteScalar(q);
        }
        public DataTable GetAvailableRooms()
        {
            string q = "Select RoomNumber From Rooms Where Availability = 0";
            return dbMan.ExecuteReader(q);
        }
    }
}
