using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace LMS_OC
{
    class Student
    {
        int studentID;
        string firstName, lastName,address1,address2,suburb,state,email,contactNo;
        int postCode;
        double fine;
        
        public Student() { }
        
        public Student(int sID,string fName,string lName,string add1,string add2,
            string sub,string sta,int pCode,string mail,string cNo,double penalty)
        {
            this.studentID = sID;
            this.firstName = fName;
            this.lastName = lName;
            this.address1 = add1;
            this.address2 = add2;
            this.suburb = sub;
            this.state = sta;
            this.postCode = pCode;
            this.email = mail;
            this.contactNo = cNo;
            this.fine = penalty;
        }
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }
        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }
        public string Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public int PostCode
        {
            get { return postCode; }
            set { postCode = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string ContactNumber
        {
            get { return contactNo; }
            set { contactNo = value; }
        }
        public double Fine
        {
            get { return fine; }
            set { fine = value; }
        }
        public int AddNewStudent()
        {
                     
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Student values("+studentID+",'" +firstName+ "','" +lastName+ "','"+address1+"','"+address2+"','"+suburb+"','"+state+"',"+postCode+",'"+email+"','"+contactNo+"',"+fine+")";
            cmd.Connection = con;
            con.Open();
            int recordInserted = cmd.ExecuteNonQuery();
            con.Close();
            return recordInserted;
        }
        public int EditStudent()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Student set firstName='" + firstName + "',lastName='" + lastName + "',address1='" + address1 + "',address2='" + address2 + "',suburb='" + suburb + "',state='"+state+"',postCode=" + postCode + ",email='" + email + "',contactNo='" + contactNo + "' where studentID=" + studentID + "";
            cmd.Connection = con;
            con.Open();
            int recordUpdated = cmd.ExecuteNonQuery();
            con.Close();
            return recordUpdated;
        }
        
    }
}
