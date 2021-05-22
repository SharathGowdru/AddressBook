using System;

namespace EditContacts
{
    class Program
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zipCode;
        public long phoneNumber;
        public string emailId;

        Program()
        {
            this.firstName = "Sharath";
            this.lastName = "Gowda";
            this.address = "Sharada Nagar";
            this.city = "Hassan";
            this.state = "Karnataka";
            this.zipCode = 573116;
            this.phoneNumber = 25648;
            this.emailId = "Sharus9587@gmail.com";
        }
        static void Main(string[] args)
        {
            Program e = new Program();
            Console.WriteLine("Please enter the name to edit the details");
            string n = Console.ReadLine();
            e.editDetails(n);
           
        }

       void editDetails(string name)
        {
            if (name.Equals(firstName.ToLower()))
            {
                setFname();
                setLname();
                setAdd();
                setCity();
                setState();
                setZip();
                setPhoneNumber();
                setEmail();

                display();
            }
            else
            {
                Console.WriteLine("Please enter the valid name" +"\n"+" the available Contacts are");
                display();
            }
        }
        void display()
        {
            Console.WriteLine("FirstName  : " + getFname());
            Console.WriteLine("Last Name : " + getLname());
            Console.WriteLine("Address :" + getAdd());
            Console.WriteLine("CIty :" + getCity());
            Console.WriteLine("State :" + getState());
            Console.WriteLine("ZipCode :" + getZip());
            Console.WriteLine("Phone Number : " + getPhoneNumber());
            Console.WriteLine("Email Id : " + getEmail());
        }
        string getFname()
        {
            return firstName;

        }
        public void setFname()
        {
            Console.WriteLine("Please enter the First name");
            firstName = Console.ReadLine();
        }
        string getLname()
        {
            return lastName;
        }
        public void setLname()
        {
            Console.WriteLine("Please enter the last name");
            lastName = Console.ReadLine();
        }
        string getAdd()
        {
            return address;
        }
        public void setAdd()
        {
            Console.WriteLine("Please enter the Address :");
            address = Console.ReadLine();
        }
        string getCity()
        {
            return city;
        }
        public void setCity()
        {
            Console.WriteLine("Please enter the City :");
            city = Console.ReadLine();
        }
        string getState()
        {
            return state;
        }
        public void setState()
        {
            Console.WriteLine("Please enter the State :");
            state = Console.ReadLine();
        }
        int getZip()
        {
            return zipCode;
        }
        public void setZip()
        {
            Console.WriteLine("Please enter the ZipCode :");
            try
            {

                zipCode = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        long getPhoneNumber()
        {
            return phoneNumber;
        }
        public void setPhoneNumber()
        {
            Console.WriteLine("Please enter the PhoneNumber : ");
            try
            {
                phoneNumber = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        string getEmail()
        {
            return emailId;
        }
        public void setEmail()
        {
            Console.WriteLine("Please enter the Email Id :");
            emailId = Console.ReadLine();
        }
    }
}