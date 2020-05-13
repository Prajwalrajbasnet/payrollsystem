# Payroll System

Payroll System is a desktop application for windows which makes it very easy to calculate total payment for employees according to their working hours/days, holidays, deductions, tax etc. Just entering those facts through form payable amount is calculated. The payroll can be saved in the database which gets represented in the table and can be removed after payment is done. It also helps to maintain payment history. 

A simple login system is used to protect from unauthorized access. Users can be added by adding new entries in the database.

## Prerequisites
[visual studio](https://visualstudio.microsoft.com/)
, [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-2019), [.NET framework](https://dotnet.microsoft.com/download/dotnet-framework/net472)

Note: visual studio is not necessary if you don't intend to mess up with source code

## Installation
Clone the repository and open the sln file using [visual studio](https://visualstudio.microsoft.com/). Copy the msdbdata.mdf file from databases folder to wherever you want to keep it and provide it's path in database connection string: 
```C#
SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ; Integrated Security = True; Connect Timeout = 30;");
//put your file path after AttachDbFilename

```
Build the project and run it from visual studio. 

Or you may install the premade release located in /bin/release folder. Install the executable 


## Usage
The login screen prompts for username and password the default username/password is payroll/payroll. You may change or add new user entries by querying the database.  
```SQL
UPDATE naya SET username="newusername" password="newpassword" where id=1;

INSERT INTO naya(username,password) VALUES(newuser, newpassword);  
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## Author
Prajwal Raj Basnet
